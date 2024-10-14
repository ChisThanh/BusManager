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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BorderRadius = 2;
            this.btn_Close.FillColor = System.Drawing.Color.LightCoral;
            this.btn_Close.IconColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(2399, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(45, 29);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý tài xế";
            // 
            // btn_Search
            // 
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(899, 405);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 48);
            this.btn_Search.TabIndex = 46;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tìm kiếm";
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
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(578, 405);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(289, 48);
            this.txt_Search.TabIndex = 44;
            // 
            // btn_Save
            // 
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1651, 140);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 45);
            this.btn_Save.TabIndex = 43;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(1442, 240);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 45);
            this.btn_Delete.TabIndex = 42;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(1651, 231);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(102, 45);
            this.btn_Update.TabIndex = 41;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1442, 140);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 45);
            this.btn_Add.TabIndex = 40;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Driver
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Driver.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Driver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Driver.ColumnHeadersHeight = 4;
            this.dgv_Driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Driver.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Driver.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Driver.Location = new System.Drawing.Point(75, 459);
            this.dgv_Driver.Name = "dgv_Driver";
            this.dgv_Driver.RowHeadersVisible = false;
            this.dgv_Driver.RowHeadersWidth = 51;
            this.dgv_Driver.RowTemplate.Height = 24;
            this.dgv_Driver.Size = new System.Drawing.Size(1693, 368);
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
            this.dgv_Driver.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Driver.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Driver.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Driver.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Driver.ThemeStyle.ReadOnly = false;
            this.dgv_Driver.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Driver.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Driver.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(696, 218);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(229, 48);
            this.txt_Phone.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ngày sinh";
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
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(223, 140);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(229, 48);
            this.txt_Name.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Họ tên";
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
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Location = new System.Drawing.Point(223, 296);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderText = "";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(229, 48);
            this.txt_Address.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Địa chỉ";
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
            this.txt_LicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LicenseID.Location = new System.Drawing.Point(1129, 137);
            this.txt_LicenseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LicenseID.Name = "txt_LicenseID";
            this.txt_LicenseID.PasswordChar = '\0';
            this.txt_LicenseID.PlaceholderText = "";
            this.txt_LicenseID.SelectedText = "";
            this.txt_LicenseID.Size = new System.Drawing.Size(229, 48);
            this.txt_LicenseID.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1002, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "GPLX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1002, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 51;
            this.label9.Text = "Hạng";
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
            this.txt_LicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LicenseClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LicenseClass.Location = new System.Drawing.Point(1129, 206);
            this.txt_LicenseClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LicenseClass.Name = "txt_LicenseClass";
            this.txt_LicenseClass.PasswordChar = '\0';
            this.txt_LicenseClass.PlaceholderText = "";
            this.txt_LicenseClass.SelectedText = "";
            this.txt_LicenseClass.Size = new System.Drawing.Size(229, 48);
            this.txt_LicenseClass.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1002, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Ngày hết hạn";
            // 
            // dtp_DoB
            // 
            this.dtp_DoB.Checked = true;
            this.dtp_DoB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_DoB.Location = new System.Drawing.Point(696, 149);
            this.dtp_DoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DoB.Name = "dtp_DoB";
            this.dtp_DoB.Size = new System.Drawing.Size(229, 36);
            this.dtp_DoB.TabIndex = 55;
            this.dtp_DoB.Value = new System.DateTime(2024, 10, 12, 22, 37, 15, 957);
            // 
            // dtp_ExpiryDate
            // 
            this.dtp_ExpiryDate.Checked = true;
            this.dtp_ExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_ExpiryDate.Location = new System.Drawing.Point(1129, 283);
            this.dtp_ExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ExpiryDate.Name = "dtp_ExpiryDate";
            this.dtp_ExpiryDate.Size = new System.Drawing.Size(229, 36);
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
            this.cbo_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Gender.ItemHeight = 30;
            this.cbo_Gender.Location = new System.Drawing.Point(223, 218);
            this.cbo_Gender.Name = "cbo_Gender";
            this.cbo_Gender.Size = new System.Drawing.Size(229, 36);
            this.cbo_Gender.TabIndex = 57;
            // 
            // NNM_frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 1055);
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
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Driver);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NNM_frmDriver";
            this.Text = "NNM_frmDriver";
            this.Load += new System.EventHandler(this.NNM_frmDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Driver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btn_Close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
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
    }
}