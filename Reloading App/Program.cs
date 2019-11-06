using System;
using System.Windows.Forms;
using LoadTypes;

namespace Reloading_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            FileProcessor FP = new FileProcessor();
            DataSource DS = new DataSource();

            // Load default data files
            FP.ProcessFile();
           
            // TODO
            // populate classes with the data

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
            
        }
    }
}
