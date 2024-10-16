namespace GUI.UI
{
    partial class TQT_FormRegion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cbb_Region = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txt_Description = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_NameRegion = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Insert = new Guna.UI2.WinForms.Guna2Button();
			this.dgv_Students = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pnl_Control = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_Bus = new System.Windows.Forms.Label();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.guna2GroupBox1.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
			this.pnl_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbb_Region
			// 
			this.cbb_Region.BackColor = System.Drawing.Color.White;
			this.cbb_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_Region.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_Region.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_Region.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbb_Region.ForeColor = System.Drawing.Color.Black;
			this.cbb_Region.ItemHeight = 30;
			this.cbb_Region.Location = new System.Drawing.Point(12, 134);
			this.cbb_Region.Name = "cbb_Region";
			this.cbb_Region.Size = new System.Drawing.Size(548, 36);
			this.cbb_Region.TabIndex = 0;
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.BorderColor = System.Drawing.Color.LightGray;
			this.guna2GroupBox1.Controls.Add(this.lbl_Bus);
			this.guna2GroupBox1.Controls.Add(this.lbl_Date);
			this.guna2GroupBox1.Controls.Add(this.txt_Description);
			this.guna2GroupBox1.Controls.Add(this.txt_NameRegion);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightGray;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox1.Location = new System.Drawing.Point(12, 176);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(548, 222);
			this.guna2GroupBox1.TabIndex = 2;
			this.guna2GroupBox1.Text = "Thông Tin Vùng";
			// 
			// txt_Description
			// 
			this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Description.DefaultText = "";
			this.txt_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Description.ForeColor = System.Drawing.Color.Black;
			this.txt_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Description.Location = new System.Drawing.Point(131, 101);
			this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_Description.Multiline = true;
			this.txt_Description.Name = "txt_Description";
			this.txt_Description.PasswordChar = '\0';
			this.txt_Description.PlaceholderText = "";
			this.txt_Description.SelectedText = "";
			this.txt_Description.Size = new System.Drawing.Size(414, 117);
			this.txt_Description.TabIndex = 3;
			// 
			// txt_NameRegion
			// 
			this.txt_NameRegion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_NameRegion.DefaultText = "";
			this.txt_NameRegion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_NameRegion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_NameRegion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_NameRegion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_NameRegion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_NameRegion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_NameRegion.ForeColor = System.Drawing.Color.Black;
			this.txt_NameRegion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_NameRegion.Location = new System.Drawing.Point(131, 57);
			this.txt_NameRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_NameRegion.Name = "txt_NameRegion";
			this.txt_NameRegion.PasswordChar = '\0';
			this.txt_NameRegion.PlaceholderText = "";
			this.txt_NameRegion.SelectedText = "";
			this.txt_NameRegion.Size = new System.Drawing.Size(414, 36);
			this.txt_NameRegion.TabIndex = 2;
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.BackColor = System.Drawing.Color.Crimson;
			this.guna2GroupBox2.BorderColor = System.Drawing.Color.LightGray;
			this.guna2GroupBox2.Controls.Add(this.btn_Close);
			this.guna2GroupBox2.Controls.Add(this.btn_Insert);
			this.guna2GroupBox2.Controls.Add(this.btn_Delete);
			this.guna2GroupBox2.Controls.Add(this.btn_Update);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightGray;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
			this.guna2GroupBox2.Location = new System.Drawing.Point(12, 404);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(548, 122);
			this.guna2GroupBox2.TabIndex = 3;
			this.guna2GroupBox2.Text = "Chức Năng";
			// 
			// btn_Close
			// 
			this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Close.FillColor = System.Drawing.Color.Silver;
			this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Close.ForeColor = System.Drawing.Color.Black;
			this.btn_Close.Image = global::GUI.Properties.Resources.clear_icon;
			this.btn_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Close.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Close.Location = new System.Drawing.Point(386, 63);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(104, 36);
			this.btn_Close.TabIndex = 3;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btn_Delete
			// 
			this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Delete.FillColor = System.Drawing.Color.Tomato;
			this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Delete.ForeColor = System.Drawing.Color.Black;
			this.btn_Delete.Image = global::GUI.Properties.Resources.delete_icon;
			this.btn_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Delete.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Delete.Location = new System.Drawing.Point(166, 63);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(104, 36);
			this.btn_Delete.TabIndex = 2;
			this.btn_Delete.Text = "Xóa";
			this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btn_Update
			// 
			this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(37)))));
			this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Update.ForeColor = System.Drawing.Color.Black;
			this.btn_Update.Image = global::GUI.Properties.Resources.update_icon;
			this.btn_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Update.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Update.Location = new System.Drawing.Point(276, 63);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(104, 36);
			this.btn_Update.TabIndex = 1;
			this.btn_Update.Text = "Sửa";
			this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btn_Insert
			// 
			this.btn_Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Insert.FillColor = System.Drawing.Color.LightGreen;
			this.btn_Insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Insert.ForeColor = System.Drawing.Color.Black;
			this.btn_Insert.Image = global::GUI.Properties.Resources.insert_icon;
			this.btn_Insert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Insert.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Insert.Location = new System.Drawing.Point(56, 63);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(104, 36);
			this.btn_Insert.TabIndex = 0;
			this.btn_Insert.Text = "Thêm";
			this.btn_Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// dgv_Students
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgv_Students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_Students.ColumnHeadersHeight = 4;
			this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Students.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_Students.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Students.Location = new System.Drawing.Point(566, 134);
			this.dgv_Students.Name = "dgv_Students";
			this.dgv_Students.RowHeadersVisible = false;
			this.dgv_Students.RowHeadersWidth = 51;
			this.dgv_Students.Size = new System.Drawing.Size(822, 654);
			this.dgv_Students.TabIndex = 4;
			this.dgv_Students.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Students.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_Students.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_Students.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_Students.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_Students.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Students.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Students.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_Students.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_Students.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Students.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_Students.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_Students.ThemeStyle.HeaderStyle.Height = 4;
			this.dgv_Students.ThemeStyle.ReadOnly = false;
			this.dgv_Students.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Students.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_Students.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Students.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Students.ThemeStyle.RowsStyle.Height = 22;
			this.dgv_Students.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Students.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			this.pnl_Control.Size = new System.Drawing.Size(1400, 128);
			this.pnl_Control.TabIndex = 5;
			// 
			// lbl_Bus
			// 
			this.lbl_Bus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Bus.Location = new System.Drawing.Point(3, 101);
			this.lbl_Bus.Name = "lbl_Bus";
			this.lbl_Bus.Size = new System.Drawing.Size(122, 36);
			this.lbl_Bus.TabIndex = 23;
			this.lbl_Bus.Text = "Mô Tả";
			this.lbl_Bus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Date
			// 
			this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Date.Location = new System.Drawing.Point(3, 57);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(122, 36);
			this.lbl_Date.TabIndex = 22;
			this.lbl_Date.Text = "Tên Vùng";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(583, 20);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(234, 88);
			this.lbl_Title.TabIndex = 15;
			this.lbl_Title.Text = "Quản Lý Vùng";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TQT_FormRegion
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1400, 800);
			this.Controls.Add(this.pnl_Control);
			this.Controls.Add(this.dgv_Students);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.cbb_Region);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TQT_FormRegion";
			this.Text = "TQT_FormRegion";
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
			this.pnl_Control.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbb_Region;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Students;
        private Guna.UI2.WinForms.Guna2TextBox txt_Description;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameRegion;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Insert;
		private Guna.UI2.WinForms.Guna2Panel pnl_Control;
		private System.Windows.Forms.Label lbl_Bus;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_Title;
	}
}