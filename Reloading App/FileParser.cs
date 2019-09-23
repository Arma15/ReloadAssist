using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System;
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
    /// Process: Given general directory containing all files, need to read each file with extension .csv
    /// save the name of the file (will be the caliber plus type), i.e., 44 cal, type = magnum.
    /// once type is identified need to parse the file. Ideal way is to have all caliber info in one file separated 
    /// by the "Powder" line which will be considered the header of each section
    /// </summary>
    public class FileProcessor
    {
        /// <summary>
        /// Store the path to desired file
        /// </summary>
        public string InputPath { get; private set; }

        /// <summary>
        /// Reads the input .csv file and processes the data
        /// </summary>
        /// <param name="NewPath"> Path to desired file to input data from</param>
        public void ProcessFile(string NewPath = "C:\\Users\\kflor\\source\\repos\\Reloading App\\Reloading App\\223_CaliberInfo.csv")
        {
            InputPath = NewPath;
            string CaliberType = Path.GetFileName(NewPath);
            // Returns Name of file + extension
            string[] ColumnHeaders;
            // Read the file
            using (TextFieldParser CSVParser = new TextFieldParser(InputPath))
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
                    InputData(Fields, Type.CaliberData);

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
            switch (Datatype)
            {
                case Type.CaliberData:
                    break;
                    // Input data to the data field
                case Type.CaliberInfo:
                    break;
                    // Input data to the Caliber info field
                default:
                    // Type not found
                    break;
            }

           
        }

    }

    public class PrintStuff
    {
        /// <summary>
        /// Formats desired data, will be abstracted more to take a generic 
        /// object in and test different types
        /// </summary>
        /// <param name="DS"></param>
        public void Formatter(DataSource DS)
        {
            const int maxnum = 7; // max num of powder loads per powder
            string[] powders = { "IMR", "H4198", "NORMA 200", "Accurate 2230", "Aliant RL-10X", "VIHT N-133", "H322", "Accurate 2460", "Benchmark", "TAC", "X-TERMINATOR" };
            float[] powderld = { 20f, 20.6f, 21.1f, 21.6f, 22.2f, 0f };
            String s = String.Format("{0,-15}{1,8}{2,8}{3,8}{4,8}{5,8}{6,8}\n", "Powder", "3300", "3400", "3500", "3600", "3700", "3800");

            s += "----------------------------------------------------------------\n";
            var v = DS.Calibers[0].BulletTypes[0].Powders[0].PowderLoadVelocity[19.2f];
            for (int index = 0; index < powders.Length; index++)
            {
                s += String.Format("{0,-15}", powders[index]);
                for (int load = 0; load < powderld.Length; load++)
                {
                    s += String.Format("{0, 8}", powderld[load]);
                }
                if (powderld.Length < maxnum)
                {
                    for (int i = powderld.Length; i < maxnum; ++i)
                    {
                        s += String.Format("{0, 8}", "N/A");
                    }
                }
                s += "\n";
            }

            Console.WriteLine($"{s}");
        }


    }
         
}
