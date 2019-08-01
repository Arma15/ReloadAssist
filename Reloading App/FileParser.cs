using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Reloading_App
{
    /// <summary>
    /// To clairify type of data being gathered
    /// </summary>
    public enum Type
    {
        Rifle = 1,
        Handgun = 2,

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

                while (!CSVParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Fields = CSVParser.ReadFields();
                    // Clears empty cells from the array
                    Fields.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    // Input data gathered from file
                    InputData(Fields);

                }

            }

        }

        /// <summary>
        /// Formats the data gathered from the files
        /// </summary>
        /// <param name="Data"></param>
        public void InputData(string[] Data)
        {
            // TODO

        }

    }
         
}
