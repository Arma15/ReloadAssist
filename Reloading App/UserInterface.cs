using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LoadTypes;

/*
 * This Interface will display options for users to select what they want. (design pending)
 * Should be able to select which caliber they would like info on. (loads data from file)
 * Should be section to add new data to be stored in the file repository
 * Display each recommended load per bullet on ratio of powder-velocity
 */

namespace Reloading_App
{
    public partial class UserInterface : Form
    {
        public FileProcessor FP;
        public DataSource DS;

        private LoadSpecifics _types;
        private int _selectedGunIndex;
        private int _selectedCaliberIndex;
        private int _selectedBulletIndex;
        private int _selectedPowderIndex;

        public UserInterface()
        {
            InitializeComponent();
            _types = new LoadSpecifics();
            FP = new FileProcessor();
            DS = new DataSource("Default");
            
            InitializeComboBoxes();

            // Load default data files
            FP.ProcessFiles(ref DS);
        }

        private void InitializeComboBoxes()
        {
            for (int i = 0; i < _types.Guns.Count; ++i)
            {
                GunType_DropDown.Items.Add(_types.Guns[i]);
            }
            for (int i = 0; i < _types.Calibers.Count; ++i)
            {
                CaliberMenu_DropDown.Items.Add(_types.Calibers[i]);
            }
            for (int i = 0; i < _types.Bullets.Count; ++i)
            {
                BulletType_DropDown.Items.Add(_types.Bullets[i]);
            }
            for (int i = 0; i < _types.Powders.Count; ++i)
            {
                PowderType_DropDown.Items.Add(_types.Powders[i]);
            }
            GunType_DropDown.SelectedIndex = _selectedGunIndex = GunType_DropDown.FindString("Any");
            CaliberMenu_DropDown.SelectedIndex = _selectedCaliberIndex = CaliberMenu_DropDown.FindString("Any");
            BulletType_DropDown.SelectedIndex = _selectedBulletIndex = BulletType_DropDown.FindString("Any");
            PowderType_DropDown.SelectedIndex = _selectedPowderIndex = PowderType_DropDown.FindString("Any");
        }

        /// <summary>
        /// Prepopulated with options for the types of guns supported,
        /// this should update the options for Caliber options
        /// </summary>
        private void GunType_IndexChanged(object sender, EventArgs e)
        {
            _selectedGunIndex = GunType_DropDown.SelectedIndex;
        }
        /// <summary>
        /// When user changes the options for caliber, this should update the options
        /// </summary>
        private void Caliber_IndexChanged(object sender, EventArgs e)
        {
            _selectedCaliberIndex = CaliberMenu_DropDown.SelectedIndex;
        }
        /// <summary>
        /// When user changes the options for caliber, this should update the options
        /// </summary>
        private void BulletType_TextChanged(object sender, EventArgs e)
        {
            _selectedBulletIndex = BulletType_DropDown.SelectedIndex;
        }
        /// <summary>
        /// 
        /// </summary>
        private void PowderType_TextChanged(object sender, EventArgs e)
        {
            _selectedPowderIndex = PowderType_DropDown.SelectedIndex;
        }
        /// <summary>
        /// Populate fields with options selected
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {
            // Display the results from the options selected
            DataOutput_TextBox.Text = "NA NA NA NA \nNA NA NA NA";
            
        }

        private void PrintScreen()
        {
            DataOutput_TextBox.Text = "Data";
            DS.FindCaliber("");
        }
    }
}
