using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This Interface will display options for users to select what they want. (design pending)
 * Should be able to select which caliber they would like info on. (loads data from file)
 * Should be section to add new data to be stored in the file repository
 * Display each recommended load per bullet on ratio of powder-velocity
 * 
 * 
 */

namespace Reloading_App
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            FileParser FP = new FileParser();
            FP.ReadFile();
            // CaliberMenu.Items.Add("this"); // Example
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Caliber_IndexChanged(object sender, EventArgs e)
        {

        }

        private void BulletWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void PowderType_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
