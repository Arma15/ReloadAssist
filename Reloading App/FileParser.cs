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
            InputPath = NewPath;
            // Check if file path exists
            // TODO
            char[] separators = { '_', '.' }; 
            // Get the file name which contains caliber and bullet type data
            string fileName = Path.GetFileName(NewPath);
            // info[0] = caliber type, info[1] = bullet type (need to add condition for info files)
            string[] info = fileName.Split(separators);
            // Returns Name of file + extension
            string[] ColumnHeaders;
            Caliber cal = new Caliber(info[0]);

            // Read the file
            using (TextFieldParser CSVParser = new TextFieldParser(InputPath))
            {
                CSVParser.SetDelimiters(",");
                CSVParser.TrimWhiteSpace = true;

                // Record the row with the column names
                ColumnHeaders = CSVParser.ReadFields();
                ColumnHeaders = ColumnHeaders.Where(x => !string.IsNullOrEmpty(x)).ToArray();
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
