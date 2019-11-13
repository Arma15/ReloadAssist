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
        char[] separators = { '_', '.' };

        /// <summary>
        /// Find all files ending in desired file type in provided path
        /// </summary>
        /// <param name="NewPath"></param>
        public string[] FindAllFilesInDirectory(string NewPath)
        {
            // Return an array of strings with file names in directory passed in
            string[] str = new string[0];
            return str;
        }

        /// <summary>
        /// Reads the input .csv file and processes the data
        /// </summary>
        /// <param name="NewPath"> Path to desired file to input data from</param>
        public void ProcessFile(ref DataSource DS, string NewPath = "C:\\Users\\3D Infotech.3DCA-LY520-12\\Desktop\\Git projects\\ReloadAssist\\Reloading App\\223_35gNTX.csv")
        {
            RootPath = NewPath;
            string currCaliber, currBulletBrand, currBulletType;
            // Root directory does not exist
            if (File.Exists(RootPath))
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
                // Parse all data files in each folder
                for (int j = 0; j < bulletBrands.Length; ++j)
                {
                    string[] files = Directory.GetDirectories(bulletBrands[j]);
                    string fileName;
                    // If no Bullet data exists in this folder then continue to next folder
                    if (files == null)
                    {
                        continue;
                    }
                    for (int k = 0; k < files.Length; ++k)
                    {
                        fileName = Path.GetFileName(bulletBrands[i]);
                        string[] info = fileName.Split(separators);
                        // Process data in the file
                    }


                }
            }

            // Get the file name which contains caliber and bullet type data
            // info[0] = caliber type, info[1] = bullet type (need to add condition for info files)
            // Returns Name of file + extension
            string[] ColumnHeaders;
            Caliber cal = new Caliber(info[0]);

            // Read the file
            using (TextFieldParser CSVParser = new TextFieldParser(InputPath))
            {
                CSVParser.SetDelimiters(",");
                CSVParser.TrimWhiteSpace = true;

                // Record the row with the column names
                ColumnHeaders = CSVParser.ReadFields().Where(x => !string.IsNullOrEmpty(x)).ToArray();
                // Import the headers from the file
                InputData(ColumnHeaders, ref cal, Type.Header);

                // Parse through and gather the remaining data fields
                while (!CSVParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Fields = CSVParser.ReadFields();
                    // Clears empty cells from the array
                    Fields = Fields.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    // Input data gathered from file
                    InputData(Fields, ref cal, Type.CaliberData);
                }
            }

        }

        /// <summary>
        /// Formats the data gathered from the files
        /// </summary>
        /// <param name="Data"></param>
        public void InputData(string[] Data, ref Caliber cal, Type Datatype)
        {
            if (Data.Length < 1)
            {
                return;
            }
            // TODO
            switch (Datatype)
            {
                // Input data to the data field
                case Type.CaliberData:


                    break;
                // Input data to the Caliber info field (Headers)
                case Type.CaliberInfo:
                    if (Data[0].ToLower() == "powder")
                    {
                        
                        for (int i = 1; i < Data.Length; ++i)
                        {

                        }
                    }
                    break;
                default:
                    // Type not found
                    break;
            }

           
        }

    }
         
}
