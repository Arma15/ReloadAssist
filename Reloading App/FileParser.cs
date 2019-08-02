using System;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

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
        Data = 11,
        Info = 12

    }

    /// <summary>
    /// Will process the files in the directory
    /// </summary>
    public class FileProcessor
    {
        /// <summary>
        /// Store the path to desired file
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Reads the input .csv file and processes the data
        /// </summary>
        /// <param name="NewPath"></param>
        public void ProcessFile(string NewPath = "C:\\Users\\kflor\\source\\repos\\Reloading App\\Reloading App\\223_Caliber_Info.csv")
        {
            Path = NewPath;
            string[] ColumnHeaders;
            // Read the file
            using (TextFieldParser CSVParser = new TextFieldParser(Path))
            {
                CSVParser.SetDelimiters(new string[] { "," });

                // Record the row with the column names
                ColumnHeaders = CSVParser.ReadFields();
                ColumnHeaders = ColumnHeaders.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                InputData(ColumnHeaders, Type.Header);
                while (!CSVParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Fields = CSVParser.ReadFields();
                    // Clears empty cells from the array
                    Fields = Fields.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    // Input data gathered from file
                    InputData(Fields, Type.Data);

                }

            }

        }

        /// <summary>
        /// Formats the data gathered from the files
        /// </summary>
        /// <param name="Data"></param>
        public void InputData(string[] Data, Type Datatype)
        {
            // TODO

        }

    }
         
}
