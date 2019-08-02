namespace Reloading_App
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPage = new System.Windows.Forms.ListView();
            this.Welcome_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.DataOutput_TextBox = new System.Windows.Forms.RichTextBox();
            this.BulletType_TextBox = new System.Windows.Forms.TextBox();
            this.PowderType_TextBox = new System.Windows.Forms.TextBox();
            this.Caliber_Label = new System.Windows.Forms.Label();
            this.BulletType_Label = new System.Windows.Forms.Label();
            this.PowderType_Label = new System.Windows.Forms.Label();
            this.CaliberMenu_DropDown = new System.Windows.Forms.ComboBox();
            this.CaliberInfo_TextBox = new System.Windows.Forms.RichTextBox();
            this.CaliberInfo_Label = new System.Windows.Forms.Label();
            this.ErrorText_Label = new System.Windows.Forms.TextBox();
            this.GunType_Label = new System.Windows.Forms.Label();
            this.GunType_DropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainPage.Location = new System.Drawing.Point(12, 12);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(1014, 633);
            this.MainPage.TabIndex = 0;
            this.MainPage.UseCompatibleStateImageBehavior = false;
            // 
            // Welcome_TextBox
            // 
            this.Welcome_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Welcome_TextBox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_TextBox.Location = new System.Drawing.Point(317, 30);
            this.Welcome_TextBox.Name = "Welcome_TextBox";
            this.Welcome_TextBox.ReadOnly = true;
            this.Welcome_TextBox.Size = new System.Drawing.Size(380, 23);
            this.Welcome_TextBox.TabIndex = 1;
            this.Welcome_TextBox.Text = "Welcome to Reloading Assistant!";
            this.Welcome_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(462, 201);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Click);
            // 
            // DataOutput_TextBox
            // 
            this.DataOutput_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DataOutput_TextBox.Location = new System.Drawing.Point(25, 266);
            this.DataOutput_TextBox.Name = "DataOutput_TextBox";
            this.DataOutput_TextBox.ReadOnly = true;
            this.DataOutput_TextBox.Size = new System.Drawing.Size(988, 363);
            this.DataOutput_TextBox.TabIndex = 3;
            this.DataOutput_TextBox.Text = "Reloading Data Displayed here";
            // 
            // BulletType_TextBox
            // 
            this.BulletType_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BulletType_TextBox.Location = new System.Drawing.Point(239, 203);
            this.BulletType_TextBox.Name = "BulletType_TextBox";
            this.BulletType_TextBox.Size = new System.Drawing.Size(100, 20);
            this.BulletType_TextBox.TabIndex = 5;
            this.BulletType_TextBox.Text = "All";
            this.BulletType_TextBox.TextChanged += new System.EventHandler(this.BulletType_TextChanged);
            // 
            // PowderType_TextBox
            // 
            this.PowderType_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PowderType_TextBox.Location = new System.Drawing.Point(345, 203);
            this.PowderType_TextBox.Name = "PowderType_TextBox";
            this.PowderType_TextBox.Size = new System.Drawing.Size(100, 20);
            this.PowderType_TextBox.TabIndex = 6;
            this.PowderType_TextBox.Text = "All";
            this.PowderType_TextBox.TextChanged += new System.EventHandler(this.PowderType_TextChanged);
            // 
            // Caliber_Label
            // 
            this.Caliber_Label.AutoSize = true;
            this.Caliber_Label.Location = new System.Drawing.Point(144, 183);
            this.Caliber_Label.Name = "Caliber_Label";
            this.Caliber_Label.Size = new System.Drawing.Size(39, 13);
            this.Caliber_Label.TabIndex = 8;
            this.Caliber_Label.Text = "Caliber";
            // 
            // BulletType_Label
            // 
            this.BulletType_Label.AutoSize = true;
            this.BulletType_Label.Location = new System.Drawing.Point(246, 183);
            this.BulletType_Label.Name = "BulletType_Label";
            this.BulletType_Label.Size = new System.Drawing.Size(60, 13);
            this.BulletType_Label.TabIndex = 9;
            this.BulletType_Label.Text = "Bullet Type";
            // 
            // PowderType_Label
            // 
            this.PowderType_Label.AutoSize = true;
            this.PowderType_Label.Location = new System.Drawing.Point(356, 183);
            this.PowderType_Label.Name = "PowderType_Label";
            this.PowderType_Label.Size = new System.Drawing.Size(70, 13);
            this.PowderType_Label.TabIndex = 10;
            this.PowderType_Label.Text = "Powder Type";
            // 
            // CaliberMenu_DropDown
            // 
            this.CaliberMenu_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliberMenu_DropDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaliberMenu_DropDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CaliberMenu_DropDown.FormattingEnabled = true;
            this.CaliberMenu_DropDown.Items.AddRange(new object[] {
            ".223/5.56",
            ".308/7.62x51",
            "6.5 Creedmor",
            "7.62x39"});
            this.CaliberMenu_DropDown.Location = new System.Drawing.Point(111, 201);
            this.CaliberMenu_DropDown.Name = "CaliberMenu_DropDown";
            this.CaliberMenu_DropDown.Size = new System.Drawing.Size(122, 21);
            this.CaliberMenu_DropDown.Sorted = true;
            this.CaliberMenu_DropDown.TabIndex = 12;
            this.CaliberMenu_DropDown.Tag = "CaliberList";
            this.CaliberMenu_DropDown.Text = "Select";
            this.CaliberMenu_DropDown.SelectedIndexChanged += new System.EventHandler(this.Caliber_IndexChanged);
            // 
            // CaliberInfo_TextBox
            // 
            this.CaliberInfo_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaliberInfo_TextBox.Location = new System.Drawing.Point(543, 128);
            this.CaliberInfo_TextBox.Name = "CaliberInfo_TextBox";
            this.CaliberInfo_TextBox.ReadOnly = true;
            this.CaliberInfo_TextBox.Size = new System.Drawing.Size(470, 132);
            this.CaliberInfo_TextBox.TabIndex = 13;
            this.CaliberInfo_TextBox.Text = "Specific Caliber Info will be displayed here";
            // 
            // CaliberInfo_Label
            // 
            this.CaliberInfo_Label.AutoSize = true;
            this.CaliberInfo_Label.Location = new System.Drawing.Point(715, 112);
            this.CaliberInfo_Label.Name = "CaliberInfo_Label";
            this.CaliberInfo_Label.Size = new System.Drawing.Size(60, 13);
            this.CaliberInfo_Label.TabIndex = 14;
            this.CaliberInfo_Label.Text = "Caliber Info";
            // 
            // ErrorText_Label
            // 
            this.ErrorText_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ErrorText_Label.BackColor = System.Drawing.Color.IndianRed;
            this.ErrorText_Label.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText_Label.Location = new System.Drawing.Point(147, 128);
            this.ErrorText_Label.Margin = new System.Windows.Forms.Padding(5);
            this.ErrorText_Label.Name = "ErrorText_Label";
            this.ErrorText_Label.ReadOnly = true;
            this.ErrorText_Label.Size = new System.Drawing.Size(200, 20);
            this.ErrorText_Label.TabIndex = 15;
            this.ErrorText_Label.Text = "Errors displayed here";
            this.ErrorText_Label.Visible = false;
            // 
            // GunType_Label
            // 
            this.GunType_Label.AutoSize = true;
            this.GunType_Label.Location = new System.Drawing.Point(35, 183);
            this.GunType_Label.Name = "GunType_Label";
            this.GunType_Label.Size = new System.Drawing.Size(54, 13);
            this.GunType_Label.TabIndex = 16;
            this.GunType_Label.Text = "Gun Type";
            // 
            // GunType_DropDown
            // 
            this.GunType_DropDown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GunType_DropDown.FormattingEnabled = true;
            this.GunType_DropDown.Items.AddRange(new object[] {
            "Handgun",
            "Rifle"});
            this.GunType_DropDown.Location = new System.Drawing.Point(25, 201);
            this.GunType_DropDown.Name = "GunType_DropDown";
            this.GunType_DropDown.Size = new System.Drawing.Size(80, 21);
            this.GunType_DropDown.Sorted = true;
            this.GunType_DropDown.TabIndex = 17;
            this.GunType_DropDown.Text = "Select";
            this.GunType_DropDown.SelectedIndexChanged += new System.EventHandler(this.GunType_IndexChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1038, 657);
            this.Controls.Add(this.GunType_DropDown);
            this.Controls.Add(this.GunType_Label);
            this.Controls.Add(this.ErrorText_Label);
            this.Controls.Add(this.CaliberInfo_Label);
            this.Controls.Add(this.CaliberInfo_TextBox);
            this.Controls.Add(this.CaliberMenu_DropDown);
            this.Controls.Add(this.PowderType_Label);
            this.Controls.Add(this.BulletType_Label);
            this.Controls.Add(this.Caliber_Label);
            this.Controls.Add(this.PowderType_TextBox);
            this.Controls.Add(this.BulletType_TextBox);
            this.Controls.Add(this.DataOutput_TextBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Welcome_TextBox);
            this.Controls.Add(this.MainPage);
            this.Name = "UserInterface";
            this.Text = "Reload Assist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainPage;
        private System.Windows.Forms.TextBox Welcome_TextBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.RichTextBox DataOutput_TextBox;
        private System.Windows.Forms.TextBox BulletType_TextBox;
        private System.Windows.Forms.TextBox PowderType_TextBox;
        private System.Windows.Forms.Label Caliber_Label;
        private System.Windows.Forms.Label BulletType_Label;
        private System.Windows.Forms.Label PowderType_Label;
        private System.Windows.Forms.ComboBox CaliberMenu_DropDown;
        private System.Windows.Forms.RichTextBox CaliberInfo_TextBox;
        private System.Windows.Forms.Label CaliberInfo_Label;
        private System.Windows.Forms.TextBox ErrorText_Label;
        private System.Windows.Forms.Label GunType_Label;
        private System.Windows.Forms.ComboBox GunType_DropDown;
    }
}

