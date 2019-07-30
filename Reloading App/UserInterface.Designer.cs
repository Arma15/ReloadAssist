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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BulletWeight = new System.Windows.Forms.TextBox();
            this.PowderType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaliberMenu = new System.Windows.Forms.ComboBox();
            this.CaliberInfoBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GunType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1014, 633);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to Reloading Assistant!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(462, 201);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(25, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(988, 363);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Reloading Data Displayed here";
            // 
            // BulletWeight
            // 
            this.BulletWeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BulletWeight.Location = new System.Drawing.Point(239, 203);
            this.BulletWeight.Name = "BulletWeight";
            this.BulletWeight.Size = new System.Drawing.Size(100, 20);
            this.BulletWeight.TabIndex = 5;
            this.BulletWeight.Text = "All";
            this.BulletWeight.TextChanged += new System.EventHandler(this.BulletWeight_TextChanged);
            // 
            // PowderType
            // 
            this.PowderType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PowderType.Location = new System.Drawing.Point(345, 203);
            this.PowderType.Name = "PowderType";
            this.PowderType.Size = new System.Drawing.Size(100, 20);
            this.PowderType.TabIndex = 6;
            this.PowderType.Text = "All";
            this.PowderType.TextChanged += new System.EventHandler(this.PowderType_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caliber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bullet Weight";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Powder Type";
            // 
            // CaliberMenu
            // 
            this.CaliberMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaliberMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaliberMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CaliberMenu.FormattingEnabled = true;
            this.CaliberMenu.Items.AddRange(new object[] {
            ".223/5.56",
            "7.62x39",
            ".308/7.62x51",
            "6.5 Creedmor"});
            this.CaliberMenu.Location = new System.Drawing.Point(111, 201);
            this.CaliberMenu.Name = "CaliberMenu";
            this.CaliberMenu.Size = new System.Drawing.Size(122, 21);
            this.CaliberMenu.TabIndex = 12;
            this.CaliberMenu.Tag = "CaliberList";
            this.CaliberMenu.Text = "Select";
            this.CaliberMenu.SelectedIndexChanged += new System.EventHandler(this.Caliber_IndexChanged);
            // 
            // CaliberInfoBox
            // 
            this.CaliberInfoBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaliberInfoBox.Location = new System.Drawing.Point(543, 128);
            this.CaliberInfoBox.Name = "CaliberInfoBox";
            this.CaliberInfoBox.ReadOnly = true;
            this.CaliberInfoBox.Size = new System.Drawing.Size(470, 132);
            this.CaliberInfoBox.TabIndex = 13;
            this.CaliberInfoBox.Text = "Specific Caliber Info will be displayed here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Caliber Info";
            // 
            // ErrorText
            // 
            this.ErrorText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ErrorText.BackColor = System.Drawing.Color.IndianRed;
            this.ErrorText.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.Location = new System.Drawing.Point(147, 128);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(5);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.ReadOnly = true;
            this.ErrorText.Size = new System.Drawing.Size(200, 20);
            this.ErrorText.TabIndex = 15;
            this.ErrorText.Text = "Errors displayed here";
            this.ErrorText.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gun Type";
            // 
            // GunType
            // 
            this.GunType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GunType.FormattingEnabled = true;
            this.GunType.Items.AddRange(new object[] {
            "Rifle",
            "Handgun"});
            this.GunType.Location = new System.Drawing.Point(25, 201);
            this.GunType.Name = "GunType";
            this.GunType.Size = new System.Drawing.Size(80, 21);
            this.GunType.TabIndex = 17;
            this.GunType.Text = "Select";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1038, 657);
            this.Controls.Add(this.GunType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CaliberInfoBox);
            this.Controls.Add(this.CaliberMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PowderType);
            this.Controls.Add(this.BulletWeight);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox BulletWeight;
        private System.Windows.Forms.TextBox PowderType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CaliberMenu;
        private System.Windows.Forms.RichTextBox CaliberInfoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrorText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GunType;
    }
}

