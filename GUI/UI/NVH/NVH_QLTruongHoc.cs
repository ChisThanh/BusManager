using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI.NVH
{

    public partial class NVH_QLTruongHoc : Form
    {
        private DTO_School _schoolService = new DTO_School();

        public NVH_QLTruongHoc()
        {
            InitializeComponent();
            _schoolService = new DTO_School();
            LoadSchools();
        }

       private void LoadSchools()
        {
            List<DTO.Schemas.School> schools = _schoolService.GetAllSchools();
            guna2DataGridView2.DataSource = schools;
        }
        private void NVH_QLTruongHoc_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DTO.Schemas.School school = new DTO.Schemas.School
            {
                Name = txt_schoolname.Text,
                Address = txt_schooladress.Text
            };
            _schoolService.AddSchool(school);
            LoadSchools();
        }

        private void btn_deleteschool_Click(object sender, EventArgs e)
        {
            var selectedSchool = (DTO.Schemas.School)guna2DataGridView2.CurrentRow.DataBoundItem;
            _schoolService.DeleteSchool(selectedSchool);
            LoadSchools();
        }

        private void btn_updateschool_Click(object sender, EventArgs e)
        {
            var selectedSchool = (DTO.Schemas.School)guna2DataGridView2.CurrentRow.DataBoundItem;
            selectedSchool.Name = txt_schoolname.Text;
            selectedSchool.Address = txt_schooladress.Text;
            _schoolService.UpdateSchool(selectedSchool);
            LoadSchools();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    var selectedRow = guna2DataGridView2.Rows[e.RowIndex];

                    // Ensure that the selected row has the expected cells
                    if (selectedRow.Cells["Name"] != null && selectedRow.Cells["Phone"] != null && selectedRow.Cells["Address"] != null)
                    {
                        txt_schoolname.Text = selectedRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                        txt_schoolphone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
                        txt_schooladress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain the expected columns.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving school details: {ex.Message}");
            }
        }
    }
}
