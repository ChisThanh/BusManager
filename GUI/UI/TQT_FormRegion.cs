using DTO;
using DTO.Schemas;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI.UI
{
    public partial class TQT_FormRegion : Form
    {
        DTO_Region dtoRegion = new DTO_Region();
        DTO_Student dtoStudent = new DTO_Student();
        private Dictionary<string, DTO.Schemas.Region> regionDictionary = new Dictionary<string, DTO.Schemas.Region>(); // dùng để lưu đối tượng thôi

        public TQT_FormRegion()
        {
            InitializeComponent();
            btn_Close.Click += BtnClose_Click;
            cbb_Region.SelectedIndexChanged += Cbb_Region_SelectedIndexChanged;
            btn_Insert.Click += Btn_Insert_Click;
            btn_Update.Click += Btn_Update_Click;
            btn_Delete.Click += Btn_Delete_Click;
            showData_cbbNameRegion();

			dgv_Students.ReadOnly = true;
			dgv_Students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Students.RowHeadersVisible = false;
			dgv_Students.AllowUserToAddRows = false;
			dgv_Students.AllowUserToDeleteRows = false;
			dgv_Students.AllowUserToOrderColumns = false;
			dgv_Students.AllowUserToResizeColumns = false;
			dgv_Students.AllowUserToResizeRows = false;
			dgv_Students.ColumnHeadersHeight = 40;
		}

        private async void Btn_Delete_Click(object sender, EventArgs e)
        {
            // Lấy tên quận đã chọn từ ComboBox
            string selectedName = cbb_Region.SelectedItem.ToString();

            // Tìm đối tượng Region tương ứng trong dictionary
            if (regionDictionary.TryGetValue(selectedName, out DTO.Schemas.Region selectedRegion))
            {
                // Hỏi ý kiến người dùng trước khi xóa
                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa quận '{selectedRegion.Name}'?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa
                        await dtoRegion.DeleteRegionAsync(selectedRegion.Id);
                        MessageBox.Show("Xóa quận thành công!");

                        // Cập nhật ComboBox
                        await showData_cbbNameRegion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa quận: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quận cần xóa.");
            }
        }


        private async void Btn_Update_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string name = txt_NameRegion.Text.Trim();
            string description = txt_Description.Text.Trim();

            // Kiểm tra xem tên có rỗng không
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên quận không được để trống.");
                return;
            }

            // Lấy quận đã chọn từ ComboBox
            if (cbb_Region.SelectedItem != null)
            {
                string selectedName = cbb_Region.SelectedItem.ToString();

                // Kiểm tra xem tên mới có tồn tại trong ComboBox hay không
                if (cbb_Region.Items.Cast<string>().Any(item => item.Equals(name, StringComparison.OrdinalIgnoreCase) && item != selectedName))
                {
                    MessageBox.Show("Tên quận đã tồn tại trong danh sách.");
                    return;
                }

                // Kiểm tra và cập nhật quận đã chọn
                if (regionDictionary.TryGetValue(selectedName, out DTO.Schemas.Region selectedRegion))
                {
                    selectedRegion.Name = name;
                    selectedRegion.Description = description;

                    try
                    {
                        if (!cbb_Region.Items.Cast<string>().Any(item => item.Equals(name, StringComparison.OrdinalIgnoreCase)))
                        {
                            // Nếu không tồn tại, gọi hàm Insert
                            DTO.Schemas.Region newRegion = new DTO.Schemas.Region
                            {
                                Id = ObjectId.GenerateNewId(),
                                Name = name,
                                Description = description,
                                Students = new List<ObjectId>()
                            };

                            try
                            {
                                await dtoRegion.InsertRegionAsync(newRegion);
                                MessageBox.Show("Thêm quận thành công!");

                                // Cập nhật lại ComboBox
                                await showData_cbbNameRegion();

                                // Làm sạch các TextBox
                                txt_NameRegion.Clear();
                                txt_Description.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi thêm quận: {ex.Message}");
                            }
                        }
                        else
                        {
                            await dtoRegion.UpdateRegionAsync(selectedRegion);
                            MessageBox.Show("Cập nhật quận thành công!");

                            // Cập nhật lại ComboBox
                            await showData_cbbNameRegion();

                            // Làm sạch các TextBox
                            txt_NameRegion.Clear();
                            txt_Description.Clear();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật quận: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy quận đã chọn.");
                }
            }

        }





        private async void Btn_Insert_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string name = txt_NameRegion.Text.Trim();
            string description = txt_Description.Text.Trim();

            // Kiểm tra xem tên có rỗng không
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên quận không được để trống.");
                return;
            }

            // Kiểm tra xem tên quận đã có trong ComboBox chưa
            if (cbb_Region.Items.Cast<string>().Any(item => item.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên quận đã tồn tại trong danh sách.");
                return;
            }

            // Tạo đối tượng Region mới
            DTO.Schemas.Region newRegion = new DTO.Schemas.Region
            {
                Id = ObjectId.GenerateNewId(),
                Name = name,
                Description = description,
                Students = new List<ObjectId>()
            };

            try
            {
                // Lưu đối tượng Region mới vào cơ sở dữ liệu
                await dtoRegion.InsertRegionAsync(newRegion);
                MessageBox.Show("Thêm quận thành công!");

                // Cập nhật ComboBox
                await showData_cbbNameRegion();

                // Làm sạch các TextBox
                txt_NameRegion.Clear();
                txt_Description.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm quận: {ex.Message}");
            }
        }



        private async void Cbb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên quận được chọn từ ComboBox
            string selectedName = cbb_Region.SelectedItem.ToString();

            // Tìm đối tượng Region tương ứng trong dictionary
            if (regionDictionary.TryGetValue(selectedName, out DTO.Schemas.Region selectedRegion))
            {
                // Gán Name và Description của Region vào các TextBox
                txt_NameRegion.Text = selectedRegion.Name;
                txt_Description.Text = selectedRegion.Description;

                // Gọi hàm để tải danh sách sinh viên theo tên quận
                await LoadStudentsByRegionAsync(selectedRegion.Name);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho quận đã chọn.");
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async Task showData_cbbNameRegion()
        {
            try
            {
                // Lấy danh sách các đối tượng Region từ DTO
                var regions = await dtoRegion.GetRegionsAsync();

                if (regions == null || !regions.Any())
                {
                    MessageBox.Show("Không có dữ liệu quận.");
                    return;
                }

                regions = regions.OrderBy(r => r.Name).ToList();

                cbb_Region.Items.Clear();
                regionDictionary.Clear();

                // Thêm các tên quận vào ComboBox và lưu vào dictionary
                foreach (var region in regions)
                {
                    cbb_Region.Items.Add(region.Name);

                    // Lưu đối tượng Region vào dictionary với key là tên
                    regionDictionary[region.Name] = region;
                }

                if (cbb_Region.Items.Count > 0)
                {
                    cbb_Region.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu quận: {ex.Message}\n{ex.StackTrace}");
            }
        }


        private async Task LoadStudentsByRegionAsync(string regionName)
        {
            try
            {
                // Lấy danh sách sinh viên theo khu vực
                List<Student> students = await dtoStudent.GetStudentsByRegionAsync(regionName);

                // Kiểm tra xem có dữ liệu không
                if (students == null || !students.Any())
                {
                    MessageBox.Show("Không có sinh viên nào trong khu vực này.");
                    dgv_Students.DataSource = null; // Xóa dữ liệu trong DataGridView
                    return;
                }

                // Gán dữ liệu vào DataGridView
                var studentData = students.Select(s => new
                {
                    Tên = s.Name,
                    Giới_tính = s.Gender,
                    Ngày_sinh = s.DoB.ToShortDateString(),
                    Số_điện_thoại = s.Phone,
                    Địa_chỉ = s.Address,
                    Lịch_trình = string.Join(", ", s.Schedules)
                }).ToList();

                dgv_Students.DataSource = studentData;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sinh viên: {ex.Message}");
            }
        }




    }
}
