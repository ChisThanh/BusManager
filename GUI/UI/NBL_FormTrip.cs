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
using GUI.Components;
using DTO.DAL;
using MongoDB.Bson;

namespace GUI.UI
{
	public partial class NBL_FormTrip : Form
	{ 
		private NBL_DAL dal = new NBL_DAL();

		private NBL_ComponentTrip last_clicked_trip;
		private string last_clicked_id;

		private List<Student> selected_students;

		public NBL_FormTrip()
		{
			InitializeComponent();

			Load += NBL_FormTrip_Load;
			dtp_Date.ValueChanged += Dtp_Date_ValueChanged;
			cbx_Bus.SelectedIndexChanged += Cbx_Bus_SelectedIndexChanged;
			cbx_School.SelectedIndexChanged += Cbx_School_SelectedIndexChanged;
			cbx_Region.SelectedIndexChanged += Cbx_Region_SelectedIndexChanged;
			//dgv_Student.DataSourceChanged += Dgv_Student_DataSourceChanged;
			btn_Insert.Click += Btn_Insert_Click;
			btn_Delete.Click += Btn_Delete_Click;
			btn_Update.Click += Btn_Update_Click;
			btn_Cancel.Click += Btn_Cancel_Click;
			btn_Filter.Click += Btn_Filter_Click;
			btn_Auto.Click += Btn_Auto_Click;
			btn_Clear.Click += Btn_Clear_Click;
			btn_Add.Click += Btn_Add_Click;
		}

