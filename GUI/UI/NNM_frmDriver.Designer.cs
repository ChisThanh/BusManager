namespace GUI.UI
{
    partial class NNM_frmDriver
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
			this.btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
			this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgv_Driver = new Guna.UI2.WinForms.Guna2DataGridView();
			this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_LicenseID = new Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_LicenseClass = new Guna.UI2.WinForms.Guna2TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dtp_DoB = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.dtp_ExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbo_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
			this.pnl_Control = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).BeginInit();
			this.pnl_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Close.BorderRadius = 2;
			this.btn_Close.FillColor = System.Drawing.Color.LightCoral;
			this.btn_Close.IconColor = System.Drawing.Color.White;
			this.btn_Close.Location = new System.Drawing.Point(1820, 10);
			this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(34, 24);
			this.btn_Close.TabIndex = 11;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// txt_Search
			// 
			this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Search.DefaultText = "";
			this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Search.Location = new System.Drawing.Point(909, 45);
			this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.PasswordChar = '\0';
			this.txt_Search.PlaceholderText = "";
			this.txt_Search.SelectedText = "";
			this.txt_Search.Size = new System.Drawing.Size(217, 36);
			this.txt_Search.TabIndex = 44;
			// 
			// dgv_Driver
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgv_Driver.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_Driver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Driver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_Driver.ColumnHeadersHeight = 40;
			this.dgv_Driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Driver.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_Driver.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Driver.Location = new System.Drawing.Point(11, 358);
			this.dgv_Driver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgv_Driver.Name = "dgv_Driver";
			this.dgv_Driver.RowHeadersVisible = false;
			this.dgv_Driver.RowHeadersWidth = 51;
			this.dgv_Driver.RowTemplate.Height = 24;
			this.dgv_Driver.Size = new System.Drawing.Size(1378, 431);
			this.dgv_Driver.TabIndex = 38;
			this.dgv_Driver.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Driver.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_Driver.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_Driver.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_Driver.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_Driver.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Driver.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Driver.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_Driver.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_Driver.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Driver.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_Driver.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_Driver.ThemeStyle.HeaderStyle.Height = 40;
			this.dgv_Driver.ThemeStyle.ReadOnly = false;
			this.dgv_Driver.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Driver.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_Driver.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Driver.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Driver.ThemeStyle.RowsStyle.Height = 24;
			this.dgv_Driver.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Driver.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Driver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Driver_CellClick);
			// 
			// txt_Phone
			// 
			this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Phone.DefaultText = "";
			this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Phone.ForeColor = System.Drawing.Color.Black;
			this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Phone.Location = new System.Drawing.Point(118, 262);
			this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Phone.Name = "txt_Phone";
			this.txt_Phone.PasswordChar = '\0';
			this.txt_Phone.PlaceholderText = "";
			this.txt_Phone.SelectedText = "";
			this.txt_Phone.Size = new System.Drawing.Size(301, 36);
			this.txt_Phone.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 262);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 36);
			this.label5.TabIndex = 36;
			this.label5.Text = "Số điện thoại";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 179);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 36);
			this.label4.TabIndex = 35;
			this.label4.Text = "Giới tính";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 301);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 36);
			this.label3.TabIndex = 33;
			this.label3.Text = "Ngày sinh";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Name
			// 
			this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Name.DefaultText = "";
			this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Name.ForeColor = System.Drawing.Color.Black;
			this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Name.Location = new System.Drawing.Point(118, 138);
			this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.PasswordChar = '\0';
			this.txt_Name.PlaceholderText = "";
			this.txt_Name.SelectedText = "";
			this.txt_Name.Size = new System.Drawing.Size(301, 36);
			this.txt_Name.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 138);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 36);
			this.label2.TabIndex = 31;
			this.label2.Text = "Họ tên";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Address
			// 
			this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Address.DefaultText = "";
			this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Address.ForeColor = System.Drawing.Color.Black;
			this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Address.Location = new System.Drawing.Point(118, 220);
			this.txt_Address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.PasswordChar = '\0';
			this.txt_Address.PlaceholderText = "";
			this.txt_Address.SelectedText = "";
			this.txt_Address.Size = new System.Drawing.Size(301, 36);
			this.txt_Address.TabIndex = 48;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 220);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 36);
			this.label7.TabIndex = 47;
			this.label7.Text = "Địa chỉ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LicenseID
			// 
			this.txt_LicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_LicenseID.DefaultText = "";
			this.txt_LicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_LicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_LicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicenseID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LicenseID.ForeColor = System.Drawing.Color.Black;
			this.txt_LicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicenseID.Location = new System.Drawing.Point(586, 138);
			this.txt_LicenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_LicenseID.Name = "txt_LicenseID";
			this.txt_LicenseID.PasswordChar = '\0';
			this.txt_LicenseID.PlaceholderText = "";
			this.txt_LicenseID.SelectedText = "";
			this.txt_LicenseID.Size = new System.Drawing.Size(301, 36);
			this.txt_LicenseID.TabIndex = 50;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(482, 138);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 36);
			this.label8.TabIndex = 49;
			this.label8.Text = "GPLX";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(482, 180);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 36);
			this.label9.TabIndex = 51;
			this.label9.Text = "Hạng";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LicenseClass
			// 
			this.txt_LicenseClass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_LicenseClass.DefaultText = "";
			this.txt_LicenseClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_LicenseClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_LicenseClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicenseClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicenseClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicenseClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LicenseClass.ForeColor = System.Drawing.Color.Black;
			this.txt_LicenseClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicenseClass.Location = new System.Drawing.Point(586, 180);
			this.txt_LicenseClass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_LicenseClass.Name = "txt_LicenseClass";
			this.txt_LicenseClass.PasswordChar = '\0';
			this.txt_LicenseClass.PlaceholderText = "";
			this.txt_LicenseClass.SelectedText = "";
			this.txt_LicenseClass.Size = new System.Drawing.Size(301, 36);
			this.txt_LicenseClass.TabIndex = 54;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(482, 221);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 36);
			this.label10.TabIndex = 53;
			this.label10.Text = "Ngày hết hạn";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_DoB
			// 
			this.dtp_DoB.Checked = true;
			this.dtp_DoB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_DoB.ForeColor = System.Drawing.Color.Black;
			this.dtp_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtp_DoB.Location = new System.Drawing.Point(118, 303);
			this.dtp_DoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtp_DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtp_DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtp_DoB.Name = "dtp_DoB";
			this.dtp_DoB.Size = new System.Drawing.Size(301, 36);
			this.dtp_DoB.TabIndex = 55;
			this.dtp_DoB.Value = new System.DateTime(2024, 10, 12, 22, 37, 15, 957);
			// 
			// dtp_ExpiryDate
			// 
			this.dtp_ExpiryDate.Checked = true;
			this.dtp_ExpiryDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ExpiryDate.ForeColor = System.Drawing.Color.Black;
			this.dtp_ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtp_ExpiryDate.Location = new System.Drawing.Point(586, 221);
			this.dtp_ExpiryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtp_ExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtp_ExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtp_ExpiryDate.Name = "dtp_ExpiryDate";
			this.dtp_ExpiryDate.Size = new System.Drawing.Size(301, 36);
			this.dtp_ExpiryDate.TabIndex = 56;
			this.dtp_ExpiryDate.Value = new System.DateTime(2024, 10, 12, 22, 37, 15, 957);
			// 
			// cbo_Gender
			// 
			this.cbo_Gender.BackColor = System.Drawing.Color.Transparent;
			this.cbo_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_Gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_Gender.ForeColor = System.Drawing.Color.Black;
			this.cbo_Gender.ItemHeight = 30;
			this.cbo_Gender.Location = new System.Drawing.Point(118, 179);
			this.cbo_Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbo_Gender.Name = "cbo_Gender";
			this.cbo_Gender.Size = new System.Drawing.Size(301, 36);
			this.cbo_Gender.TabIndex = 57;
			// 
			// pnl_Control
			// 
			this.pnl_Control.BorderColor = System.Drawing.Color.Black;
			this.pnl_Control.BorderRadius = 60;
			this.pnl_Control.Controls.Add(this.btn_Save);
			this.pnl_Control.Controls.Add(this.btn_Search);
			this.pnl_Control.Controls.Add(this.lbl_Title);
			this.pnl_Control.Controls.Add(this.btn_Add);
			this.pnl_Control.Controls.Add(this.btn_Delete);
			this.pnl_Control.Controls.Add(this.btn_Update);
			this.pnl_Control.Controls.Add(this.txt_Search);
			this.pnl_Control.CustomizableEdges.BottomLeft = false;
			this.pnl_Control.CustomizableEdges.TopLeft = false;
			this.pnl_Control.CustomizableEdges.TopRight = false;
			this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Control.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.pnl_Control.Location = new System.Drawing.Point(0, 0);
			this.pnl_Control.Name = "pnl_Control";
			this.pnl_Control.Size = new System.Drawing.Size(1400, 129);
			this.pnl_Control.TabIndex = 58;
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(41, 20);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(212, 88);
			this.lbl_Title.TabIndex = 14;
			this.lbl_Title.Text = "Quản Lý Tài Xế";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Search
			// 
			this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Search.FillColor = System.Drawing.Color.Plum;
			this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Search.ForeColor = System.Drawing.Color.Black;
			this.btn_Search.Image = global::GUI.Properties.Resources.search_icon;
			this.btn_Search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Search.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Search.Location = new System.Drawing.Point(1131, 45);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(104, 36);
			this.btn_Search.TabIndex = 59;
			this.btn_Search.Text = "Tìm";
			this.btn_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Save.FillColor = System.Drawing.Color.Aquamarine;
			this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Save.ForeColor = System.Drawing.Color.Black;
			this.btn_Save.Image = global::GUI.Properties.Resources.save_icon;
			this.btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Save.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Save.Location = new System.Drawing.Point(1241, 45);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(104, 36);
			this.btn_Save.TabIndex = 60;
			this.btn_Save.Text = "Lưu";
			this.btn_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Add.FillColor = System.Drawing.Color.LightGreen;
			this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Add.ForeColor = System.Drawing.Color.Black;
			this.btn_Add.Image = global::GUI.Properties.Resources.insert_icon;
			this.btn_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Add.ImageSize = new System.Drawing.Size(30, 30);
			this.btn_Add.Location = new System.Drawing.Point(580, 45);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(104, 36);
			this.btn_Add.TabIndex = 28;
			this.btn_Add.Text = "Thêm";
			this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
			this.btn_Delete.Location = new System.Drawing.Point(690, 45);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(104, 36);
			this.btn_Delete.TabIndex = 29;
			this.btn_Delete.Text = "Xóa";
			this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
			this.btn_Update.Location = new System.Drawing.Point(800, 45);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(104, 36);
			this.btn_Update.TabIndex = 30;
			this.btn_Update.Text = "Sửa";
			this.btn_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// NNM_frmDriver
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1400, 800);
			this.Controls.Add(this.pnl_Control);
			this.Controls.Add(this.cbo_Gender);
			this.Controls.Add(this.dtp_ExpiryDate);
			this.Controls.Add(this.dtp_DoB);
			this.Controls.Add(this.txt_LicenseClass);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_LicenseID);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_Address);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgv_Driver);
			this.Controls.Add(this.txt_Phone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Close);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "NNM_frmDriver";
			this.Text = "NNM_frmDriver";
			this.Load += new System.EventHandler(this.NNM_frmDriver_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).EndInit();
			this.pnl_Control.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btn_Close;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Driver;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_LicenseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_LicenseClass;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_DoB;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ExpiryDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Gender;
		private Guna.UI2.WinForms.Guna2Panel pnl_Control;
		private System.Windows.Forms.Label lbl_Title;
		private Guna.UI2.WinForms.Guna2Button btn_Add;
		private Guna.UI2.WinForms.Guna2Button btn_Delete;
		private Guna.UI2.WinForms.Guna2Button btn_Update;
		private Guna.UI2.WinForms.Guna2Button btn_Search;
		private Guna.UI2.WinForms.Guna2Button btn_Save;
	}
}