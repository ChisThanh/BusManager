using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Schemas;
using GUI.Auth;
using GUI.UI;

namespace GUI
{
    public partial class frm_Main : Form
    {
        Frm_Login loginForm = new Frm_Login();
        Form frmActive = null;

        public frm_Main()
        {
            InitializeComponent();
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            loginForm.LoginSuccess += LoginForm_LoginSuccess;
            loginForm.ShowDialog();
        }

        private void LoginForm_LoginSuccess(object sender, EventArgs e)
        {
            this.Show();
            loginForm.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Statistical frm_Statistical = new frm_Statistical();
            frm_Statistical.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm = new Frm_Login();
            loginForm.LoginSuccess += LoginForm_LoginSuccess;
            loginForm.ShowDialog();
        }

        public void showForm(Form form)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }
            frmActive = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void chuyếnĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NBL_FormTrip frm_Trip = new NBL_FormTrip();
            showForm(frm_Trip);
        }
    }
}
