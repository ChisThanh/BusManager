using DTO;
using DTO.Schemas;
using GUI.UI.NVH;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DTO.DTO_School;


namespace GUI.UI
{
    public partial class NVH_QLHocSinh : Form
    {
        private DTO_Student _studentService = new DTO_Student();
        private DTO_School _schoolService;
        private DTO_Student _scheduleService;
        private object txt_schoolName;
        private object txt_scheduleName;    
        
        public NVH_QLHocSinh()
        {
            InitializeComponent();
            _studentService = new DTO_Student();
            LoadStudents();
        }
        private void ConfigureDataGridView(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeight = 40;
        }
        private void LoadStudents()
        {
            List<DTO.Schemas.Student> students = _studentService.GetAllStudents();
            guna2DataGridView1.DataSource = students;
           
            ConfigureDataGridView(guna2DataGridView1);
            ConfigureDataGridView(guna2DataGridView2);
        }
        //private void LoadSchools()
        //{
        //    var schools = _schoolService.GetAllSchools();
        //    cbb_school.DataSource = schools;
        //    cbb_school.DisplayMember = "Name"; // Tên trường sẽ hiển thị
        //    cbb_school.ValueMember = "Id"; // Giá trị của trường (Id) sẽ được lưu
        //}
        


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                    // Lấy ID của học sinh được chọn
                    var studentId = (ObjectId)selectedRow.Cells["Id"].Value;

                    // Hiển thị thông tin học sinh
                    txt_name.Text = selectedRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                    txt_gender.Text = selectedRow.Cells["Gender"].Value?.ToString() ?? string.Empty;
                    dtp_dob.Value = DateTime.Parse(selectedRow.Cells["DoB"].Value?.ToString() ?? DateTime.Now.ToString());
                    txt_phone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
                    txt_adress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                    var studentSchedules = GetStudentSchedules(studentId); // Lấy danh sách lịch của học sinh
                    LoadSchedules(studentSchedules);


                }
            }
            catch (Exception ex)
            {
                
            }
        }
        //private async Task LoadStudentsIntoDataGridView()
        //{
        //    try
        //    {
        //        var dtoSchool = new DTO_School();
        //        var dtoStudent = new DTO_Student(); // Giả định bạn có một lớp DTO cho học sinh
        //        var students = await dtoStudent.GetAllStudentsAsync(); // Phương thức lấy danh sách học sinh

        //        if (students == null || !students.Any())
        //        {
        //            MessageBox.Show("Không có dữ liệu học sinh.");
        //            return;
        //        }

        //        guna2DataGridView1.Rows.Clear();

               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải dữ liệu học sinh: {ex.Message}");
        //    }
        //}
        //private async Task NVH_QLHocSinh_LoadAsync(object sender, EventArgs e)
        //{
        //    await showData_cbbSchool();
        //}

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {                   
                    var selectedRow = guna2DataGridView1.SelectedRows[0]; 
                    var selectedStudent = (DTO.Schemas.Student)selectedRow.DataBoundItem;            
                        _studentService.DeleteStudent(selectedStudent);
                        LoadStudents();                    
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectedStudent = (DTO.Schemas.Student)guna2DataGridView1.CurrentRow.DataBoundItem;
            selectedStudent.Name = txt_name.Text;
            selectedStudent.DoB = dtp_dob.Value;
            //selectedStudent.SchoolId = new ObjectId(cbb_school.SelectedValue.ToString());
            _studentService.UpdateStudent(selectedStudent);
            LoadStudents();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new DTO.Schemas.Student
                {
                    Name = txt_name.Text,
                    DoB = dtp_dob.Value,
                    Gender = txt_gender.Text,
                    Phone = txt_phone.Text,
                    Address = txt_adress.Text,
                    //SchoolId = cbb_school.SelectedValue != null ? new ObjectId(cbb_school.SelectedValue.ToString()) : ObjectId.Empty
                };

                _studentService.AddStudent(newStudent);
                LoadStudents(); // Refresh student list
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
        }

        //private void cbb_school_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Kiểm tra nếu không có mục nào được chọn trong ComboBox
        //        if (cbb_school.SelectedItem == null)
        //        {
        //            return;
        //        }

        //        // Lấy tên trường được chọn từ ComboBox
        //        string selectedSchoolName = cbb_school.SelectedItem.ToString();

        //        // Hiển thị tên trường được chọn
        //        MessageBox.Show($"Bạn đã chọn: {selectedSchoolName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi chọn trường: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}
        //private async Task showData_cbbSchool()
        //{
        //    try
        //    {
        //        // Tạo đối tượng DTO_School
        //        var dtoSchool = new DTO_School();

        //        // Lấy danh sách các trường học
        //        var schools = await Task.Run(() => dtoSchool.GetAllSchools());

        //        if (schools == null || !schools.Any())
        //        {
        //            MessageBox.Show("Không có dữ liệu trường học.");
        //            return;
        //        }

        //        // Sắp xếp theo tên trường học
        //        schools = schools.OrderBy(s => s.Name).ToList();

        //        // Xóa dữ liệu cũ trên ComboBox
        //        cbb_school.Items.Clear();

        //        // Thêm tên trường vào ComboBox
        //        foreach (var school in schools)
        //        {
        //            cbb_school.Items.Add(school.Name); // Chỉ thêm tên trường
        //        }

        //        // Chọn mục đầu tiên nếu có dữ liệu
        //        if (cbb_school.Items.Count > 0)
        //        {
        //            cbb_school.SelectedIndex = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải dữ liệu trường học: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}
        private void LoadSchedules(List<string> schedules)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Schedule"); // Tạo cột cho lịch học

            // Thêm từng lịch vào DataTable
            foreach (var schedule in schedules)
            {
                dt.Rows.Add(schedule);
            }

            guna2DataGridView2.DataSource = dt;
        }
        private List<string> GetStudentSchedules(ObjectId studentId)
        {
            var student = _studentService.GetStudentById(studentId); // Lấy học sinh từ DB

            // Kiểm tra nếu học sinh tồn tại
            if (student != null && student.Schedules != null)
            {
                return student.Schedules; // Trả về danh sách lịch học
            }

            return new List<string>();
        }







        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void NVH_QLHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                    var studentId = (ObjectId)selectedRow.Cells["Id"].Value;

                    // Hiển thị thông tin học sinh
                    txt_name.Text = selectedRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                    txt_gender.Text = selectedRow.Cells["Gender"].Value?.ToString() ?? string.Empty;
                    dtp_dob.Value = DateTime.Parse(selectedRow.Cells["DoB"].Value?.ToString() ?? DateTime.Now.ToString());
                    txt_phone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
                    txt_adress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;

                    // Tải lịch cho học sinh đã chọn
                    var studentSchedules = GetStudentSchedules(studentId); // Đảm bảo phương thức này trả về danh sách lịch hợp lệ
                    LoadSchedules(studentSchedules); // Gọi phương thức để tải lịch
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}   