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
        static void Main()
        {
            FileProcessor FP = new FileProcessor();
            DataSource DS = new DataSource();

            // TODO
            // Load default data files
            // populate classes with the data

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
            
        }
    }
}
