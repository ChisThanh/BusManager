using DTO;
using DTO.Schemas;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class NNM_frmBus : Form
    {
        private DTO_Bus _dtoBus;
        public NNM_frmBus()
        {
            InitializeComponent();
            _dtoBus = new DTO_Bus();
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadBusData()
        {
            var busList = _dtoBus.GetAll();
            dgv_Bus.DataSource = busList;
        }
        private void NNM_frmBus_Load(object sender, EventArgs e)
        {
            LoadBusData();

            txt_LicensePlate.Enabled = false;
            txt_Model.Enabled = false;
            txt_Brand.Enabled = false;
            txt_Capacity.Enabled = false;

            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_Save.Enabled = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Enable các textbox
            txt_LicensePlate.Enabled = true;
            txt_Model.Enabled = true;
            txt_Brand.Enabled = true;
            txt_Capacity.Enabled = true;

            // Clear textbox để nhập dữ liệu mới
            txt_LicensePlate.Clear();
            txt_Model.Clear();
            txt_Brand.Clear();
            txt_Capacity.Clear();

            // Chỉ bật nút Lưu
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_Save.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this bus?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedRow = dgv_Bus.SelectedRows[0];
                var id = selectedRow.Cells[0].Value.ToString();
                var deleteResult = _dtoBus.Delete(id);
                if (deleteResult)
                {
                    MessageBox.Show("Bus deleted successfully!");
                    LoadBusData();
                }
                else
                {
                    MessageBox.Show("Error deleting bus.");
                }
            }
        }

        private void dgv_Bus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgv_Bus.Rows[e.RowIndex];

                txt_LicensePlate.Text = selectedRow.Cells[1].Value.ToString();
                txt_Model.Text = selectedRow.Cells[2].Value.ToString();
                txt_Brand.Text = selectedRow.Cells[3].Value.ToString();
                txt_Capacity.Text = selectedRow.Cells[4].Value.ToString();

                // Enable các nút Xóa, Sửa, Lưu
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
                btn_Save.Enabled = true;

                // Disable các textbox vì chỉ sửa khi bấm Sửa
                txt_LicensePlate.Enabled = false;
                txt_Model.Enabled = false;
                txt_Brand.Enabled = false;
                txt_Capacity.Enabled = false;
            }
        }
        

        private void btn_Update_Click(object sender, EventArgs e)
        {
                // Enable các textbox để chỉnh sửa
                txt_LicensePlate.Enabled = true;
                txt_Model.Enabled = true;
                txt_Brand.Enabled = true;
                txt_Capacity.Enabled = true;

                // Bật nút Lưu
                btn_Save.Enabled = true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var bus = new Bus
            {
                LicensePlate = txt_LicensePlate.Text,
                Model = txt_Model.Text,
                Brand = txt_Brand.Text,
                Capacity = txt_Capacity.Text
            };

            if (dgv_Bus.SelectedRows.Count > 0 && btn_Update.Enabled)
            {
                // Cập nhật bus
                var selectedRow = dgv_Bus.SelectedRows[0];
                var id = selectedRow.Cells[0].Value.ToString();
                var result = _dtoBus.Update(id, bus);
                if (result)
                {
                    MessageBox.Show("Bus updated successfully!");
                    LoadBusData();
                }
                else
                {
                    MessageBox.Show("Error updating bus.");
                }
            }
            else
            {
                // Thêm bus mới
                var result = _dtoBus.Insert(bus);
                if (result)
                {
                    MessageBox.Show("Bus added successfully!");
                    LoadBusData();
                }
                else
                {
                    MessageBox.Show("Error adding bus.");
                }
            }

            // Sau khi lưu, disable các textbox và nút
            txt_LicensePlate.Enabled = false;
            txt_Model.Enabled = false;
            txt_Brand.Enabled = false;
            txt_Capacity.Enabled = false;

            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_Search.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Tìm kiếm bus dựa trên LicensePlate
                var result = _dtoBus.Find("LicensePlate", searchTerm);

                if (result != null)
                {
                    dgv_Bus.DataSource = new List<Bus> { result };
                    MessageBox.Show("Bus found!");
                }
                else
                {
                    MessageBox.Show("No bus found with the given License Plate.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a License Plate to search.");
            }
        }
    }
}
