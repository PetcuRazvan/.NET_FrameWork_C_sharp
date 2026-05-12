namespace Seminar8
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCompanii = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pretInchidereTabPage = new System.Windows.Forms.TabPage();
            this.pretInchiderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.volumTabPage = new System.Windows.Forms.TabPage();
            this.volumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evolutieTabPage = new System.Windows.Forms.TabPage();
            this.evolutieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pretInchidereTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pretInchiderChart)).BeginInit();
            this.volumTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumChart)).BeginInit();
            this.evolutieTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evolutieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbCompanii, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbCompanii
            // 
            this.cbCompanii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCompanii.FormattingEnabled = true;
            this.cbCompanii.Location = new System.Drawing.Point(3, 3);
            this.cbCompanii.Name = "cbCompanii";
            this.cbCompanii.Size = new System.Drawing.Size(918, 28);
            this.cbCompanii.TabIndex = 0;
            this.cbCompanii.SelectedIndexChanged += new System.EventHandler(this.cbCompanii_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pretInchidereTabPage);
            this.tabControl1.Controls.Add(this.volumTabPage);
            this.tabControl1.Controls.Add(this.evolutieTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 440);
            this.tabControl1.TabIndex = 1;
            // 
            // pretInchidereTabPage
            // 
            this.pretInchidereTabPage.Controls.Add(this.pretInchiderChart);
            this.pretInchidereTabPage.Location = new System.Drawing.Point(4, 29);
            this.pretInchidereTabPage.Name = "pretInchidereTabPage";
            this.pretInchidereTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pretInchidereTabPage.Size = new System.Drawing.Size(910, 407);
            this.pretInchidereTabPage.TabIndex = 0;
            this.pretInchidereTabPage.Text = "Pret inchidere";
            this.pretInchidereTabPage.UseVisualStyleBackColor = true;
            // 
            // pretInchiderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pretInchiderChart.ChartAreas.Add(chartArea1);
            this.pretInchiderChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.pretInchiderChart.Legends.Add(legend1);
            this.pretInchiderChart.Location = new System.Drawing.Point(3, 3);
            this.pretInchiderChart.Name = "pretInchiderChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pretInchiderChart.Series.Add(series1);
            this.pretInchiderChart.Size = new System.Drawing.Size(904, 401);
            this.pretInchiderChart.TabIndex = 0;
            this.pretInchiderChart.Text = "chart1";
            // 
            // volumTabPage
            // 
            this.volumTabPage.Controls.Add(this.volumChart);
            this.volumTabPage.Location = new System.Drawing.Point(4, 29);
            this.volumTabPage.Name = "volumTabPage";
            this.volumTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.volumTabPage.Size = new System.Drawing.Size(910, 407);
            this.volumTabPage.TabIndex = 1;
            this.volumTabPage.Text = "Volum tranzactionat";
            this.volumTabPage.UseVisualStyleBackColor = true;
            // 
            // volumChart
            // 
            chartArea2.Name = "ChartArea1";
            this.volumChart.ChartAreas.Add(chartArea2);
            this.volumChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.volumChart.Legends.Add(legend2);
            this.volumChart.Location = new System.Drawing.Point(3, 3);
            this.volumChart.Name = "volumChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.volumChart.Series.Add(series2);
            this.volumChart.Size = new System.Drawing.Size(904, 401);
            this.volumChart.TabIndex = 0;
            this.volumChart.Text = "chart1";
            // 
            // evolutieTabPage
            // 
            this.evolutieTabPage.Controls.Add(this.evolutieChart);
            this.evolutieTabPage.Location = new System.Drawing.Point(4, 29);
            this.evolutieTabPage.Name = "evolutieTabPage";
            this.evolutieTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.evolutieTabPage.Size = new System.Drawing.Size(910, 407);
            this.evolutieTabPage.TabIndex = 2;
            this.evolutieTabPage.Text = "Evolutie";
            this.evolutieTabPage.UseVisualStyleBackColor = true;
            // 
            // evolutieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.evolutieChart.ChartAreas.Add(chartArea3);
            this.evolutieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.evolutieChart.Legends.Add(legend3);
            this.evolutieChart.Location = new System.Drawing.Point(3, 3);
            this.evolutieChart.Name = "evolutieChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.evolutieChart.Series.Add(series3);
            this.evolutieChart.Size = new System.Drawing.Size(904, 401);
            this.evolutieChart.TabIndex = 0;
            this.evolutieChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pretInchidereTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pretInchiderChart)).EndInit();
            this.volumTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumChart)).EndInit();
            this.evolutieTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evolutieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbCompanii;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pretInchidereTabPage;
        private System.Windows.Forms.TabPage volumTabPage;
        private System.Windows.Forms.TabPage evolutieTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart pretInchiderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart volumChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart evolutieChart;
    }
}

