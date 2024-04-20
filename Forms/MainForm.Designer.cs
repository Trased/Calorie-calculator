namespace IP_PROJECT
{
    partial class MainForm
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
            this.logFoodButton = new System.Windows.Forms.Button();
            this.viewHistoryButton = new System.Windows.Forms.Button();
            this.updateProfileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logFoodButton
            // 
            this.logFoodButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logFoodButton.Location = new System.Drawing.Point(274, 86);
            this.logFoodButton.Name = "logFoodButton";
            this.logFoodButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logFoodButton.Size = new System.Drawing.Size(208, 43);
            this.logFoodButton.TabIndex = 0;
            this.logFoodButton.Text = "Log food";
            this.logFoodButton.UseVisualStyleBackColor = true;
            // 
            // viewHistoryButton
            // 
            this.viewHistoryButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHistoryButton.Location = new System.Drawing.Point(274, 153);
            this.viewHistoryButton.Name = "viewHistoryButton";
            this.viewHistoryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewHistoryButton.Size = new System.Drawing.Size(208, 43);
            this.viewHistoryButton.TabIndex = 1;
            this.viewHistoryButton.Text = "View history";
            this.viewHistoryButton.UseVisualStyleBackColor = true;
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileButton.Location = new System.Drawing.Point(274, 217);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateProfileButton.Size = new System.Drawing.Size(208, 43);
            this.updateProfileButton.TabIndex = 2;
            this.updateProfileButton.Text = "Update profile";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(274, 282);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOutButton.Size = new System.Drawing.Size(208, 43);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.viewHistoryButton);
            this.Controls.Add(this.logFoodButton);
            this.Name = "MainForm";
            this.Text = "Calorie calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logFoodButton;
        private System.Windows.Forms.Button viewHistoryButton;
        private System.Windows.Forms.Button updateProfileButton;
        private System.Windows.Forms.Button logOutButton;
    }
}

