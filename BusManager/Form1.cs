using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DALUser userDAL = new DALUser();

            //var check = userDAL.Insert(new User
            //{
            //    Email = "lfda",
            //    Name = "lfd",
            //    Password = "lfd"
            //});
            //MessageBox.Show(check.ToString());

            //var user1 = userDAL.Find("66e542778cb386ad2ebde119");
            //MessageBox.Show(user1.Name);

            //var user2 = userDAL.Update("66e54fb60e771eedbf729edd", new User
            //{
            //    Email = "lfda update1",
            //    Name = "lfd update1",
            //    Password = "lfd update1"
            //});
            //MessageBox.Show(user2.ToString());

            //var user3 = userDAL.Delete("66e54fb60e771eedbf729edd");
            //MessageBox.Show(user3.ToString());

            //var user4 = userDAL.Find("name", "Thanh");
            //MessageBox.Show(user4.Name);


            var users = userDAL.GetAll();
            guna2DataGridView1.DataSource = users;


        }
    }
}
