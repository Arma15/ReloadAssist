using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using LoadTypes;
namespace Reloading_App
{
    /// <summary>
    /// To clairify type of data being gathered
    /// </summary>
    public enum Type
    {
        // Gun type
        Rifle = 1,
        Handgun = 2,
        // Type of data from .csv
        Header = 10,
        CaliberData = 11,
        CaliberInfo = 12
    }

    /// <summary>
    /// Will process the files in the directory
    /// </summary>
    public class FileProcessor
    {
        /// <summary>
        /// Store the path to desired file
        /// </summary>
        public string InputPath { get; private set; }
        public string RootPath { get; private set; }
        readonly char[] separators = { '_', '.' };


        /// <summary>
        /// Reads the input .csv file and processes the data
        /// </summary>
        /// <param name="NewPath"> Path to desired file to input data from</param>
        public void ProcessFiles(ref DataSource DS, string NewPath = "C:\\Users\\3D Infotech.3DCA-LY520-12\\Desktop\\Git projects\\ReloadAssist\\Reloading App\\223_35gNTX.csv")
        {
            RootPath = NewPath;
            string currCaliber, currBulletBrand, currBulletType;

            // Root directory does not exist
            if (!File.Exists(RootPath))
            {
                return;
            }
            
            string[] caliberTypes = Directory.GetDirectories(RootPath);
            // If there are no caliber folders in root directory
            if (caliberTypes == null)
            {
                return;
            }

            // Loop through the caliber files and parse the folders in each
            for (int i = 0; i < caliberTypes.Length; ++i)
            {
                string[] bulletBrands = Directory.GetDirectories(caliberTypes[i]);
                // If no files in caliber folder then go to next file
                if (bulletBrands == null)
                {
                    continue;
                }

                // Get current caliber
                string[] tempCal = Path.GetDirectoryName(caliberTypes[i]).Split(separators);
                currCaliber = tempCal[0];
                // Create a new caliber object for every caliber found in the files
                Caliber newCal = new Caliber(currCaliber);

                // Parse all data files in each folder
                for (int j = 0; j < bulletBrands.Length; ++j)
                {
                    string[] bulletTypes = Directory.GetDirectories(bulletBrands[j]);
                    // If no Bullet data exists in this folder then continue to next folder
                    if (bulletTypes == null)
                    {
                        continue;
                    }
                    
                    // Get current bullet brand
                    string[] tempBrand = Path.GetDirectoryName(bulletBrands[j]).Split(separators);
                    currBulletBrand = tempBrand[0];
                    // Create new bullet brand object for every brand found in the files
                    BulletBrand newBulletBrand = new BulletBrand(currBulletBrand);

                    // Parse each .csv data file in the folder
                    for (int k = 0; k < bulletTypes.Length; ++k)
                    {
                        string[] info = Path.GetFileName(bulletTypes[k]).Split(separators);
                        currBulletType = info[0];
                        BulletType newBulletType = new BulletType(currBulletType);

                        // Process data in the file
                        InputBulletData(bulletTypes[k], ref newBulletType);

                        // Add bulletType object to its corresponding bullet brand object
                        newBulletBrand.AddBullet(newBulletType);
                    }

                    // Add the bullet brand object to caliber object
                    newCal.AddBulletBrand(newBulletBrand);
                }
                // Add the caliber object after filled with bullet brand objects
                DS.AddCaliber(newCal);
            }
        }

        /// <summary>
        /// Formats the data gathered from the file
        /// </summary>
        /// <param name="Data"></param>
        public void InputBulletData(string filePath, ref BulletType bt)
        {
            // Read the file
            using (TextFieldParser CSVParser = new TextFieldParser(filePath))
            {
                CSVParser.SetDelimiters(",");
                CSVParser.TrimWhiteSpace = true;
                // Record the row with the column names
                string[] ColumnHeaders = CSVParser.ReadFields().Where(x => !string.IsNullOrEmpty(x)).ToArray();
                if (ColumnHeaders.Length == 0)
                {
                    // Empty data file
                    return;
                }
                int[] velocities = new int[ColumnHeaders.Length - 1];
                if (ColumnHeaders[0].ToLower() != "powder")
                {
                    // Not reading a data file
                    return;
                }
                for (int i = 1; i < ColumnHeaders.Length; ++i)
                {
                    if (int.TryParse(ColumnHeaders[i], out int newVelocity))
                    {
                        velocities[i - 1] = newVelocity;
                    }
                    else
                    {
                        // error converting string to double
                    }
                }

                // Parse through and gather the remaining data fields
                while (!CSVParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    // Fields format should be: [0] -> PowderName [1] -> [end] load ratings i.e., 20.6, 21.1 .. etc.
                    string[] Fields = CSVParser.ReadFields().Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    if (Fields.Length == 0)
                    {
                        // Should not occur
                        continue;
                    }
                    else if (Fields.Length != velocities.Length + 1)
                    {
                        // Error..should be the same size
                    }
                    // Create new powder type and initialize with the name
                    PowderType pt = new PowderType(Fields[0]);

                    // Input data gathered from file
                    for (int i = 0; i < velocities.Length; ++i)
                    {
                        if (float.TryParse(Fields[i + 1], out float load))
                        {
                            pt.AddPowderLoadAndVelocity(load, velocities[i]);
                        }
                        else if ((Fields[i + 1].ToLower() == "n/a"))
                        {
                            pt.AddPowderLoadAndVelocity(float.NaN, velocities[i]);
                        }
                        else
                        {
                            // Error
                        }
                    }
                }
            }
        }
    }
}


        
         

