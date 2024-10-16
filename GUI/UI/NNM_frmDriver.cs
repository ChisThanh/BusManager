using DTO;
using DTO.Schemas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI.UI
{
    public partial class NNM_frmDriver : Form
    {
        private DTO_Driver _dtoDriver;
        public NNM_frmDriver()
        {
            InitializeComponent();
            _dtoDriver = new DTO_Driver();

            dtp_DoB.Format = DateTimePickerFormat.Custom;
            dtp_DoB.CustomFormat = "yyyy-MM-dd";
            dtp_ExpiryDate.Format = DateTimePickerFormat.Custom;
            dtp_ExpiryDate.CustomFormat = "yyyy-MM-dd";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisableInputFields()
        {
            txt_Name.Enabled = false;
            cbo_Gender.Enabled = false;
            dtp_DoB.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Address.Enabled = false;
            txt_LicenseID.Enabled = false;
            txt_LicenseClass.Enabled = false;
            dtp_ExpiryDate.Enabled = false;
        }

        private void EnableInputFields()
        {
            txt_Name.Enabled = true;
            cbo_Gender.Enabled = true;
            dtp_DoB.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Address.Enabled = true;
            txt_LicenseID.Enabled = true;
            txt_LicenseClass.Enabled = true;
            dtp_ExpiryDate.Enabled = true;
        }
        private void LoadDriverData()
        {
            var driverList = _dtoDriver.GetAll();

            var displayList = driverList.Select(d => new
            {
                Id = d.Id,
                Name = d.Name,
                Gender = d.Gender,
                DoB = d.DoB.ToLocalTime().ToString("yyyy-MM-dd"),
                Phone = d.Phone,
                Address = d.Address,
                LicenseID = d.License?.ID,
                LicenseClass = string.Join(", ", d.License?.Class), // Chuyển mảng thành chuỗi
                ExpiryDate = d.License?.ExpiryDate.ToLocalTime().ToString("yyyy-MM-dd")
            }).ToList();

            dgv_Driver.DataSource = displayList;
        }
        private void NNM_frmDriver_Load(object sender, EventArgs e)
        {
            cbo_Gender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });

            DisableInputFields();
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_Save.Enabled = false;
            LoadDriverData();

            txt_LicenseID.KeyPress += new KeyPressEventHandler(txtLicenseID_KeyPress);

			dgv_Driver.ReadOnly = true;
			dgv_Driver.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Driver.RowHeadersVisible = false;
			dgv_Driver.AllowUserToAddRows = false;
			dgv_Driver.AllowUserToDeleteRows = false;
			dgv_Driver.AllowUserToOrderColumns = false;
			dgv_Driver.AllowUserToResizeColumns = false;
			dgv_Driver.AllowUserToResizeRows = false;
			dgv_Driver.ColumnHeadersHeight = 40;
		}
        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnableInputFields();

            txt_Name.Clear();
            txt_Phone.Clear();
            txt_Address.Clear();
            txt_LicenseClass.Clear();
            txt_LicenseID.Clear();

            btn_Save.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Driver.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this driver?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var selectedRow = dgv_Driver.SelectedRows[0];
                    var id = selectedRow.Cells[0].Value.ToString();
                    var deleteResult = _dtoDriver.Delete(id);
                    if (deleteResult)
                    {
                        MessageBox.Show("Deleted successfully!");
                        LoadDriverData();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            EnableInputFields();
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidatePhoneNumber(txt_Phone.Text))
            {
                MessageBox.Show("The phone number must contain exactly 10 digits and start with the digit 0.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var licenseClasses = txt_LicenseClass.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(c => c.Trim())
                                              .ToList();

            var driver = new Driver
            {
                Name = txt_Name.Text,
                Gender = cbo_Gender.SelectedItem.ToString(),
                DoB = dtp_DoB.Value.ToLocalTime(),
                Phone = txt_Phone.Text,
                Address = txt_Address.Text,
                License = new DTO.Schemas.License
                {
                    ID = txt_LicenseID.Text,
                    Class = licenseClasses,
                    ExpiryDate = dtp_ExpiryDate.Value.ToLocalTime()
                }
            };

            
            if (dgv_Driver.SelectedRows.Count > 0 && btn_Update.Enabled)
            {
                var selectedRow = dgv_Driver.SelectedRows[0];
                var id = selectedRow.Cells[0].Value.ToString();
                var result = _dtoDriver.Update(id, driver);
                if (result)
                {
                    MessageBox.Show("Update successful!");
                    LoadDriverData();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            else
            {
                var result = _dtoDriver.Insert(driver);
                if (result)
                {
                    MessageBox.Show("Driver added successfully!");
                    LoadDriverData();
                }
                else
                {
                    MessageBox.Show("Error adding driver.");
                }
            }

            DisableInputFields();
            btn_Save.Enabled = false;
        }

        private void dgv_Driver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgv_Driver.Rows[e.RowIndex];

                txt_Name.Text = selectedRow.Cells[1].Value.ToString();
                cbo_Gender.SelectedItem = selectedRow.Cells[2].Value.ToString();
                dtp_DoB.Value = DateTime.Parse(selectedRow.Cells[3].Value.ToString()).Date;
                txt_Phone.Text = selectedRow.Cells[4].Value.ToString();
                txt_Address.Text = selectedRow.Cells[5].Value.ToString();
                txt_LicenseID.Text = selectedRow.Cells[6].Value.ToString();
                txt_LicenseClass.Text = selectedRow.Cells[7].Value.ToString();
                dtp_ExpiryDate.Value = DateTime.Parse(selectedRow.Cells[8].Value.ToString()).Date;

                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Search.Text.Trim(); 

            if (!string.IsNullOrEmpty(searchValue))
            {
                var driverList = _dtoDriver.GetAll(); 

                var matchedDrivers = driverList.Where(d => d.Name.ToLower().Contains(searchValue)).ToList();

                if (matchedDrivers.Any()) 
                {
                    dgv_Driver.DataSource = matchedDrivers; 
                }
                else
                {
                    MessageBox.Show("No driver found with the given name.");
                    LoadDriverData();
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
