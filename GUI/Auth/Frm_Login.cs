using DTO;
using GUI.Heplers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Auth
{
    public partial class Frm_Login : Form
    {

        private DTO_Auth _dtoAuth = new DTO_Auth();
        private string account;
        private string password;

        public delegate void LoginSuccessEventHandler(object sender, EventArgs e);
        public event LoginSuccessEventHandler LoginSuccess;

        public Frm_Login()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
            btnRegister.Click += BtnRegister_Click;
            btn_Close.Click += Btn_Close_Click;
            txtAccount.Text = "sadmin@mail.com";
            txtPassword.Text = "123";
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var frmRegister = new Frm_Register();
            frmRegister.Show();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            guna2WinProgressIndicator1.Visible = true;
            btnSubmit.Visible = false;
            guna2WinProgressIndicator1.Start();

            if (!ValidateInputs())
            {
                guna2WinProgressIndicator1.Stop();
                guna2WinProgressIndicator1.Visible = false;
                btnSubmit.Visible = true;
                return;
            }

            try
            {
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();

                var user = await _dtoAuth.LoginAsync(account, password);

                stopwatch.Stop();

                if (stopwatch.ElapsedMilliseconds < 500)
                    await Task.Delay(500);

                OnLoginSuccess(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                guna2WinProgressIndicator1.Stop();
                guna2WinProgressIndicator1.Visible = false;
                btnSubmit.Visible = true;
            }
        }

        private bool ValidateInputs()
        {
            account = txtAccount.Text.Trim();
            password = txtPassword.Text.Trim();

            return Utils.ValidateField(txtAccount, account, "Tài khoản không được để trống", errorProvider) &&
                   Utils.ValidateField(txtPassword, password, "Mật khẩu không được để trống", errorProvider);
        }


        protected virtual void OnLoginSuccess(EventArgs e)
        {
            LoginSuccess?.Invoke(this, e);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
