namespace GUI.UI
{
    partial class frm_Statistical
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_School = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_TotalRevenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QuantityDriver = new System.Windows.Forms.Label();
            this.txt_QuantityBus = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_QuantityTrip = new System.Windows.Forms.Label();
            this.cbx_Year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart_Region = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Control = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_School)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Region)).BeginInit();
            this.pnl_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Revenue
            // 
            this.chart_Revenue.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend1);
            this.chart_Revenue.Location = new System.Drawing.Point(12, 264);
            this.chart_Revenue.Name = "chart_Revenue";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Revenue.Series.Add(series1);
            this.chart_Revenue.Size = new System.Drawing.Size(1027, 266);
            this.chart_Revenue.TabIndex = 11;
            this.chart_Revenue.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Doanh thu";
            this.chart_Revenue.Titles.Add(title1);
            // 
            // chart_School
            // 
            this.chart_School.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart_School.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_School.Legends.Add(legend2);
            this.chart_School.Location = new System.Drawing.Point(12, 536);
            this.chart_School.Name = "chart_School";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_School.Series.Add(series2);
            this.chart_School.Size = new System.Drawing.Size(1027, 253);
            this.chart_School.TabIndex = 12;
            this.chart_School.Text = "chart_School";
            title2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Thống kê theo trường học";
            this.chart_School.Titles.Add(title2);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1345, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.txt_TotalRevenue);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 133);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(150, 115);
            this.guna2Panel1.TabIndex = 14;
            // 
            // txt_TotalRevenue
            // 
            this.txt_TotalRevenue.AutoSize = true;
            this.txt_TotalRevenue.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalRevenue.Location = new System.Drawing.Point(16, 65);
            this.txt_TotalRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_TotalRevenue.Name = "txt_TotalRevenue";
            this.txt_TotalRevenue.Size = new System.Drawing.Size(34, 25);
            this.txt_TotalRevenue.TabIndex = 1;
            this.txt_TotalRevenue.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txt_QuantityDriver);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(474, 133);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(150, 115);
            this.guna2Panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng Tài xế";
            // 
            // txt_QuantityDriver
            // 
            this.txt_QuantityDriver.AutoSize = true;
            this.txt_QuantityDriver.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityDriver.Location = new System.Drawing.Point(46, 57);
            this.txt_QuantityDriver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_QuantityDriver.Name = "txt_QuantityDriver";
            this.txt_QuantityDriver.Size = new System.Drawing.Size(53, 40);
            this.txt_QuantityDriver.TabIndex = 1;
            this.txt_QuantityDriver.Text = "10";
            // 
            // txt_QuantityBus
            // 
            this.txt_QuantityBus.AutoSize = true;
            this.txt_QuantityBus.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityBus.Location = new System.Drawing.Point(51, 57);
            this.txt_QuantityBus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_QuantityBus.Name = "txt_QuantityBus";
            this.txt_QuantityBus.Size = new System.Drawing.Size(53, 40);
            this.txt_QuantityBus.TabIndex = 1;
            this.txt_QuantityBus.Text = "10";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.txt_QuantityBus);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Location = new System.Drawing.Point(320, 133);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(150, 115);
            this.guna2Panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Lượng Xe";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.Controls.Add(this.txt_QuantityTrip);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.Location = new System.Drawing.Point(166, 133);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel4.Size = new System.Drawing.Size(150, 115);
            this.guna2Panel4.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Chuyến đi";
            // 
            // txt_QuantityTrip
            // 
            this.txt_QuantityTrip.AutoSize = true;
            this.txt_QuantityTrip.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityTrip.Location = new System.Drawing.Point(52, 57);
            this.txt_QuantityTrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_QuantityTrip.Name = "txt_QuantityTrip";
            this.txt_QuantityTrip.Size = new System.Drawing.Size(53, 40);
            this.txt_QuantityTrip.TabIndex = 1;
            this.txt_QuantityTrip.Text = "10";
            // 
            // cbx_Year
            // 
            this.cbx_Year.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Year.ForeColor = System.Drawing.Color.Black;
            this.cbx_Year.ItemHeight = 30;
            this.cbx_Year.Location = new System.Drawing.Point(628, 169);
            this.cbx_Year.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Year.Name = "cbx_Year";
            this.cbx_Year.Size = new System.Drawing.Size(411, 36);
            this.cbx_Year.TabIndex = 18;
            // 
            // chart_Region
            // 
            this.chart_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_Region.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chart_Region.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chart_Region.Legends.Add(legend3);
            this.chart_Region.Location = new System.Drawing.Point(1044, 133);
            this.chart_Region.Margin = new System.Windows.Forms.Padding(2);
            this.chart_Region.Name = "chart_Region";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_Region.Series.Add(series3);
            this.chart_Region.Size = new System.Drawing.Size(345, 656);
            this.chart_Region.TabIndex = 20;
            this.chart_Region.Text = "chart1";
            title3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Theo Vùng";
            this.chart_Region.Titles.Add(title3);
            // 
            // pnl_Control
            // 
            this.pnl_Control.BorderColor = System.Drawing.Color.Black;
            this.pnl_Control.BorderRadius = 60;
            this.pnl_Control.BorderThickness = 1;
            this.pnl_Control.Controls.Add(this.lbl_Title);
            this.pnl_Control.CustomizableEdges.BottomLeft = false;
            this.pnl_Control.CustomizableEdges.TopLeft = false;
            this.pnl_Control.CustomizableEdges.TopRight = false;
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1400, 117);
            this.pnl_Control.TabIndex = 21;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(583, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(234, 88);
            this.lbl_Title.TabIndex = 15;
            this.lbl_Title.Text = "Thống Kê";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(629, 131);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(122, 36);
            this.lbl_Date.TabIndex = 22;
            this.lbl_Date.Text = "Năm";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Statistical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.chart_Revenue);
            this.Controls.Add(this.chart_Region);
            this.Controls.Add(this.cbx_Year);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.chart_School);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Statistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Statistical";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_School)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Region)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_School;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label txt_TotalRevenue;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label txt_QuantityBus;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label txt_QuantityDriver;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_QuantityTrip;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Year;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Region;
		private Guna.UI2.WinForms.Guna2Panel pnl_Control;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lbl_Date;
	}
}