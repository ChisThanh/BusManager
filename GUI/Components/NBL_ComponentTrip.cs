using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DTO.Schemas;
using Guna.UI2.WinForms;

namespace GUI.Components
{
	public partial class NBL_ComponentTrip : UserControl
	{
		private Trip trip;
		private NBL_ComponentRibbon ribbon;

		public Trip TripVariable
		{
			get { return trip; }
			set { trip = value; }
		}

		public event EventHandler clicked;

		public NBL_ComponentTrip(Trip trip)
		{
			InitializeComponent();
			this.trip = trip;

			Load += NBL_ComponentTrip_Load;
			pnl_Click.Click += Pnl_Click_Click;

			ribbon = new NBL_ComponentRibbon();
			ribbon.Visible = false;
			ribbon.Location = new Point(Width - 60, 0);
			Controls.Add(ribbon);
			ribbon.BringToFront();
		}

		private void Pnl_Click_Click(object sender, EventArgs e)
		{
			clicked?.Invoke(this, EventArgs.Empty);
			ShowRibbon();
		}

		private void NBL_ComponentTrip_Load(object sender, EventArgs e)
		{
			lbl_Date.Text = trip.Date.ToLongDateString();
			lbl_Bus.Text = trip.BusObj?.LicensePlate ?? "Bus";
			lbl_School.Text = shortenName(trip.SchoolObj?.Name ?? "School");
			lbl_Region.Text = trip.RegionObj?.Name ?? "Region";

			if (trip.Status == "active")
			{
				if (DateTime.Now.Date < trip.Date.Date)
				{
					pbx_Status.Image = Properties.Resources.bus_planned_icon;
					pnl_Trip.FillColor = Color.SkyBlue;
					pnl_Trip.FillColor2 = Color.LightSkyBlue;
				}
				else if (DateTime.Now.Date > trip.Date.Date)
				{
					pbx_Status.Image = Properties.Resources.bus_finished_icon;
					pnl_Trip.FillColor = Color.Gainsboro;
					pnl_Trip.FillColor2 = Color.Silver;
				}
				else
				{
					pbx_Status.Image = Properties.Resources.bust_running_icon;
					pnl_Trip.FillColor = Color.LightGreen;
					pnl_Trip.FillColor2 = Color.MediumSeaGreen;
				}
			}
			else
			{
				pbx_Status.Image = Properties.Resources.bus_cancelled_icon;
				pnl_Trip.FillColor = Color.LightCoral;
				pnl_Trip.FillColor2 = Color.Salmon;
			}
		}

		private string shortenName(string name)
		{
			if (name.StartsWith("Trường Trung Học Phổ Thông Chuyên"))
			{
				return name.Replace("Trường Trung Học Phổ Thông Chuyên", "THPTC").Trim();
			}

			if (name.StartsWith("Trường Trung Học Phổ Thông"))
			{
				return name.Replace("Trường Trung Học Phổ Thông", "THPT").Trim();
			}

			return name;
		}

		public void ShowRibbon()
		{
			ribbon.Visible = true;
		}

		public void HideRibbon()
		{
			ribbon.Visible = false;
		}
	}
}
