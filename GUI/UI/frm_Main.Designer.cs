﻿namespace GUI
{
    partial class frm_Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chuyếnĐiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trườngHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xeBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tàiXếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelMain = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1404, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// quảnLýToolStripMenuItem
			// 
			this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.chuyếnĐiToolStripMenuItem,
            this.họcSinhToolStripMenuItem,
            this.trườngHọcToolStripMenuItem,
            this.xeBusToolStripMenuItem,
            this.tàiXếToolStripMenuItem,
            this.vùngToolStripMenuItem});
			this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.quảnLýToolStripMenuItem.Text = "Quản lý";
			// 
			// thốngKêToolStripMenuItem
			// 
			this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
			this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.thốngKêToolStripMenuItem.Text = "Thống kê";
			this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
			// 
			// chuyếnĐiToolStripMenuItem
			// 
			this.chuyếnĐiToolStripMenuItem.Name = "chuyếnĐiToolStripMenuItem";
			this.chuyếnĐiToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.chuyếnĐiToolStripMenuItem.Text = "Chuyến đi";
			this.chuyếnĐiToolStripMenuItem.Click += new System.EventHandler(this.chuyếnĐiToolStripMenuItem_Click);
			// 
			// họcSinhToolStripMenuItem
			// 
			this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
			this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.họcSinhToolStripMenuItem.Text = "Học sinh";
			this.họcSinhToolStripMenuItem.Click += new System.EventHandler(this.họcSinhToolStripMenuItem_Click);
			// 
			// trườngHọcToolStripMenuItem
			// 
			this.trườngHọcToolStripMenuItem.Name = "trườngHọcToolStripMenuItem";
			this.trườngHọcToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.trườngHọcToolStripMenuItem.Text = "Trường học";
			this.trườngHọcToolStripMenuItem.Click += new System.EventHandler(this.trườngHọcToolStripMenuItem_Click);
			// 
			// xeBusToolStripMenuItem
			// 
			this.xeBusToolStripMenuItem.Name = "xeBusToolStripMenuItem";
			this.xeBusToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.xeBusToolStripMenuItem.Text = "Xe bus";
			this.xeBusToolStripMenuItem.Click += new System.EventHandler(this.xeBusToolStripMenuItem_Click);
			// 
			// tàiXếToolStripMenuItem
			// 
			this.tàiXếToolStripMenuItem.Name = "tàiXếToolStripMenuItem";
			this.tàiXếToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.tàiXếToolStripMenuItem.Text = "Tài xế";
			this.tàiXếToolStripMenuItem.Click += new System.EventHandler(this.tàiXếToolStripMenuItem_Click);
			// 
			// vùngToolStripMenuItem
			// 
			this.vùngToolStripMenuItem.Name = "vùngToolStripMenuItem";
			this.vùngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.vùngToolStripMenuItem.Text = "Vùng";
			this.vùngToolStripMenuItem.Click += new System.EventHandler(this.vùngToolStripMenuItem_Click);
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// panelMain
			// 
			this.panelMain.AutoScroll = true;
			this.panelMain.BackColor = System.Drawing.Color.White;
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMain.Location = new System.Drawing.Point(0, 24);
			this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1404, 804);
			this.panelMain.TabIndex = 4;
			// 
			// frm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1404, 831);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dịch vụ quản lý xe Bus cho học sinh";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyếnĐiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trườngHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem xeBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiXếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vùngToolStripMenuItem;
    }
}

