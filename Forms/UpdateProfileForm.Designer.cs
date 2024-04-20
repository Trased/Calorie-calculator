namespace IP_PROJECT
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(474, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(155, 35);
            this.textBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "New password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(474, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 35);
            this.textBox2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "New password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(474, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 36);
            this.button2.TabIndex = 35;
            this.button2.Text = "Update profile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(155, 320);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 27);
            this.errorLabel.TabIndex = 36;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorLabel.UseMnemonic = false;
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentHeightBox);
            this.Controls.Add(this.currentWeightBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.currentHeightLabel);
            this.Controls.Add(this.currentWeightLabel);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProfileForm";
            this.Text = "Calorie calculator";
            ((System.ComponentModel.ISupportInitialize)(this.currentHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorLabel;
    }
}