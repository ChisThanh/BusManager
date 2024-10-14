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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.chart_Region = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_School)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Region)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thông kê";
            // 
            // chart_Revenue
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart_Revenue.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart_Revenue.Legends.Add(legend4);
            this.chart_Revenue.Location = new System.Drawing.Point(16, 205);
            this.chart_Revenue.Margin = new System.Windows.Forms.Padding(4);
            this.chart_Revenue.Name = "chart_Revenue";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_Revenue.Series.Add(series4);
            this.chart_Revenue.Size = new System.Drawing.Size(1005, 328);
            this.chart_Revenue.TabIndex = 11;
            this.chart_Revenue.Text = "chart1";
            title4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Doanh thu";
            this.chart_Revenue.Titles.Add(title4);
            // 
            // chart_School
            // 
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart_School.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart_School.Legends.Add(legend5);
            this.chart_School.Location = new System.Drawing.Point(16, 534);
            this.chart_School.Margin = new System.Windows.Forms.Padding(4);
            this.chart_School.Name = "chart_School";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_School.Series.Add(series5);
            this.chart_School.Size = new System.Drawing.Size(1005, 311);
            this.chart_School.TabIndex = 12;
            this.chart_School.Text = "chart_School";
            title5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.Text = "Thống kê theo trường học";
            this.chart_School.Titles.Add(title5);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1430, 13);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
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
            this.guna2Panel1.Location = new System.Drawing.Point(355, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(200, 141);
            this.guna2Panel1.TabIndex = 14;
            // 
            // txt_TotalRevenue
            // 
            this.txt_TotalRevenue.AutoSize = true;
            this.txt_TotalRevenue.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalRevenue.Location = new System.Drawing.Point(22, 80);
            this.txt_TotalRevenue.Name = "txt_TotalRevenue";
            this.txt_TotalRevenue.Size = new System.Drawing.Size(42, 32);
            this.txt_TotalRevenue.TabIndex = 1;
            this.txt_TotalRevenue.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
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
            this.guna2Panel2.Location = new System.Drawing.Point(1120, 36);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(200, 141);
            this.guna2Panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng Tài xế";
            // 
            // txt_QuantityDriver
            // 
            this.txt_QuantityDriver.AutoSize = true;
            this.txt_QuantityDriver.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityDriver.Location = new System.Drawing.Point(61, 70);
            this.txt_QuantityDriver.Name = "txt_QuantityDriver";
            this.txt_QuantityDriver.Size = new System.Drawing.Size(66, 49);
            this.txt_QuantityDriver.TabIndex = 1;
            this.txt_QuantityDriver.Text = "10";
            // 
            // txt_QuantityBus
            // 
            this.txt_QuantityBus.AutoSize = true;
            this.txt_QuantityBus.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityBus.Location = new System.Drawing.Point(68, 70);
            this.txt_QuantityBus.Name = "txt_QuantityBus";
            this.txt_QuantityBus.Size = new System.Drawing.Size(66, 49);
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
            this.guna2Panel3.Location = new System.Drawing.Point(860, 36);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel3.Size = new System.Drawing.Size(200, 141);
            this.guna2Panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
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
            this.guna2Panel4.Location = new System.Drawing.Point(603, 36);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel4.Size = new System.Drawing.Size(200, 141);
            this.guna2Panel4.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Chuyến đi";
            // 
            // txt_QuantityTrip
            // 
            this.txt_QuantityTrip.AutoSize = true;
            this.txt_QuantityTrip.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuantityTrip.Location = new System.Drawing.Point(70, 70);
            this.txt_QuantityTrip.Name = "txt_QuantityTrip";
            this.txt_QuantityTrip.Size = new System.Drawing.Size(66, 49);
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
            this.cbx_Year.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_Year.ItemHeight = 30;
            this.cbx_Year.Location = new System.Drawing.Point(156, 87);
            this.cbx_Year.Name = "cbx_Year";
            this.cbx_Year.Size = new System.Drawing.Size(140, 36);
            this.cbx_Year.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Năm";
            // 
            // chart_Region
            // 
            this.chart_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart_Region.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.chart_Region.Legends.Add(legend6);
            this.chart_Region.Location = new System.Drawing.Point(1028, 205);
            this.chart_Region.Name = "chart_Region";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_Region.Series.Add(series6);
            this.chart_Region.Size = new System.Drawing.Size(411, 640);
            this.chart_Region.TabIndex = 20;
            this.chart_Region.Text = "chart1";
            title6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "Theo Vùng";
            this.chart_Region.Titles.Add(title6);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frm_Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 905);
            this.Controls.Add(this.chart_Revenue);
            this.Controls.Add(this.chart_Region);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_Year);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.chart_School);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Region;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}