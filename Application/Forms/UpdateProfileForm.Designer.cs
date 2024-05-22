namespace IpProiect
{
    partial class UpdateProfileForm
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
            this.currentHeightBox = new System.Windows.Forms.NumericUpDown();
            this.currentWeightBox = new System.Windows.Forms.NumericUpDown();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.currentHeightLabel = new System.Windows.Forms.Label();
            this.currentWeightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.newPassword1Box = new System.Windows.Forms.TextBox();
            this.newPassword1Label = new System.Windows.Forms.Label();
            this.newPassword0Box = new System.Windows.Forms.TextBox();
            this.newPassword0Label = new System.Windows.Forms.Label();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.updateProfileButton = new System.Windows.Forms.Button();
            this.progMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.currentHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.progMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentHeightBox
            // 
            this.currentHeightBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHeightBox.Location = new System.Drawing.Point(68, 261);
            this.currentHeightBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.currentHeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentHeightBox.Name = "currentHeightBox";
            this.currentHeightBox.Size = new System.Drawing.Size(155, 35);
            this.currentHeightBox.TabIndex = 29;
            this.currentHeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currentWeightBox
            // 
            this.currentWeightBox.DecimalPlaces = 1;
            this.currentWeightBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.currentWeightBox.Location = new System.Drawing.Point(68, 191);
            this.currentWeightBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.currentWeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentWeightBox.Name = "currentWeightBox";
            this.currentWeightBox.Size = new System.Drawing.Size(155, 35);
            this.currentWeightBox.TabIndex = 28;
            this.currentWeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(68, 94);
            this.ageBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(155, 35);
            this.ageBox.TabIndex = 27;
            this.ageBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(474, 94);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(155, 35);
            this.passwordBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(473, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 27);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Old password";
            // 
            // currentHeightLabel
            // 
            this.currentHeightLabel.AutoSize = true;
            this.currentHeightLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHeightLabel.Location = new System.Drawing.Point(63, 233);
            this.currentHeightLabel.Name = "currentHeightLabel";
            this.currentHeightLabel.Size = new System.Drawing.Size(207, 27);
            this.currentHeightLabel.TabIndex = 24;
            this.currentHeightLabel.Text = "Current Height (cm)";
            // 
            // currentWeightLabel
            // 
            this.currentWeightLabel.AutoSize = true;
            this.currentWeightLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeightLabel.Location = new System.Drawing.Point(63, 161);
            this.currentWeightLabel.Name = "currentWeightLabel";
            this.currentWeightLabel.Size = new System.Drawing.Size(205, 27);
            this.currentWeightLabel.TabIndex = 23;
            this.currentWeightLabel.Text = "Current Weight (kg)";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(63, 66);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(51, 27);
            this.ageLabel.TabIndex = 22;
            this.ageLabel.Text = "Age";
            // 
            // newPassword1Box
            // 
            this.newPassword1Box.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword1Box.Location = new System.Drawing.Point(474, 261);
            this.newPassword1Box.Name = "newPassword1Box";
            this.newPassword1Box.PasswordChar = '*';
            this.newPassword1Box.Size = new System.Drawing.Size(155, 35);
            this.newPassword1Box.TabIndex = 31;
            // 
            // newPassword1Label
            // 
            this.newPassword1Label.AutoSize = true;
            this.newPassword1Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword1Label.Location = new System.Drawing.Point(473, 235);
            this.newPassword1Label.Name = "newPassword1Label";
            this.newPassword1Label.Size = new System.Drawing.Size(153, 27);
            this.newPassword1Label.TabIndex = 30;
            this.newPassword1Label.Text = "New password";
            // 
            // newPassword0Box
            // 
            this.newPassword0Box.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword0Box.Location = new System.Drawing.Point(474, 180);
            this.newPassword0Box.Name = "newPassword0Box";
            this.newPassword0Box.PasswordChar = '*';
            this.newPassword0Box.Size = new System.Drawing.Size(155, 35);
            this.newPassword0Box.TabIndex = 33;
            // 
            // newPassword0Label
            // 
            this.newPassword0Label.AutoSize = true;
            this.newPassword0Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword0Label.Location = new System.Drawing.Point(473, 154);
            this.newPassword0Label.Name = "newPassword0Label";
            this.newPassword0Label.Size = new System.Drawing.Size(153, 27);
            this.newPassword0Label.TabIndex = 32;
            this.newPassword0Label.Text = "New password";
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenuButton.Location = new System.Drawing.Point(68, 366);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(235, 36);
            this.backToMainMenuButton.TabIndex = 34;
            this.backToMainMenuButton.Text = "Back to main menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileButton.Location = new System.Drawing.Point(474, 366);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(201, 36);
            this.updateProfileButton.TabIndex = 35;
            this.updateProfileButton.Text = "Update profile";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.updateProfileButton_Click);
            // 
            // progMenu
            // 
            this.progMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.progMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.progMenu.Location = new System.Drawing.Point(0, 0);
            this.progMenu.Name = "progMenu";
            this.progMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.progMenu.Size = new System.Drawing.Size(800, 24);
            this.progMenu.TabIndex = 37;
            this.progMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progMenu);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.newPassword0Box);
            this.Controls.Add(this.newPassword0Label);
            this.Controls.Add(this.newPassword1Box);
            this.Controls.Add(this.newPassword1Label);
            this.Controls.Add(this.currentHeightBox);
            this.Controls.Add(this.currentWeightBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.currentHeightLabel);
            this.Controls.Add(this.currentWeightLabel);
            this.Controls.Add(this.ageLabel);
            this.Name = "UpdateProfileForm";
            this.Text = "Calorie calculator";
            ((System.ComponentModel.ISupportInitialize)(this.currentHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.progMenu.ResumeLayout(false);
            this.progMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown currentHeightBox;
        private System.Windows.Forms.NumericUpDown currentWeightBox;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label currentHeightLabel;
        private System.Windows.Forms.Label currentWeightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox newPassword1Box;
        private System.Windows.Forms.Label newPassword1Label;
        private System.Windows.Forms.TextBox newPassword0Box;
        private System.Windows.Forms.Label newPassword0Label;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.Button updateProfileButton;
        private System.Windows.Forms.MenuStrip progMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
    }
}