		private void Btn_Add_Click(object sender, EventArgs e)
		{
			var id = cbx_Student.SelectedValue;

			if (id != null)
			{
				var student = dal.getStudentById(ObjectId.Parse(id.ToString()));

				if (student != null)
				{
					if (!selected_students.Any(s => s.Id == student.Id))
					{
						selected_students.Add(student);

						dgv_Student.DataSource = null;
						dgv_Student.DataSource = selected_students;
					}
					else
					{
						MessageBox.Show("Học sinh đã được thêm vào", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Không tìm thấy học sinh", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Chưa chọn học sinh", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void NBL_FormTrip_Load(object sender, EventArgs e)
		{ 
			loadTrips(dal.getTripsWithDetails());
			loadBuses();
			loadDrivers();
			loadSchools();
			loadRegions();
			loadStudents();
			loadStatus();

			dgv_Student.ReadOnly = true;
			dgv_Student.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Student.RowHeadersVisible = false;
			dgv_Student.AllowUserToAddRows = false;
			dgv_Student.AllowUserToDeleteRows = false;
			dgv_Student.AllowUserToOrderColumns = false;
			dgv_Student.AllowUserToResizeColumns = false;
			dgv_Student.AllowUserToResizeRows = false;
			dgv_Student.ColumnHeadersHeight = 40;

			tbx_Capacity.Enabled = false;
			tbx_Quantity.Enabled = false;
			tbx_Price.Enabled = false;

			//selected_students = new List<Student>();
			//dgv_Student.DataSource = selected_students;
			setupDataGridView();

			reset();
			hideLoading();
		}
		
		private void setupDataGridView()
		{
			dgv_Student.Columns.Clear();

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Id",
				HeaderText = "Mã Số Sinh Viên",
				DataPropertyName = "Id",
				ReadOnly = true,
				Visible = false
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Name",
				HeaderText = "Tên Sinh Viên",
				DataPropertyName = "Name",
				ReadOnly = true,
				Visible = true,
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Gender",
				HeaderText = "Giới Tính",
				DataPropertyName = "Gender",
				ReadOnly = true,
				Visible = true,
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "DoB",
				HeaderText = "Ngày Sinh",
				DataPropertyName = "DoB",
				DefaultCellStyle = new DataGridViewCellStyle { Format = "d" },
				ReadOnly = true,
				Visible = false
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Phone",
				HeaderText = "Điện Thoại",
				DataPropertyName = "Phone",
				ReadOnly = true,
				Visible = false
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "Address",
				HeaderText = "Địa Chỉ",
				DataPropertyName = "Address",
				ReadOnly = true,
				Visible = false
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "School",
				HeaderText = "Trường Học",
				DataPropertyName = "School",
				ReadOnly = true,
				Visible = false
			});

			dgv_Student.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "SchoolObj",
				HeaderText = "Đối Tượng",
				DataPropertyName = "SchoolObj",
				ReadOnly = true,
				Visible = false
			});
		}

		private void Btn_Insert_Click(object sender, EventArgs e)
		{
			DateTime date = dtp_Date.Value;
			if(date.Date < DateTime.Now.Date)
			{
				MessageBox.Show("Không thể tạo chuyến đi trước ngày hiện tại", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cbx_Bus.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn xe buýt", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string bus = cbx_Bus.SelectedValue.ToString();

			if (cbx_Driver.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn tài xế", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string driver = cbx_Driver.SelectedValue.ToString();

			if (cbx_School.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn trường học", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string school = cbx_School.SelectedValue.ToString();

			if (cbx_Region.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn khu vực", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string region = cbx_Region.SelectedValue.ToString();

			double price = double.Parse(tbx_Price.Text);

			List<ObjectId> students = new List<ObjectId>();
			foreach (DataGridViewRow row in dgv_Student.Rows)
			{
				students.Add(ObjectId.Parse(row.Cells["Id"].Value.ToString()));
			}

			if (students.Count == 0)
			{
				MessageBox.Show("Chưa có sinh viên nào trong xe", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Trip trip = new Trip();
			trip.Date = date;
			trip.Bus = ObjectId.Parse(bus);
			trip.Driver = ObjectId.Parse(driver);
			trip.Region = ObjectId.Parse(region);
			trip.School = ObjectId.Parse(school);
			trip.Price = price;
			trip.Students = students;
			trip.Status = "active";

			int isInserted = dal.insertTrip(trip);

			if (isInserted == 1)
			{
				MessageBox.Show("Tạo chuyến đi thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				reloadTrips(dal.getTripsWithDetails());
				reset();
			}
			else if (isInserted == -2)
			{
				MessageBox.Show("Xe buýt không thể chạy hai lần một ngày", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (isInserted == -1)
			{
				MessageBox.Show("Tài xế không thể lái hai lần một ngày", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_Delete_Click(object sender, EventArgs e)
		{
			if (last_clicked_id == null)
			{
				MessageBox.Show("Hãy chọn chuyến đi đã hủy hay đã hoàn thành", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
			{
				return;
			}

			bool isDeleted = dal.deleteTrip(ObjectId.Parse(last_clicked_id));

			if (isDeleted)
			{
				MessageBox.Show("Xóa chuyến đi thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				reloadTrips(dal.getTripsWithDetails());
				reset();
			}
			else
			{
				MessageBox.Show("Không tìm thấy chuyến đi nào", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void Btn_Update_Click(object sender, EventArgs e)
		{
			if (last_clicked_id == null)
			{
				MessageBox.Show("Hãy chọn chuyến đi đã lên kế hoạch", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Trip trip = dal.findTripById(ObjectId.Parse(last_clicked_id));

			if (dtp_Date.Value.Date >= DateTime.Now.Date)
			{
				trip.Date = dtp_Date.Value;
			}

			if (cbx_Bus.SelectedValue != null)
			{
				trip.Bus = ObjectId.Parse(cbx_Bus.SelectedValue.ToString());
			}

			if (cbx_Driver.SelectedValue != null)
			{
				trip.Driver = ObjectId.Parse(cbx_Driver.SelectedValue.ToString());
			}

			if (cbx_School.SelectedValue != null)
			{
				trip.School = ObjectId.Parse(cbx_School.SelectedValue.ToString());
			}

			if (cbx_Region.SelectedValue != null)
			{
				trip.Region = ObjectId.Parse(cbx_Region.SelectedValue.ToString());
			}

			trip.Price = double.Parse(tbx_Price.Text);

			List<ObjectId> students = new List<ObjectId>();
			foreach (DataGridViewRow row in dgv_Student.Rows)
			{
				students.Add(ObjectId.Parse(row.Cells["Id"].Value.ToString()));
			}

			if (students.Count != 0)
			{
				trip.Students = students;
			}

			int isUpdated = dal.updateTrip(trip);

			if (isUpdated == 1)
			{
				MessageBox.Show("Cập nhật chuyến đi thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				reloadTrips(dal.getTripsWithDetails());
				reset();
			}
			else if (isUpdated == -2)
			{
				MessageBox.Show("Xe buýt không thể chạy hai lần một ngày", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (isUpdated == -1)
			{
				MessageBox.Show("Tài xế không thể lái hai lần một ngày", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(isUpdated == 0)
			{
				MessageBox.Show("Không tìm thấy chuyến đi nào", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			if (last_clicked_id == null)
			{
				MessageBox.Show("Hãy chọn chuyến đi đã lên kế hoạch", "Lỗi Logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			bool isCancelled = dal.cancelTrip(ObjectId.Parse(last_clicked_id));

			if (isCancelled)
			{
				MessageBox.Show("Hủy chuyến đi thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				reloadTrips(dal.getTripsWithDetails());
				reset();
			}
			else
			{
				MessageBox.Show("Không tìm thấy chuyến đi nào", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void Btn_Filter_Click(object sender, EventArgs e)
		{
			if (rbn_Date.Checked)
			{
				reloadTrips(dal.getTripsFilteredByDate(dtp_Date.Value));
			}
			else if (rbn_Bus.Checked || rbn_Capacity.Checked)
			{
				if (cbx_Bus.SelectedValue != null)
				{
					reloadTrips(dal.getTripsFilteredByBus(cbx_Bus.SelectedValue.ToString()));
				}
				else
				{
					MessageBox.Show("Chưa chọn xe buýt", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (rbn_Driver.Checked)
			{
				if (cbx_Driver.SelectedValue != null)
				{
					reloadTrips(dal.getTripsFilteredByDriver(cbx_Driver.SelectedValue.ToString()));
				}
				else
				{
					MessageBox.Show("Chưa chọn tài xế", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (rbn_School.Checked)
			{
				if (cbx_School.SelectedValue != null)
				{
					reloadTrips(dal.getTripsFilteredBySchool(cbx_School.SelectedValue.ToString()));
				}
				else
				{
					MessageBox.Show("Chưa chọn trường học", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (rbn_Region.Checked)
			{
				if (cbx_Region.SelectedValue != null)
				{
					reloadTrips(dal.getTripsFilteredByRegion(cbx_Region.SelectedValue.ToString()));
				}
				else
				{
					MessageBox.Show("Chưa chọn vùng", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (rbn_Price.Checked)
			{
				reloadTrips(dal.getTripsFilteredByPrice(0, double.Parse(tbx_Price.Text)));
			}
			else if (rbn_Quantity.Checked)
			{
				reloadTrips(dal.getTripsFilteredByNumberOfStudents(0, int.Parse(tbx_Quantity.Text)));
			}
			else if (rbn_Status.Checked)
			{
				reloadTrips(dal.getTripsFilteredByStatus(cbx_Status.Text));
			}
			else
			{
				MessageBox.Show("Chưa chọn loại lọc", "Lỗi Thực Hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_Auto_Click(object sender, EventArgs e)
		{
			if (cbx_Region.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn khu vực", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string region = cbx_Region.SelectedValue.ToString();

			if (cbx_School.SelectedValue == null)
			{
				MessageBox.Show("Chưa chọn trường học", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string school = cbx_School.SelectedValue.ToString();

			if (tbx_Capacity.Text == "0" || tbx_Capacity.Text == null)
			{
				MessageBox.Show("Chưa chọn xe buýt", "Lỗi Giá Trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			List<Student> students = dal.autoAddStudents(region, school, int.Parse(tbx_Capacity.Text), dtp_Date.Value);

			if (students == null || students.Count == 0)
			{
				MessageBox.Show("Không có sinh viên nào trong vùng hay đã được xếp lịch hết", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			//selected_students = students;
			//dgv_Student.DataSource = null;
			//dgv_Student.DataSource = selected_students;

			dgv_Student.DataSource = students;

			tbx_Quantity.Text = dgv_Student.Rows.Count.ToString();
			tbx_Price.Text = (dgv_Student.Rows.Count * 2000 + int.Parse(tbx_Capacity.Text) * 5000 + 250000).ToString();
		}

		private void Dtp_Date_ValueChanged(object sender, EventArgs e)
		{
			//List<Bus> buses = dal.getBusesBasedOnDate(dtp_Date.Value);
			//List<Driver> drivers = dal.getDriversBasedOnDate(dtp_Date.Value);

			//cbx_Bus.DataSource = buses;
			//cbx_Bus.ValueMember = "ID";
			//cbx_Bus.DisplayMember = "LicensePlate";

			//cbx_Driver.DataSource = drivers;
			//cbx_Driver.ValueMember = "ID";
			//cbx_Driver.DisplayMember = "Name";

			autoloadStudents();
		}

		private void Cbx_Bus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_Bus.SelectedIndex != -1)
			{				
				if(!ObjectId.TryParse(cbx_Bus.SelectedValue.ToString(), out ObjectId id))
				{
					return;
				}

				Bus bus = dal.findBusById(cbx_Bus.SelectedValue.ToString());

				tbx_Capacity.Text = bus.Capacity.ToString(); 
				tbx_Quantity.Text = "0";
			}
		}

		private void Cbx_School_SelectedIndexChanged(object sender, EventArgs e)
		{
			autoloadStudents();
		}

		private void Cbx_Region_SelectedIndexChanged(object sender, EventArgs e)
		{
			autoloadStudents();
		}

		private void autoloadStudents()
		{
			if (cbx_School.SelectedIndex != -1 && cbx_Region.SelectedIndex != -1)
			{
				if (!ObjectId.TryParse(cbx_School.SelectedValue.ToString(), out ObjectId sid))
				{
					return;
				}

				if (!ObjectId.TryParse(cbx_Region.SelectedValue.ToString(), out ObjectId rid))
				{
					return;
				}

				List<Student> students = dal.autoAddStudents(cbx_Region.SelectedValue.ToString(), cbx_School.SelectedValue.ToString(), 9999, dtp_Date.Value);

				if (students == null)
				{
					return;
				}

				cbx_Student.DataSource = students;
				cbx_Student.ValueMember = "ID";
				cbx_Student.DisplayMember = "Name";

				cbx_Student.SelectedIndex = -1;
				cbx_Student.SelectedIndex = -1;
			}
		}

		private async void reloadTrips(List<Trip> trips)
		{
			showLoading();

			await Task.Delay(2000);

			foreach (Control control in pnl_Trips.Controls.OfType<NBL_ComponentTrip>().ToList())
			{
				pnl_Trips.Controls.Remove(control);
			}

			reset();
			loadTrips(trips);
			hideLoading();
		}

		private void loadTrips(List<Trip> trips)
		{
			int top_margin = 10;
			int left_margin = 10;
			int component_width = 300;
			int component_height = 100;
			int component_per_row = 2;

			int initial_top = 10;
			int initial_left = 10;

			for (int i = 0; i < trips.Count; i = i + 1)
			{
				Trip trip = trips[i];

				NBL_ComponentTrip trip_component = new NBL_ComponentTrip(trip);

				int row = i / component_per_row;
				int column = i % component_per_row;

				trip_component.Top = initial_top + (row * (component_height + top_margin));
				trip_component.Left = initial_left + (column * (component_width + left_margin));

				trip_component.clicked += Trip_Component_Click;

				pnl_Trips.Controls.Add(trip_component);
			}
		}

		private void Trip_Component_Click(object sender, EventArgs e)
		{
			var component = sender as NBL_ComponentTrip;

			if(last_clicked_trip != null && last_clicked_trip != component)
			{
				last_clicked_trip.HideRibbon();
				last_clicked_id = null;
			}

			if (component != null)
			{
				Trip trip = component.TripVariable;

				dtp_Date.Value = trip.Date;
				cbx_Bus.SelectedValue = trip.Bus;
				cbx_Driver.SelectedValue = trip.Driver;
				cbx_School.SelectedValue = trip.School;
				cbx_Region.SelectedValue = trip.Region;

				//selected_students.Clear();
				//selected_students = trip.StudentsObj;
				//dgv_Student.DataSource = null;
				//dgv_Student.DataSource = selected_students;

				dgv_Student.DataSource = trip.StudentsObj;

				tbx_Quantity.Text = dgv_Student.Rows.Count.ToString();

				if (trip.Status == "active")
				{
					if (DateTime.Now.Date < trip.Date.Date)
					{
						cbx_Status.SelectedItem = new KeyValuePair<string, string>("Lên Kế Hoạch", "active");
						enableControls();
					}
					else if (DateTime.Now.Date > trip.Date.Date)
					{
						cbx_Status.SelectedItem = new KeyValuePair<string, string>("Hoàn Thành", "active");
						enableControlsFC();
					}
					else
					{
						cbx_Status.SelectedItem = new KeyValuePair<string, string>("Đang Chạy", "active");
						disableControls();
					}
				}
				else
				{
					cbx_Status.SelectedItem = new KeyValuePair<string, string>("Đã Hủy", "cancelled");
					enableControlsFC();
				}

				last_clicked_trip = component;
				last_clicked_id = trip.Id.ToString();
			}
		}

		private void loadBuses()
		{
			List<Bus> buses = dal.getBuses();

			cbx_Bus.DataSource = buses;
			cbx_Bus.ValueMember = "ID";
			cbx_Bus.DisplayMember = "LicensePlate";
		}

		private void loadDrivers()
		{
			List<Driver> drivers = dal.getDrivers();

			cbx_Driver.DataSource = drivers;
			cbx_Driver.ValueMember = "ID";
			cbx_Driver.DisplayMember = "Name";
		}

		private void loadSchools()
		{
			List<School> schools = dal.getSchools();

			cbx_School.DataSource = schools;
			cbx_School.ValueMember = "ID";
			cbx_School.DisplayMember = "Name";
		}

		private void loadRegions()
		{
			List<DTO.Schemas.Region> regions = dal.getRegions();

			cbx_Region.DataSource = regions;
			cbx_Region.ValueMember = "ID";
			cbx_Region.DisplayMember = "Name";
		}

		private void loadStudents()
		{
			List<Student> students = dal.getStudents();

			cbx_Student.DataSource = students;
			cbx_Student.ValueMember = "ID";
			cbx_Student.DisplayMember = "Name";
		}

		private void loadStatus()
		{
			var statusItems = new Dictionary<string, string>
			{
				{ "Lên Kế Hoạch", "active" },
				{ "Đang Chạy", "active" },
				{ "Hoàn Thành", "active" },
				{ "Đã Hủy", "cancelled" }
			};

			cbx_Status.DisplayMember = "Key";
			cbx_Status.ValueMember = "Value";
			cbx_Status.DataSource = new BindingSource(statusItems, null);
		}

		private void Dgv_Student_DataSourceChanged(object sender, EventArgs e)
		{
			//if(dgv_Student.DataSource == null)
			//{
			//	return;
			//}

			//foreach (DataGridViewColumn column in dgv_Student.Columns)
			//{
			//	column.Visible = false;
			//}

			dgv_Student.Columns["Name"].Visible = true;
			dgv_Student.Columns["Name"].HeaderText = "Tên Học Sinh";
			dgv_Student.Columns["Gender"].Visible = true;
			dgv_Student.Columns["Gender"].HeaderText = "Giới Tính";
		}

		private void Btn_Clear_Click(object sender, EventArgs e)
		{
			reset();
			enableControls();
			uncheckRadio();
		}

		private void reset()
		{
			dtp_Date.Value = DateTime.Now;
			cbx_Bus.SelectedIndex = -1;
			cbx_Driver.SelectedIndex = -1;
			cbx_School.SelectedIndex = -1;
			cbx_Region.SelectedIndex = -1;
			cbx_Student.SelectedIndex = -1;
			cbx_Status.SelectedIndex = -1;
			cbx_Bus.SelectedIndex = -1;
			cbx_Driver.SelectedIndex = -1;
			cbx_School.SelectedIndex = -1;
			cbx_Region.SelectedIndex = -1;
			cbx_Student.SelectedIndex = -1;
			cbx_Status.SelectedIndex = -1;
			tbx_Capacity.Text = "0";
			tbx_Quantity.Text = "0";
			tbx_Price.Text = "0";
			//selected_students.Clear();
			dgv_Student.DataSource = null;

			if (last_clicked_trip != null)
			{
				last_clicked_trip.HideRibbon();
				last_clicked_id = null;
			}
		}

		private void enableControls()
		{
			btn_Add.Enabled = true;
			btn_Remove.Enabled = true;
			btn_Auto.Enabled = true;
			btn_Delete.Enabled = true;
			btn_Update.Enabled = true;
			btn_Cancel.Enabled = true;
		}

		private void enableControlsFC()
		{
			btn_Add.Enabled = false;
			btn_Remove.Enabled = false;
			btn_Auto.Enabled = false;
			btn_Delete.Enabled = true;
			btn_Update.Enabled = false;
			btn_Cancel.Enabled = false;
		}

		private void disableControls()
		{
			btn_Add.Enabled = false;
			btn_Remove.Enabled = false;
			btn_Auto.Enabled = false;
			btn_Delete.Enabled = false;
			btn_Update.Enabled = false;
			btn_Cancel.Enabled = false;
		}

		private void uncheckRadio()
		{
			rbn_Bus.Checked = false;
			rbn_Driver.Checked = false;
			rbn_School.Checked = false;
			rbn_Region.Checked = false;
			rbn_Price.Checked = false;
			rbn_Date.Checked = false;
			rbn_Quantity.Checked = false;
			rbn_Status.Checked = false;
			rbn_Capacity.Checked = false;
		}

		private void hideLoading()
		{
			pbx_Loading.Visible = false;
			pbx_Loading.Dock = DockStyle.None;
			pbx_Loading.Size = new Size(0, 0);
			pbx_Loading.Location = new Point(0, 0);
			pnl_Trips.AutoScroll = true;
		}

		private void showLoading()
		{
			pbx_Loading.Visible = true;
			pbx_Loading.Dock = DockStyle.Fill;
			pnl_Trips.AutoScroll = false;
		}
	}
}
