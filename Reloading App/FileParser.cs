using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Reloading_App
{
    class FileParser
    {
        public string Path { get; private set; }

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
        /// Reads the input .csv file and stores the info
        /// </summary>
        /// <param name="NewPath"></param>
        public void ReadFile(string NewPath = "C:\\Users\\kflor\\source\\repos\\Reloading App\\Reloading App\\223_Caliber_Info.csv")
        {
            Path = NewPath;
            string[] ColumnHeaders;
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
                    Fields.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    FormatData(ref Fields);

                }

            }

        }

        /// <summary>
        /// Formats the data gathered from the files
        /// </summary>
        /// <param name="Data"></param>
        public void FormatData(ref string[] Data)
        {

        }

    }
         
}
