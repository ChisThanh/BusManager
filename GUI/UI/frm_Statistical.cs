using DTO.DTO;
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
    public partial class frm_Statistical : Form
    {
        int _year = DateTime.Now.Year;
        DTO_Statistical dto = new DTO_Statistical();

        public frm_Statistical()
        {
            InitializeComponent();
            this.Load += Frm_Statistical_Load;
            this.cbx_Year.SelectedIndexChanged += Cbx_Year_SelectedIndexChanged;
        }

        private void Cbx_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Year.SelectedItem != null)
            {
                _year = (int)cbx_Year.SelectedItem;
                load_Chart();
            }
        }

        private async void Frm_Statistical_Load(object sender, EventArgs e)
        {
            List<int> years = Enumerable.Range(_year - 4, 5).ToList();
            years.Reverse();
            this.cbx_Year.DataSource = years;

            var GetDriverAsync = await dto.GetDriverAsync();
            var GetBusCountAsync = await dto.GetBusCountAsync();

            txt_QuantityDriver.Text = GetDriverAsync.ToString();
            txt_QuantityBus.Text = GetBusCountAsync.ToString();
        }

        private async void load_Chart()
        {
            bool check = true;
            var resultRevenue = await dto.GetMonthlyRevenueAsync(_year);
            if (resultRevenue != null && resultRevenue.Count() > 0)
            {
                chart_Revenue.Series[0].Points.Clear();
                foreach (var item in resultRevenue)
                    chart_Revenue.Series[0].Points.AddXY(item.month, item.monthlyRevenue);
            }
            else check = false;

            if (!check)
            {
                MessageBox.Show("Không có dữ liệu thông kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var result = await dto.GetMonthlyRevenueAsync(_year);
            if (result != null && result.Count() > 0)
            {
                chart2.Series[0].Points.Clear();
                foreach (var item in result)
                    chart2.Series[0].Points.AddXY(item.month, item.monthlyRevenue);
            }


            var resultRegion = await dto.GetTotalRevenueByRegionAsync(_year);
            if (resultRegion != null && resultRegion.Count() > 0)
            {
                chart_Region.Series[0].Points.Clear();
                foreach (var item in resultRegion)
                    chart_Region.Series[0].Points.AddXY(item.region, item.totalRevenue);
            }

            txt_TotalRevenue.Text = await dto.GetTotalRevenueByYearAsync(_year);
        }
    }
}

