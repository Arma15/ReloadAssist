using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            // CaliberMenu.Items.Add("this"); // Example
        }
        /// <summary>
        /// Prepopulated with options for the types of guns supported,
        /// this should update the options for Caliber options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GunType_IndexChanged(object sender, EventArgs e)
        {
            // Decide on selection what Caliber options the user will have
        }
        /// <summary>
        /// When user changes the options for caliber, this should update the options
        /// for bullet type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Caliber_IndexChanged(object sender, EventArgs e)
        {
            // update possible bullet types
        }
        /// <summary>
        /// When user changes the options for caliber, this should update the options
        /// for powder type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BulletType_TextChanged(object sender, EventArgs e)
        {
            // update possible options for powder types
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowderType_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Populate fields with options selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            // Display the results from the options selected
        }

    }
}
