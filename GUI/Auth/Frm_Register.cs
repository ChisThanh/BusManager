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
using GUI.Heplers;

namespace GUI.Auth
{
    public partial class Frm_Register : Form
    {
        private DTO_Auth _dtoAuth = new DTO_Auth();
        private string account;
        private string password;
        private string name;

        public Frm_Register()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
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

                var user = await _dtoAuth.RegisterAsync(account, name,  password);

                stopwatch.Stop();

                if (stopwatch.ElapsedMilliseconds < 500)
                    await Task.Delay(500);

                MessageBox.Show("Đăng ký thành công");

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
            name = txtName.Text.Trim();
            
            return Utils.ValidateField(txtAccount, account, "Tài khoản không được để trống", errorProvider) &&
                   Utils.ValidateField(txtPassword, password, "Mật khẩu không được để trống", errorProvider) &&
                   Utils.ValidateField(txtName, name, "Tên không được để trống", errorProvider);
        }

       
    }
}
