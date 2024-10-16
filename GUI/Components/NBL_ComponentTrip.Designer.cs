namespace GUI.Components
{
	partial class NBL_ComponentTrip
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnl_Trip = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pnl_Click = new Guna.UI2.WinForms.Guna2Panel();
			this.pnl_Info = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_Region = new System.Windows.Forms.Label();
			this.lbl_School = new System.Windows.Forms.Label();
			this.lbl_Bus = new System.Windows.Forms.Label();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.pbx_Status = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.pnl_Trip.SuspendLayout();
			this.pnl_Info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Status)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_Trip
			// 
			this.pnl_Trip.BorderRadius = 30;
			this.pnl_Trip.Controls.Add(this.pnl_Click);
			this.pnl_Trip.Controls.Add(this.pnl_Info);
			this.pnl_Trip.Controls.Add(this.pbx_Status);
			this.pnl_Trip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Trip.FillColor = System.Drawing.Color.LightBlue;
			this.pnl_Trip.FillColor2 = System.Drawing.Color.LightCyan;
			this.pnl_Trip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.pnl_Trip.Location = new System.Drawing.Point(0, 0);
			this.pnl_Trip.Name = "pnl_Trip";
			this.pnl_Trip.Size = new System.Drawing.Size(300, 100);
			this.pnl_Trip.TabIndex = 0;
			// 
			// pnl_Click
			// 
			this.pnl_Click.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Click.Location = new System.Drawing.Point(0, 0);
			this.pnl_Click.Name = "pnl_Click";
			this.pnl_Click.Size = new System.Drawing.Size(300, 100);
			this.pnl_Click.TabIndex = 2;
			this.pnl_Click.UseTransparentBackground = true;
			// 
			// pnl_Info
			// 
			this.pnl_Info.Controls.Add(this.lbl_Region);
			this.pnl_Info.Controls.Add(this.lbl_School);
			this.pnl_Info.Controls.Add(this.lbl_Bus);
			this.pnl_Info.Controls.Add(this.lbl_Date);
			this.pnl_Info.Location = new System.Drawing.Point(98, 10);
			this.pnl_Info.Name = "pnl_Info";
			this.pnl_Info.Size = new System.Drawing.Size(187, 82);
			this.pnl_Info.TabIndex = 1;
			// 
			// lbl_Region
			// 
			this.lbl_Region.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbl_Region.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Region.Location = new System.Drawing.Point(0, 40);
			this.lbl_Region.Name = "lbl_Region";
			this.lbl_Region.Size = new System.Drawing.Size(187, 22);
			this.lbl_Region.TabIndex = 3;
			this.lbl_Region.Text = "REGION";
			this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_School
			// 
			this.lbl_School.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbl_School.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_School.Location = new System.Drawing.Point(0, 62);
			this.lbl_School.Name = "lbl_School";
			this.lbl_School.Size = new System.Drawing.Size(187, 20);
			this.lbl_School.TabIndex = 2;
			this.lbl_School.Text = "SCHOOL";
			this.lbl_School.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Bus
			// 
			this.lbl_Bus.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Bus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Bus.Location = new System.Drawing.Point(0, 20);
			this.lbl_Bus.Name = "lbl_Bus";
			this.lbl_Bus.Size = new System.Drawing.Size(187, 20);
			this.lbl_Bus.TabIndex = 1;
			this.lbl_Bus.Text = "BUS";
			this.lbl_Bus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Date
			// 
			this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Date.Location = new System.Drawing.Point(0, 0);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(187, 20);
			this.lbl_Date.TabIndex = 0;
			this.lbl_Date.Text = "DATE";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbx_Status
			// 
			this.pbx_Status.Image = global::GUI.Properties.Resources.bus_planned_icon;
			this.pbx_Status.ImageRotate = 0F;
			this.pbx_Status.Location = new System.Drawing.Point(10, 10);
			this.pbx_Status.Name = "pbx_Status";
			this.pbx_Status.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.pbx_Status.Size = new System.Drawing.Size(82, 82);
			this.pbx_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_Status.TabIndex = 0;
			this.pbx_Status.TabStop = false;
			// 
			// NBL_ComponentTrip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pnl_Trip);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NBL_ComponentTrip";
			this.Size = new System.Drawing.Size(300, 100);
			this.pnl_Trip.ResumeLayout(false);
			this.pnl_Info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbx_Status)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel pnl_Trip;
		private Guna.UI2.WinForms.Guna2CirclePictureBox pbx_Status;
		private Guna.UI2.WinForms.Guna2Panel pnl_Info;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_Region;
		private System.Windows.Forms.Label lbl_School;
		private System.Windows.Forms.Label lbl_Bus;
		private Guna.UI2.WinForms.Guna2Panel pnl_Click;
	}
}
