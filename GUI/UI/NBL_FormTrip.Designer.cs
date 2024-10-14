namespace GUI.UI
{
	partial class NBL_FormTrip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NBL_FormTrip));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnl_Trips = new Guna.UI2.WinForms.Guna2Panel();
			this.pbx_Loading = new Guna.UI2.WinForms.Guna2PictureBox();
			this.pnl_Properties = new Guna.UI2.WinForms.Guna2Panel();
			this.pnl_Student = new Guna.UI2.WinForms.Guna2Panel();
			this.cbx_Status = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbl_StudentHeader = new System.Windows.Forms.Label();
			this.rbn_Status = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.rbn_Quantity = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_Capacity = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.btn_Auto = new Guna.UI2.WinForms.Guna2Button();
			this.lbl_Capacity = new System.Windows.Forms.Label();
			this.btn_Remove = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
			this.lbl_Student = new System.Windows.Forms.Label();
			this.cbx_Student = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dgv_Student = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lbl_Quantity = new System.Windows.Forms.Label();
			this.tbx_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbx_Capacity = new Guna.UI2.WinForms.Guna2TextBox();
			this.pnl_Information = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_Information = new System.Windows.Forms.Label();
			this.rbn_Price = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_Region = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_School = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_Driver = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_Bus = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.rbn_Date = new Guna.UI2.WinForms.Guna2ImageRadioButton();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.tbx_Price = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbx_Region = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbl_Region = new System.Windows.Forms.Label();
			this.cbx_School = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbl_School = new System.Windows.Forms.Label();
			this.cbx_Driver = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbl_Driver = new System.Windows.Forms.Label();
			this.cbx_Bus = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbl_Bus = new System.Windows.Forms.Label();
			this.dtp_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.pnl_Control = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Filter = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Insert = new Guna.UI2.WinForms.Guna2Button();
			this.pnl_Trips.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_Loading)).BeginInit();
			this.pnl_Properties.SuspendLayout();
			this.pnl_Student.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
			this.pnl_Information.SuspendLayout();
			this.pnl_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_Trips
			// 
			this.pnl_Trips.AutoScroll = true;
			this.pnl_Trips.Controls.Add(this.pbx_Loading);
			this.pnl_Trips.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_Trips.Location = new System.Drawing.Point(0, 0);
			this.pnl_Trips.Name = "pnl_Trips";
			this.pnl_Trips.Size = new System.Drawing.Size(590, 800);
			this.pnl_Trips.TabIndex = 0;
			// 
			// pbx_Loading
			// 
			this.pbx_Loading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbx_Loading.Image = global::GUI.Properties.Resources.loading_picture;
			this.pbx_Loading.ImageRotate = 0F;
			this.pbx_Loading.Location = new System.Drawing.Point(0, 0);
			this.pbx_Loading.Name = "pbx_Loading";
			this.pbx_Loading.Size = new System.Drawing.Size(590, 800);
			this.pbx_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbx_Loading.TabIndex = 0;
			this.pbx_Loading.TabStop = false;
			// 
			// pnl_Properties
			// 
			this.pnl_Properties.Controls.Add(this.pnl_Student);
			this.pnl_Properties.Controls.Add(this.pnl_Information);
			this.pnl_Properties.Controls.Add(this.pnl_Control);
			this.pnl_Properties.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnl_Properties.Location = new System.Drawing.Point(600, 0);
			this.pnl_Properties.Name = "pnl_Properties";
			this.pnl_Properties.Size = new System.Drawing.Size(680, 800);
			this.pnl_Properties.TabIndex = 1;
			// 
			// pnl_Student
			// 
			this.pnl_Student.BorderColor = System.Drawing.Color.Black;
			this.pnl_Student.BorderThickness = 1;
			this.pnl_Student.Controls.Add(this.cbx_Status);
			this.pnl_Student.Controls.Add(this.lbl_StudentHeader);
			this.pnl_Student.Controls.Add(this.rbn_Status);
			this.pnl_Student.Controls.Add(this.lbl_Status);
			this.pnl_Student.Controls.Add(this.rbn_Quantity);
			this.pnl_Student.Controls.Add(this.rbn_Capacity);
			this.pnl_Student.Controls.Add(this.btn_Auto);
			this.pnl_Student.Controls.Add(this.lbl_Capacity);
			this.pnl_Student.Controls.Add(this.btn_Remove);
			this.pnl_Student.Controls.Add(this.btn_Add);
			this.pnl_Student.Controls.Add(this.lbl_Student);
			this.pnl_Student.Controls.Add(this.cbx_Student);
			this.pnl_Student.Controls.Add(this.dgv_Student);
			this.pnl_Student.Controls.Add(this.lbl_Quantity);
			this.pnl_Student.Controls.Add(this.tbx_Quantity);
			this.pnl_Student.Controls.Add(this.tbx_Capacity);
			this.pnl_Student.Location = new System.Drawing.Point(0, 460);
			this.pnl_Student.Name = "pnl_Student";
			this.pnl_Student.Size = new System.Drawing.Size(680, 340);
			this.pnl_Student.TabIndex = 3;
			// 
			// cbx_Status
			// 
			this.cbx_Status.BackColor = System.Drawing.Color.Transparent;
			this.cbx_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Status.ForeColor = System.Drawing.Color.Black;
			this.cbx_Status.ItemHeight = 30;
			this.cbx_Status.Location = new System.Drawing.Point(144, 148);
			this.cbx_Status.Name = "cbx_Status";
			this.cbx_Status.Size = new System.Drawing.Size(148, 36);
			this.cbx_Status.TabIndex = 53;
			// 
			// lbl_StudentHeader
			// 
			this.lbl_StudentHeader.BackColor = System.Drawing.Color.LightGray;
			this.lbl_StudentHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_StudentHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_StudentHeader.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_StudentHeader.Location = new System.Drawing.Point(0, 0);
			this.lbl_StudentHeader.Name = "lbl_StudentHeader";
			this.lbl_StudentHeader.Size = new System.Drawing.Size(680, 44);
			this.lbl_StudentHeader.TabIndex = 52;
			this.lbl_StudentHeader.Text = "     Thông Tin Sinh Viên";
			this.lbl_StudentHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rbn_Status
			// 
			this.rbn_Status.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.rbn_Status.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Status.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Status.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Status.Image")));
			this.rbn_Status.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Status.ImageRotate = 0F;
			this.rbn_Status.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Status.Location = new System.Drawing.Point(298, 148);
			this.rbn_Status.Name = "rbn_Status";
			this.rbn_Status.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Status.Size = new System.Drawing.Size(36, 36);
			this.rbn_Status.TabIndex = 51;
			// 
			// lbl_Status
			// 
			this.lbl_Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Status.Location = new System.Drawing.Point(16, 148);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(122, 36);
			this.lbl_Status.TabIndex = 50;
			this.lbl_Status.Text = "Trạng Thái";
			this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rbn_Quantity
			// 
			this.rbn_Quantity.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.rbn_Quantity.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Quantity.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Quantity.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Quantity.Image")));
			this.rbn_Quantity.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Quantity.ImageRotate = 0F;
			this.rbn_Quantity.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Quantity.Location = new System.Drawing.Point(298, 105);
			this.rbn_Quantity.Name = "rbn_Quantity";
			this.rbn_Quantity.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Quantity.Size = new System.Drawing.Size(36, 36);
			this.rbn_Quantity.TabIndex = 43;
			// 
			// rbn_Capacity
			// 
			this.rbn_Capacity.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
			this.rbn_Capacity.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Capacity.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Capacity.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Capacity.Image")));
			this.rbn_Capacity.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Capacity.ImageRotate = 0F;
			this.rbn_Capacity.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Capacity.Location = new System.Drawing.Point(298, 63);
			this.rbn_Capacity.Name = "rbn_Capacity";
			this.rbn_Capacity.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Capacity.Size = new System.Drawing.Size(36, 36);
			this.rbn_Capacity.TabIndex = 44;
			// 
			// btn_Auto
			// 
			this.btn_Auto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Auto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Auto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Auto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Auto.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btn_Auto.ForeColor = System.Drawing.Color.White;
			this.btn_Auto.Location = new System.Drawing.Point(144, 208);
			this.btn_Auto.Name = "btn_Auto";
			this.btn_Auto.Size = new System.Drawing.Size(190, 36);
			this.btn_Auto.TabIndex = 48;
			this.btn_Auto.Text = "Tự Động Thêm";
			// 
			// lbl_Capacity
			// 
			this.lbl_Capacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Capacity.Location = new System.Drawing.Point(16, 63);
			this.lbl_Capacity.Name = "lbl_Capacity";
			this.lbl_Capacity.Size = new System.Drawing.Size(122, 36);
			this.lbl_Capacity.TabIndex = 37;
			this.lbl_Capacity.Text = "Sức Chứa";
			this.lbl_Capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Remove
			// 
			this.btn_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Remove.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btn_Remove.ForeColor = System.Drawing.Color.White;
			this.btn_Remove.Location = new System.Drawing.Point(182, 292);
			this.btn_Remove.Name = "btn_Remove";
			this.btn_Remove.Size = new System.Drawing.Size(152, 36);
			this.btn_Remove.TabIndex = 47;
			this.btn_Remove.Text = "Xóa Sinh Viên";
			// 
			// btn_Add
			// 
			this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.Color.White;
			this.btn_Add.Location = new System.Drawing.Point(18, 292);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(152, 36);
			this.btn_Add.TabIndex = 46;
			this.btn_Add.Text = "Thêm Sinh Viên";
			// 
			// lbl_Student
			// 
			this.lbl_Student.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Student.Location = new System.Drawing.Point(16, 208);
			this.lbl_Student.Name = "lbl_Student";
			this.lbl_Student.Size = new System.Drawing.Size(122, 36);
			this.lbl_Student.TabIndex = 38;
			this.lbl_Student.Text = "Học Sinh";
			this.lbl_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbx_Student
			// 
			this.cbx_Student.BackColor = System.Drawing.Color.Transparent;
			this.cbx_Student.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Student.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Student.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Student.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Student.ForeColor = System.Drawing.Color.Black;
			this.cbx_Student.ItemHeight = 30;
			this.cbx_Student.Location = new System.Drawing.Point(18, 250);
			this.cbx_Student.Name = "cbx_Student";
			this.cbx_Student.Size = new System.Drawing.Size(316, 36);
			this.cbx_Student.TabIndex = 39;
			// 
			// dgv_Student
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgv_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Student.ColumnHeadersHeight = 4;
			this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Student.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_Student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Student.Location = new System.Drawing.Point(350, 63);
			this.dgv_Student.Name = "dgv_Student";
			this.dgv_Student.RowHeadersVisible = false;
			this.dgv_Student.RowHeadersWidth = 51;
			this.dgv_Student.Size = new System.Drawing.Size(314, 265);
			this.dgv_Student.TabIndex = 45;
			this.dgv_Student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Student.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_Student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_Student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_Student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_Student.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_Student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_Student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_Student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_Student.ThemeStyle.HeaderStyle.Height = 4;
			this.dgv_Student.ThemeStyle.ReadOnly = false;
			this.dgv_Student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_Student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Student.ThemeStyle.RowsStyle.Height = 22;
			this.dgv_Student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// lbl_Quantity
			// 
			this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Quantity.Location = new System.Drawing.Point(16, 105);
			this.lbl_Quantity.Name = "lbl_Quantity";
			this.lbl_Quantity.Size = new System.Drawing.Size(122, 36);
			this.lbl_Quantity.TabIndex = 42;
			this.lbl_Quantity.Text = "Số Lượng";
			this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbx_Quantity
			// 
			this.tbx_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbx_Quantity.DefaultText = "";
			this.tbx_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.tbx_Quantity.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbx_Quantity.DisabledState.ForeColor = System.Drawing.Color.Black;
			this.tbx_Quantity.Enabled = false;
			this.tbx_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Quantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_Quantity.ForeColor = System.Drawing.Color.Black;
			this.tbx_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Quantity.Location = new System.Drawing.Point(144, 105);
			this.tbx_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbx_Quantity.Name = "tbx_Quantity";
			this.tbx_Quantity.PasswordChar = '\0';
			this.tbx_Quantity.PlaceholderText = "";
			this.tbx_Quantity.SelectedText = "";
			this.tbx_Quantity.Size = new System.Drawing.Size(148, 36);
			this.tbx_Quantity.TabIndex = 41;
			// 
			// tbx_Capacity
			// 
			this.tbx_Capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbx_Capacity.DefaultText = "";
			this.tbx_Capacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.tbx_Capacity.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbx_Capacity.DisabledState.ForeColor = System.Drawing.Color.Black;
			this.tbx_Capacity.Enabled = false;
			this.tbx_Capacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Capacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_Capacity.ForeColor = System.Drawing.Color.Black;
			this.tbx_Capacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Capacity.Location = new System.Drawing.Point(144, 63);
			this.tbx_Capacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbx_Capacity.Name = "tbx_Capacity";
			this.tbx_Capacity.PasswordChar = '\0';
			this.tbx_Capacity.PlaceholderText = "";
			this.tbx_Capacity.SelectedText = "";
			this.tbx_Capacity.Size = new System.Drawing.Size(148, 36);
			this.tbx_Capacity.TabIndex = 40;
			// 
			// pnl_Information
			// 
			this.pnl_Information.BorderColor = System.Drawing.Color.Black;
			this.pnl_Information.BorderThickness = 1;
			this.pnl_Information.Controls.Add(this.lbl_Information);
			this.pnl_Information.Controls.Add(this.rbn_Price);
			this.pnl_Information.Controls.Add(this.rbn_Region);
			this.pnl_Information.Controls.Add(this.rbn_School);
			this.pnl_Information.Controls.Add(this.rbn_Driver);
			this.pnl_Information.Controls.Add(this.rbn_Bus);
			this.pnl_Information.Controls.Add(this.rbn_Date);
			this.pnl_Information.Controls.Add(this.lbl_Price);
			this.pnl_Information.Controls.Add(this.tbx_Price);
			this.pnl_Information.Controls.Add(this.cbx_Region);
			this.pnl_Information.Controls.Add(this.lbl_Region);
			this.pnl_Information.Controls.Add(this.cbx_School);
			this.pnl_Information.Controls.Add(this.lbl_School);
			this.pnl_Information.Controls.Add(this.cbx_Driver);
			this.pnl_Information.Controls.Add(this.lbl_Driver);
			this.pnl_Information.Controls.Add(this.cbx_Bus);
			this.pnl_Information.Controls.Add(this.lbl_Bus);
			this.pnl_Information.Controls.Add(this.dtp_Date);
			this.pnl_Information.Controls.Add(this.lbl_Date);
			this.pnl_Information.Location = new System.Drawing.Point(0, 134);
			this.pnl_Information.Name = "pnl_Information";
			this.pnl_Information.Size = new System.Drawing.Size(680, 320);
			this.pnl_Information.TabIndex = 2;
			// 
			// lbl_Information
			// 
			this.lbl_Information.BackColor = System.Drawing.Color.LightGray;
			this.lbl_Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_Information.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Information.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Information.Location = new System.Drawing.Point(0, 0);
			this.lbl_Information.Name = "lbl_Information";
			this.lbl_Information.Size = new System.Drawing.Size(680, 44);
			this.lbl_Information.TabIndex = 36;
			this.lbl_Information.Text = "     Thông Tin Chuyến Đi";
			this.lbl_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rbn_Price
			// 
			this.rbn_Price.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
			this.rbn_Price.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Price.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Price.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Price.Image")));
			this.rbn_Price.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Price.ImageRotate = 0F;
			this.rbn_Price.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Price.Location = new System.Drawing.Point(628, 271);
			this.rbn_Price.Name = "rbn_Price";
			this.rbn_Price.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Price.Size = new System.Drawing.Size(36, 36);
			this.rbn_Price.TabIndex = 35;
			// 
			// rbn_Region
			// 
			this.rbn_Region.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
			this.rbn_Region.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Region.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Region.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Region.Image")));
			this.rbn_Region.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Region.ImageRotate = 0F;
			this.rbn_Region.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Region.Location = new System.Drawing.Point(628, 229);
			this.rbn_Region.Name = "rbn_Region";
			this.rbn_Region.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Region.Size = new System.Drawing.Size(36, 36);
			this.rbn_Region.TabIndex = 34;
			// 
			// rbn_School
			// 
			this.rbn_School.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
			this.rbn_School.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_School.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_School.Image = ((System.Drawing.Image)(resources.GetObject("rbn_School.Image")));
			this.rbn_School.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_School.ImageRotate = 0F;
			this.rbn_School.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_School.Location = new System.Drawing.Point(628, 187);
			this.rbn_School.Name = "rbn_School";
			this.rbn_School.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_School.Size = new System.Drawing.Size(36, 36);
			this.rbn_School.TabIndex = 33;
			// 
			// rbn_Driver
			// 
			this.rbn_Driver.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
			this.rbn_Driver.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Driver.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Driver.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Driver.Image")));
			this.rbn_Driver.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Driver.ImageRotate = 0F;
			this.rbn_Driver.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Driver.Location = new System.Drawing.Point(628, 145);
			this.rbn_Driver.Name = "rbn_Driver";
			this.rbn_Driver.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Driver.Size = new System.Drawing.Size(36, 36);
			this.rbn_Driver.TabIndex = 32;
			// 
			// rbn_Bus
			// 
			this.rbn_Bus.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
			this.rbn_Bus.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Bus.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Bus.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Bus.Image")));
			this.rbn_Bus.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Bus.ImageRotate = 0F;
			this.rbn_Bus.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Bus.Location = new System.Drawing.Point(628, 103);
			this.rbn_Bus.Name = "rbn_Bus";
			this.rbn_Bus.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Bus.Size = new System.Drawing.Size(36, 36);
			this.rbn_Bus.TabIndex = 31;
			// 
			// rbn_Date
			// 
			this.rbn_Date.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
			this.rbn_Date.CheckedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Date.HoverState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Date.Image = ((System.Drawing.Image)(resources.GetObject("rbn_Date.Image")));
			this.rbn_Date.ImageOffset = new System.Drawing.Point(0, 0);
			this.rbn_Date.ImageRotate = 0F;
			this.rbn_Date.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Date.Location = new System.Drawing.Point(628, 61);
			this.rbn_Date.Name = "rbn_Date";
			this.rbn_Date.PressedState.ImageSize = new System.Drawing.Size(36, 36);
			this.rbn_Date.Size = new System.Drawing.Size(36, 36);
			this.rbn_Date.TabIndex = 19;
			// 
			// lbl_Price
			// 
			this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Price.Location = new System.Drawing.Point(14, 271);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.Size = new System.Drawing.Size(122, 36);
			this.lbl_Price.TabIndex = 30;
			this.lbl_Price.Text = "Tổng Tiền";
			this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbx_Price
			// 
			this.tbx_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbx_Price.DefaultText = "";
			this.tbx_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
			this.tbx_Price.DisabledState.FillColor = System.Drawing.Color.White;
			this.tbx_Price.DisabledState.ForeColor = System.Drawing.Color.Black;
			this.tbx_Price.Enabled = false;
			this.tbx_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_Price.ForeColor = System.Drawing.Color.Black;
			this.tbx_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbx_Price.Location = new System.Drawing.Point(144, 271);
			this.tbx_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbx_Price.Name = "tbx_Price";
			this.tbx_Price.PasswordChar = '\0';
			this.tbx_Price.PlaceholderText = "";
			this.tbx_Price.SelectedText = "";
			this.tbx_Price.Size = new System.Drawing.Size(478, 36);
			this.tbx_Price.TabIndex = 29;
			// 
			// cbx_Region
			// 
			this.cbx_Region.BackColor = System.Drawing.Color.Transparent;
			this.cbx_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Region.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Region.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Region.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Region.ForeColor = System.Drawing.Color.Black;
			this.cbx_Region.ItemHeight = 30;
			this.cbx_Region.Location = new System.Drawing.Point(144, 229);
			this.cbx_Region.Name = "cbx_Region";
			this.cbx_Region.Size = new System.Drawing.Size(478, 36);
			this.cbx_Region.TabIndex = 28;
			// 
			// lbl_Region
			// 
			this.lbl_Region.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Region.Location = new System.Drawing.Point(16, 229);
			this.lbl_Region.Name = "lbl_Region";
			this.lbl_Region.Size = new System.Drawing.Size(122, 36);
			this.lbl_Region.TabIndex = 27;
			this.lbl_Region.Text = "Khu Vực";
			this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbx_School
			// 
			this.cbx_School.BackColor = System.Drawing.Color.Transparent;
			this.cbx_School.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_School.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_School.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_School.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_School.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_School.ForeColor = System.Drawing.Color.Black;
			this.cbx_School.ItemHeight = 30;
			this.cbx_School.Location = new System.Drawing.Point(144, 187);
			this.cbx_School.Name = "cbx_School";
			this.cbx_School.Size = new System.Drawing.Size(478, 36);
			this.cbx_School.TabIndex = 26;
			// 
			// lbl_School
			// 
			this.lbl_School.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_School.Location = new System.Drawing.Point(16, 187);
			this.lbl_School.Name = "lbl_School";
			this.lbl_School.Size = new System.Drawing.Size(122, 36);
			this.lbl_School.TabIndex = 25;
			this.lbl_School.Text = "Trường Học";
			this.lbl_School.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbx_Driver
			// 
			this.cbx_Driver.BackColor = System.Drawing.Color.Transparent;
			this.cbx_Driver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_Driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Driver.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Driver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Driver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Driver.ForeColor = System.Drawing.Color.Black;
			this.cbx_Driver.ItemHeight = 30;
			this.cbx_Driver.Location = new System.Drawing.Point(144, 145);
			this.cbx_Driver.Name = "cbx_Driver";
			this.cbx_Driver.Size = new System.Drawing.Size(478, 36);
			this.cbx_Driver.TabIndex = 24;
			// 
			// lbl_Driver
			// 
			this.lbl_Driver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Driver.Location = new System.Drawing.Point(16, 145);
			this.lbl_Driver.Name = "lbl_Driver";
			this.lbl_Driver.Size = new System.Drawing.Size(122, 36);
			this.lbl_Driver.TabIndex = 23;
			this.lbl_Driver.Text = "Tài Xế";
			this.lbl_Driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbx_Bus
			// 
			this.cbx_Bus.BackColor = System.Drawing.Color.Transparent;
			this.cbx_Bus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbx_Bus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Bus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Bus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbx_Bus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Bus.ForeColor = System.Drawing.Color.Black;
			this.cbx_Bus.ItemHeight = 30;
			this.cbx_Bus.Location = new System.Drawing.Point(144, 103);
			this.cbx_Bus.Name = "cbx_Bus";
			this.cbx_Bus.Size = new System.Drawing.Size(478, 36);
			this.cbx_Bus.TabIndex = 22;
			// 
			// lbl_Bus
			// 
			this.lbl_Bus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Bus.Location = new System.Drawing.Point(16, 103);
			this.lbl_Bus.Name = "lbl_Bus";
			this.lbl_Bus.Size = new System.Drawing.Size(122, 36);
			this.lbl_Bus.TabIndex = 21;
			this.lbl_Bus.Text = "Xe Buýt";
			this.lbl_Bus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_Date
			// 
			this.dtp_Date.Checked = true;
			this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtp_Date.Location = new System.Drawing.Point(144, 61);
			this.dtp_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtp_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtp_Date.Name = "dtp_Date";
			this.dtp_Date.Size = new System.Drawing.Size(478, 36);
			this.dtp_Date.TabIndex = 20;
			this.dtp_Date.Value = new System.DateTime(2024, 10, 12, 14, 24, 38, 960);
			// 
			// lbl_Date
			// 
			this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Date.Location = new System.Drawing.Point(16, 61);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(122, 36);
			this.lbl_Date.TabIndex = 18;
			this.lbl_Date.Text = "Ngày Khởi Hành";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Control
			// 
			this.pnl_Control.BorderColor = System.Drawing.Color.Black;
			this.pnl_Control.BorderRadius = 60;
			this.pnl_Control.BorderThickness = 1;
			this.pnl_Control.Controls.Add(this.lbl_Title);
			this.pnl_Control.Controls.Add(this.btn_Cancel);
			this.pnl_Control.Controls.Add(this.btn_Filter);
			this.pnl_Control.Controls.Add(this.btn_Clear);
			this.pnl_Control.Controls.Add(this.btn_Update);
			this.pnl_Control.Controls.Add(this.btn_Delete);
			this.pnl_Control.Controls.Add(this.btn_Insert);
			this.pnl_Control.CustomizableEdges.BottomLeft = false;
			this.pnl_Control.CustomizableEdges.TopLeft = false;
			this.pnl_Control.CustomizableEdges.TopRight = false;
			this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Control.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.pnl_Control.Location = new System.Drawing.Point(0, 0);
			this.pnl_Control.Name = "pnl_Control";
			this.pnl_Control.Size = new System.Drawing.Size(680, 128);
			this.pnl_Control.TabIndex = 1;
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(49, 20);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(234, 88);
			this.lbl_Title.TabIndex = 14;
			this.lbl_Title.Text = "Quản Lý Chuyến Đi";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Cancel.FillColor = System.Drawing.Color.LightPink;
			this.btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
			this.btn_Cancel.Image = global::GUI.Properties.Resources.cancel_icon;
			this.btn_Cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Cancel.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Cancel.Location = new System.Drawing.Point(432, 62);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(104, 36);
			this.btn_Cancel.TabIndex = 33;
			this.btn_Cancel.Text = "Hủy";
			this.btn_Cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btn_Filter
			// 
			this.btn_Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Filter.FillColor = System.Drawing.Color.SkyBlue;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = global::GUI.Properties.Resources.filter_icon;
			this.btn_Filter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Filter.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Filter.Location = new System.Drawing.Point(322, 62);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(104, 36);
			this.btn_Filter.TabIndex = 32;
			this.btn_Filter.Text = "Lọc";
			this.btn_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// btn_Clear
			// 
			this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Clear.FillColor = System.Drawing.Color.LightGray;
			this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Clear.ForeColor = System.Drawing.Color.Black;
			this.btn_Clear.Image = global::GUI.Properties.Resources.clear_icon;
			this.btn_Clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Clear.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Clear.Location = new System.Drawing.Point(542, 62);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(104, 36);
			this.btn_Clear.TabIndex = 31;
			this.btn_Clear.Text = "Mới";
			this.btn_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.btn_Update.Location = new System.Drawing.Point(542, 20);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(104, 36);
			this.btn_Update.TabIndex = 30;
			this.btn_Update.Text = "Sửa";
			this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.btn_Delete.Location = new System.Drawing.Point(432, 20);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(104, 36);
			this.btn_Delete.TabIndex = 29;
			this.btn_Delete.Text = "Xóa";
			this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.btn_Insert.Location = new System.Drawing.Point(322, 20);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(104, 36);
			this.btn_Insert.TabIndex = 28;
			this.btn_Insert.Text = "Thêm";
			this.btn_Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// NBL_FormTrip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.pnl_Properties);
			this.Controls.Add(this.pnl_Trips);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NBL_FormTrip";
			this.Text = "NBL_FormTrip";
			this.pnl_Trips.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbx_Loading)).EndInit();
			this.pnl_Properties.ResumeLayout(false);
			this.pnl_Student.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
			this.pnl_Information.ResumeLayout(false);
			this.pnl_Control.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel pnl_Trips;
		private Guna.UI2.WinForms.Guna2Panel pnl_Properties;
		private Guna.UI2.WinForms.Guna2Panel pnl_Control;
		private Guna.UI2.WinForms.Guna2Panel pnl_Information;
		private Guna.UI2.WinForms.Guna2Panel pnl_Student;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lbl_Information;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Price;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Region;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_School;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Driver;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Bus;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Date;
		private System.Windows.Forms.Label lbl_Price;
		private Guna.UI2.WinForms.Guna2TextBox tbx_Price;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_Region;
		private System.Windows.Forms.Label lbl_Region;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_School;
		private System.Windows.Forms.Label lbl_School;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_Driver;
		private System.Windows.Forms.Label lbl_Driver;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_Bus;
		private System.Windows.Forms.Label lbl_Bus;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Date;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_StudentHeader;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Status;
		private System.Windows.Forms.Label lbl_Status;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Quantity;
		private Guna.UI2.WinForms.Guna2ImageRadioButton rbn_Capacity;
		private Guna.UI2.WinForms.Guna2Button btn_Auto;
		private System.Windows.Forms.Label lbl_Capacity;
		private Guna.UI2.WinForms.Guna2Button btn_Remove;
		private Guna.UI2.WinForms.Guna2Button btn_Add;
		private System.Windows.Forms.Label lbl_Student;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_Student;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_Student;
		private System.Windows.Forms.Label lbl_Quantity;
		private Guna.UI2.WinForms.Guna2TextBox tbx_Quantity;
		private Guna.UI2.WinForms.Guna2TextBox tbx_Capacity;
		private Guna.UI2.WinForms.Guna2Button btn_Cancel;
		private Guna.UI2.WinForms.Guna2Button btn_Filter;
		private Guna.UI2.WinForms.Guna2Button btn_Clear;
		private Guna.UI2.WinForms.Guna2Button btn_Update;
		private Guna.UI2.WinForms.Guna2Button btn_Delete;
		private Guna.UI2.WinForms.Guna2Button btn_Insert;
		private Guna.UI2.WinForms.Guna2PictureBox pbx_Loading;
		private Guna.UI2.WinForms.Guna2ComboBox cbx_Status;
	}
}