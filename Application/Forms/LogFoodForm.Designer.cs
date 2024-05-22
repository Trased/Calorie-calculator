using System;
namespace IpProiect
{
    partial class LogFoodForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.foodSearchBox = new System.Windows.Forms.TextBox();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentDateDisplayLabel = new System.Windows.Forms.Label();
            this.calorieIntakeDisplayLabel = new System.Windows.Forms.Label();
            this.calorieIntakeLabel = new System.Windows.Forms.Label();
            this.searchOutputBox = new System.Windows.Forms.ListBox();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.progMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(497, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 41);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(497, 159);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(120, 41);
            this.proceedButton.TabIndex = 1;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInput.Location = new System.Drawing.Point(87, 159);
            this.dateTimeInput.MaxDate = DateTime.Today;
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(394, 35);
            this.dateTimeInput.TabIndex = 2;
            this.dateTimeInput.Value = DateTime.Today;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log date";
            // 
            // foodSearchBox
            // 
            this.foodSearchBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodSearchBox.Location = new System.Drawing.Point(87, 83);
            this.foodSearchBox.Name = "foodSearchBox";
            this.foodSearchBox.Size = new System.Drawing.Size(394, 35);
            this.foodSearchBox.TabIndex = 4;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(12, 32);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(139, 27);
            this.currentDateLabel.TabIndex = 6;
            this.currentDateLabel.Text = "Current date:";
            // 
            // currentDateDisplayLabel
            // 
            this.currentDateDisplayLabel.AutoSize = true;
            this.currentDateDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateDisplayLabel.Location = new System.Drawing.Point(150, 32);
            this.currentDateDisplayLabel.Name = "currentDateDisplayLabel";
            this.currentDateDisplayLabel.Size = new System.Drawing.Size(0, 27);
            this.currentDateDisplayLabel.TabIndex = 7;
            // 
            // calorieIntakeDisplayLabel
            // 
            this.calorieIntakeDisplayLabel.AutoSize = true;
            this.calorieIntakeDisplayLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieIntakeDisplayLabel.Location = new System.Drawing.Point(703, 32);
            this.calorieIntakeDisplayLabel.Name = "calorieIntakeDisplayLabel";
            this.calorieIntakeDisplayLabel.Size = new System.Drawing.Size(0, 27);
            this.calorieIntakeDisplayLabel.TabIndex = 9;
            // 
            // calorieIntakeLabel
            // 
            this.calorieIntakeLabel.AutoSize = true;
            this.calorieIntakeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieIntakeLabel.Location = new System.Drawing.Point(392, 32);
            this.calorieIntakeLabel.Name = "calorieIntakeLabel";
            this.calorieIntakeLabel.Size = new System.Drawing.Size(298, 27);
            this.calorieIntakeLabel.TabIndex = 8;
            this.calorieIntakeLabel.Text = "Recommended calorie intake:";
            // 
            // searchOutputBox
            // 
            this.searchOutputBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOutputBox.FormattingEnabled = true;
            this.searchOutputBox.ItemHeight = 21;
            this.searchOutputBox.Location = new System.Drawing.Point(17, 230);
            this.searchOutputBox.Name = "searchOutputBox";
            this.searchOutputBox.Size = new System.Drawing.Size(771, 151);
            this.searchOutputBox.TabIndex = 10;
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.backToMainMenuButton.Location = new System.Drawing.Point(623, 412);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(165, 26);
            this.backToMainMenuButton.TabIndex = 11;
            this.backToMainMenuButton.Text = "Back to main menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
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
            this.progMenu.TabIndex = 12;
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
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // LogFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progMenu);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.searchOutputBox);
            this.Controls.Add(this.calorieIntakeDisplayLabel);
            this.Controls.Add(this.calorieIntakeLabel);
            this.Controls.Add(this.currentDateDisplayLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.foodSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.searchButton);
            this.Name = "LogFoodForm";
            this.Text = "Calorie calculator";
            this.progMenu.ResumeLayout(false);
            this.progMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox foodSearchBox;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label currentDateDisplayLabel;
        private System.Windows.Forms.Label calorieIntakeDisplayLabel;
        private System.Windows.Forms.Label calorieIntakeLabel;
        private System.Windows.Forms.ListBox searchOutputBox;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.MenuStrip progMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
    }
}