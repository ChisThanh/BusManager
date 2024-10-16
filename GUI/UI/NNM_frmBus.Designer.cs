namespace GUI.UI
{
    partial class NNM_frmBus
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Model = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_Brand = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_LicensePlate = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgv_Bus = new Guna.UI2.WinForms.Guna2DataGridView();
			this.txt_Capacity = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
			this.pnl_Control = new Guna.UI2.WinForms.Guna2Panel();
			this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Bus)).BeginInit();
			this.pnl_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Close.BorderRadius = 2;
			this.btn_Close.FillColor = System.Drawing.Color.LightCoral;
			this.btn_Close.IconColor = System.Drawing.Color.White;
			this.btn_Close.Location = new System.Drawing.Point(1357, 10);
			this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(34, 24);
			this.btn_Close.TabIndex = 10;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 180);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 36);
			this.label2.TabIndex = 12;
			this.label2.Text = "Mẫu xe";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Model
			// 
			this.txt_Model.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Model.DefaultText = "";
			this.txt_Model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Model.ForeColor = System.Drawing.Color.Black;
			this.txt_Model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Model.Location = new System.Drawing.Point(115, 180);
			this.txt_Model.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.PasswordChar = '\0';
			this.txt_Model.PlaceholderText = "";
			this.txt_Model.SelectedText = "";
			this.txt_Model.Size = new System.Drawing.Size(415, 36);
			this.txt_Model.TabIndex = 13;
			// 
			// txt_Brand
			// 
			this.txt_Brand.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Brand.DefaultText = "";
			this.txt_Brand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Brand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Brand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Brand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Brand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Brand.ForeColor = System.Drawing.Color.Black;
			this.txt_Brand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Brand.Location = new System.Drawing.Point(115, 222);
			this.txt_Brand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Brand.Name = "txt_Brand";
			this.txt_Brand.PasswordChar = '\0';
			this.txt_Brand.PlaceholderText = "";
			this.txt_Brand.SelectedText = "";
			this.txt_Brand.Size = new System.Drawing.Size(415, 36);
			this.txt_Brand.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 222);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 36);
			this.label3.TabIndex = 14;
			this.label3.Text = "Thương hiệu";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 264);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 36);
			this.label4.TabIndex = 16;
			this.label4.Text = "Sức chứa";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LicensePlate
			// 
			this.txt_LicensePlate.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_LicensePlate.DefaultText = "";
			this.txt_LicensePlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_LicensePlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_LicensePlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicensePlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LicensePlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicensePlate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LicensePlate.ForeColor = System.Drawing.Color.Black;
			this.txt_LicensePlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LicensePlate.Location = new System.Drawing.Point(115, 138);
			this.txt_LicensePlate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_LicensePlate.Name = "txt_LicensePlate";
			this.txt_LicensePlate.PasswordChar = '\0';
			this.txt_LicensePlate.PlaceholderText = "";
			this.txt_LicensePlate.SelectedText = "";
			this.txt_LicensePlate.Size = new System.Drawing.Size(415, 36);
			this.txt_LicensePlate.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 138);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 36);
			this.label5.TabIndex = 18;
			this.label5.Text = "Biển số xe";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgv_Bus
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgv_Bus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_Bus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Bus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_Bus.ColumnHeadersHeight = 4;
			this.dgv_Bus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Bus.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_Bus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Bus.Location = new System.Drawing.Point(11, 310);
			this.dgv_Bus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgv_Bus.Name = "dgv_Bus";
			this.dgv_Bus.RowHeadersVisible = false;
			this.dgv_Bus.RowHeadersWidth = 51;
			this.dgv_Bus.RowTemplate.Height = 24;
			this.dgv_Bus.Size = new System.Drawing.Size(1378, 479);
			this.dgv_Bus.TabIndex = 21;
			this.dgv_Bus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Bus.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_Bus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_Bus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_Bus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_Bus.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Bus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Bus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_Bus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_Bus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Bus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_Bus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_Bus.ThemeStyle.HeaderStyle.Height = 4;
			this.dgv_Bus.ThemeStyle.ReadOnly = false;
			this.dgv_Bus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Bus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_Bus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Bus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Bus.ThemeStyle.RowsStyle.Height = 24;
			this.dgv_Bus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Bus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Bus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bus_CellClick);
			// 
			// txt_Capacity
			// 
			this.txt_Capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Capacity.DefaultText = "";
			this.txt_Capacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_Capacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_Capacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Capacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_Capacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Capacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Capacity.ForeColor = System.Drawing.Color.Black;
			this.txt_Capacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Capacity.Location = new System.Drawing.Point(115, 264);
			this.txt_Capacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Capacity.Name = "txt_Capacity";
			this.txt_Capacity.PasswordChar = '\0';
			this.txt_Capacity.PlaceholderText = "";
			this.txt_Capacity.SelectedText = "";
			this.txt_Capacity.Size = new System.Drawing.Size(415, 36);
			this.txt_Capacity.TabIndex = 22;
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
			this.txt_Search.ForeColor = System.Drawing.Color.Black;
			this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_Search.Location = new System.Drawing.Point(909, 45);
			this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.PasswordChar = '\0';
			this.txt_Search.PlaceholderText = "";
			this.txt_Search.SelectedText = "";
			this.txt_Search.Size = new System.Drawing.Size(217, 36);
			this.txt_Search.TabIndex = 28;
			// 
			// pnl_Control
			// 
			this.pnl_Control.BorderColor = System.Drawing.Color.Black;
			this.pnl_Control.BorderRadius = 60;
			this.pnl_Control.Controls.Add(this.btn_Save);
			this.pnl_Control.Controls.Add(this.btn_Search);
			this.pnl_Control.Controls.Add(this.lbl_Title);
			this.pnl_Control.Controls.Add(this.txt_Search);
			this.pnl_Control.Controls.Add(this.btn_Add);
			this.pnl_Control.Controls.Add(this.btn_Delete);
			this.pnl_Control.Controls.Add(this.btn_Update);
			this.pnl_Control.CustomizableEdges.BottomLeft = false;
			this.pnl_Control.CustomizableEdges.TopLeft = false;
			this.pnl_Control.CustomizableEdges.TopRight = false;
			this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Control.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.pnl_Control.Location = new System.Drawing.Point(0, 0);
			this.pnl_Control.Name = "pnl_Control";
			this.pnl_Control.Size = new System.Drawing.Size(1400, 129);
			this.pnl_Control.TabIndex = 59;
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
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(41, 20);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(212, 88);
			this.lbl_Title.TabIndex = 14;
			this.lbl_Title.Text = "Quản Lý Xe Buýt";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// NNM_frmBus
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1400, 800);
			this.Controls.Add(this.pnl_Control);
			this.Controls.Add(this.txt_Capacity);
			this.Controls.Add(this.dgv_Bus);
			this.Controls.Add(this.txt_LicensePlate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Brand);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Model);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Close);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "NNM_frmBus";
			this.Text = "NNM_frmBus";
			this.Load += new System.EventHandler(this.NNM_frmBus_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Bus)).EndInit();
			this.pnl_Control.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btn_Close;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Model;
        private Guna.UI2.WinForms.Guna2TextBox txt_Brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_LicensePlate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Bus;
        private Guna.UI2.WinForms.Guna2TextBox txt_Capacity;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
		private Guna.UI2.WinForms.Guna2Panel pnl_Control;
		private Guna.UI2.WinForms.Guna2Button btn_Save;
		private Guna.UI2.WinForms.Guna2Button btn_Search;
		private System.Windows.Forms.Label lbl_Title;
		private Guna.UI2.WinForms.Guna2Button btn_Add;
		private Guna.UI2.WinForms.Guna2Button btn_Delete;
		private Guna.UI2.WinForms.Guna2Button btn_Update;
	}
}