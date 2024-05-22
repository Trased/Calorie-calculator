namespace IpProiect
{
    partial class ViewHistoryForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calorieHistoryButton = new System.Windows.Forms.Button();
            this.weightHistoryButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.progMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // calorieHistoryButton
            // 
            this.calorieHistoryButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieHistoryButton.Location = new System.Drawing.Point(37, 24);
            this.calorieHistoryButton.Name = "calorieHistoryButton";
            this.calorieHistoryButton.Size = new System.Drawing.Size(169, 34);
            this.calorieHistoryButton.TabIndex = 0;
            this.calorieHistoryButton.Text = "Calorie history";
            this.calorieHistoryButton.UseVisualStyleBackColor = true;
            this.calorieHistoryButton.Click += new System.EventHandler(this.calorieHistoryButton_Click);
            // 
            // weightHistoryButton
            // 
            this.weightHistoryButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightHistoryButton.Location = new System.Drawing.Point(587, 24);
            this.weightHistoryButton.Name = "weightHistoryButton";
            this.weightHistoryButton.Size = new System.Drawing.Size(169, 34);
            this.weightHistoryButton.TabIndex = 1;
            this.weightHistoryButton.Text = "Weight history";
            this.weightHistoryButton.UseVisualStyleBackColor = true;
            this.weightHistoryButton.Click += new System.EventHandler(this.weightHistoryButton_Click);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.backToMainMenuButton.Location = new System.Drawing.Point(612, 412);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(165, 26);
            this.backToMainMenuButton.TabIndex = 2;
            this.backToMainMenuButton.Text = "Back to main menu";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // progressChart
            // 
            chartArea1.Name = "ChartArea1";
            this.progressChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.progressChart.Legends.Add(legend1);
            this.progressChart.Location = new System.Drawing.Point(37, 77);
            this.progressChart.Name = "progressChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.progressChart.Series.Add(series1);
            this.progressChart.Size = new System.Drawing.Size(719, 300);
            this.progressChart.TabIndex = 3;
            this.progressChart.Text = "chart1";
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
            this.progMenu.TabIndex = 13;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
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
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progMenu);
            this.Controls.Add(this.progressChart);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.weightHistoryButton);
            this.Controls.Add(this.calorieHistoryButton);
            this.Name = "ViewHistoryForm";
            this.Text = "Calorie calculator";
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.progMenu.ResumeLayout(false);
            this.progMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calorieHistoryButton;
        private System.Windows.Forms.Button weightHistoryButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
        private System.Windows.Forms.MenuStrip progMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
    }
}