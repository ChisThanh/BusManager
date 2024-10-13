namespace GUI.Components
{
	partial class NBL_ComponentRibbon
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
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pbx_Star = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Star)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BorderRadius = 20;
			this.guna2GradientPanel1.Controls.Add(this.pbx_Star);
			this.guna2GradientPanel1.CustomizableEdges.BottomLeft = false;
			this.guna2GradientPanel1.CustomizableEdges.TopLeft = false;
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.Violet;
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Orchid;
			this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(60, 100);
			this.guna2GradientPanel1.TabIndex = 0;
			// 
			// pbx_Star
			// 
			this.pbx_Star.Image = global::GUI.Properties.Resources.colored_star_icon;
			this.pbx_Star.ImageRotate = 0F;
			this.pbx_Star.Location = new System.Drawing.Point(5, 25);
			this.pbx_Star.Name = "pbx_Star";
			this.pbx_Star.Size = new System.Drawing.Size(50, 50);
			this.pbx_Star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbx_Star.TabIndex = 4;
			this.pbx_Star.TabStop = false;
			// 
			// NBL_ComponentRibbon
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.guna2GradientPanel1);
			this.Name = "NBL_ComponentRibbon";
			this.Size = new System.Drawing.Size(60, 100);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Star)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private Guna.UI2.WinForms.Guna2PictureBox pbx_Star;
	}
}
