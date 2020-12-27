
namespace AnalysisCosts
{
    partial class DynamicCostsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicCostsForm));
            this.DynamicCostsChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DynamicCostsChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicCostsChart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicCostsChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // DynamicCostsChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.DynamicCostsChart1.ChartAreas.Add(chartArea1);
            this.DynamicCostsChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.DynamicCostsChart1.Legends.Add(legend1);
            this.DynamicCostsChart1.Location = new System.Drawing.Point(3, 3);
            this.DynamicCostsChart1.Name = "DynamicCostsChart1";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Базисный период";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Отчетный период";
            this.DynamicCostsChart1.Series.Add(series1);
            this.DynamicCostsChart1.Series.Add(series2);
            this.DynamicCostsChart1.Size = new System.Drawing.Size(629, 453);
            this.DynamicCostsChart1.TabIndex = 0;
            this.DynamicCostsChart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Динамика затрат";
            this.DynamicCostsChart1.Titles.Add(title1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DynamicCostsChart2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DynamicCostsChart1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 459);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DynamicCostsChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.DynamicCostsChart2.ChartAreas.Add(chartArea2);
            this.DynamicCostsChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.DynamicCostsChart2.Legends.Add(legend2);
            this.DynamicCostsChart2.Location = new System.Drawing.Point(638, 3);
            this.DynamicCostsChart2.Name = "DynamicCostsChart2";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.LightSeaGreen;
            series3.Legend = "Legend1";
            series3.Name = "Удельный вес в БП";
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Gold;
            series4.Legend = "Legend1";
            series4.Name = "Удельный вес в ОП";
            this.DynamicCostsChart2.Series.Add(series3);
            this.DynamicCostsChart2.Series.Add(series4);
            this.DynamicCostsChart2.Size = new System.Drawing.Size(630, 453);
            this.DynamicCostsChart2.TabIndex = 1;
            this.DynamicCostsChart2.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Удельная динамика затрат";
            this.DynamicCostsChart2.Titles.Add(title2);
            // 
            // DynamicCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicCostsForm";
            this.Text = "Динамика затрат";
            this.Load += new System.EventHandler(this.DynamicCostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DynamicCostsChart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DynamicCostsChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DynamicCostsChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart DynamicCostsChart2;
    }
}