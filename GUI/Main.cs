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
    public partial class Main : Form
    {
        DTO_User users = new DTO_User();
        Frm_Login loginForm = new Frm_Login();

        public Main()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnLogout.Click += BtnLogout_Click;
            btn_Revenue.Click += Btn_Revenue_Click;
            ShowLoginForm();
        }

        private void Btn_Revenue_Click(object sender, EventArgs e)
        {
            frm_Statistical frm_Statistical = new frm_Statistical();
            frm_Statistical.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cách sử dụng các hàm
            //var check = users.Insert(new User
            //{
            //    Email = "lfda",
            //    Name = "lfd",
            //    Password = "lfd"
            //});

            //MessageBox.Show(check.ToString());

            //var user1 = users.Find("6701580f6a6c63129df334d8");
            //MessageBox.Show(user1.Name);

            //var user2 = users.Update("6701580f6a6c63129df334d8", new User
            //{
            //    Email = "lfda update1",
            //    Name = "lfd update1",
            //    Password = "lfd update1"
            //});
            //MessageBox.Show(user2.ToString());

            //var user3 = users.Delete("6701580f6a6c63129df334d8");
            //MessageBox.Show(user3.ToString());

            //var user4 = users.Find("name", "lfd");
            //if (user4 != null)
            //    MessageBox.Show(user4.Name);
            //else
            //    MessageBox.Show("User not found.");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void ShowLoginForm()
        {
            loginForm.LoginSuccess += LoginForm_LoginSuccess;
            loginForm.ShowDialog();
        }

        private void LoginForm_LoginSuccess(object sender, EventArgs e)
        {
            this.Show();
            LoadData();
            loginForm.Hide();
        }

        private void LoadData()
        {
            // Chia nhỏ công việc ra các tiểu trình
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, args) =>
            {
                // Tải dữ liệu từ cơ sở dữ liệu
                var data = users.GetAll();
                args.Result = data;
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                // Cập nhật giao diện người dùng
                guna2DataGridView1.DataSource = args.Result as List<User>;
            };

            worker.RunWorkerAsync();
        }

        private void Logout()
        {
            this.Hide();
            loginForm = new Frm_Login();
            loginForm.LoginSuccess += LoginForm_LoginSuccess;
            loginForm.ShowDialog();
        }
    }
}
