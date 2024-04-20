namespace IP_PROJECT
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // 
            // weightHistoryButton
            // 
            this.weightHistoryButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightHistoryButton.Location = new System.Drawing.Point(535, 24);
            this.weightHistoryButton.Name = "weightHistoryButton";
            this.weightHistoryButton.Size = new System.Drawing.Size(169, 34);
            this.weightHistoryButton.TabIndex = 1;
            this.weightHistoryButton.Text = "Weight history";
            this.weightHistoryButton.UseVisualStyleBackColor = true;
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
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 77);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(719, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.weightHistoryButton);
            this.Controls.Add(this.calorieHistoryButton);
            this.Name = "ViewHistoryForm";
            this.Text = "Calorie calculator";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calorieHistoryButton;
        private System.Windows.Forms.Button weightHistoryButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}