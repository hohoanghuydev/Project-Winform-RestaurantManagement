using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProjectRestaurantManagement.EF;

namespace ProjectRestaurantManagement
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();

        void tinhToanDoanhThu(List<double?> doanhThu)
        {
            if (doanhThu.Count > 0)
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                labelTongDoanhThu.Text = doanhThu.Sum().Value.ToString("C1", culture);
                labelDTCaoNhat.Text = doanhThu.Max().Value.ToString("C1", culture);
                labelDTThapNhat.Text = doanhThu.Min().Value.ToString("C1", culture);
            }else
            {
                MessageBox.Show("Lỗi");
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxThongKe.SelectedIndex == 0)
            {
                thongKeDoanhThu();
            }else if (comboBoxThongKe.SelectedIndex == 1)
            {
                thongKeMonAn();
            }
            else if(comboBoxThongKe.SelectedIndex == 2)
            {
                thongKeNhanVien();
            }
        }
        void thongKeDoanhThu()
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            CultureInfo culture = new CultureInfo("vi-VN");

            if (startDate > endDate)
            {
                MessageBox.Show("Loi!!");
                return;
            }
            chartThongKe.Series.Clear();
            chartThongKe.Series.Add("Doanh thu");
            List<DateTime?> listNgay = db.LayNgayTrongKhoangNgay(startDate, endDate).ToList();
            List<double?> doanhThu = db.LayDoanhThuTrongKhoangNgay(startDate, endDate).ToList();
            
            
            listView1.Items.Clear();
            for (int i = 0; i < listNgay.Count; i++)
            {

                ListViewItem lstItem = new ListViewItem(listNgay[i].Value.ToString("dd/MM/yyyy", culture));
                lstItem.SubItems.Add(doanhThu[i].Value.ToString("C1"));

                listView1.Items.Add(lstItem);
                if (doanhThu[i] > 0)
                {
                    chartThongKe.Series["Doanh thu"].Points.AddXY(listNgay[i], doanhThu[i]);
                }

            }
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
            chartThongKe.ChartAreas[0].BackColor = Color.White;
            chartThongKe.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chartThongKe.ChartAreas[0].BorderColor = Color.Gray;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Tahoma", 8);
            chartThongKe.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Tahoma", 8);
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.Series[0].ChartType = SeriesChartType.Column;
            chartThongKe.Series["Doanh thu"]["PixelPointWidth"] = "20";
            chartThongKe.Series[0].Color = System.Drawing.Color.FromArgb(22, 115, 126);
            chartThongKe.Series[0].BorderWidth = 2;
            chartThongKe.Series[0].IsValueShownAsLabel = true;
            chartThongKe.Series[0].LabelForeColor = Color.Black;
            chartThongKe.Series[0].LabelFormat = "#,##0";
            chartThongKe.Legends[0].Docking = Docking.Bottom;
            chartThongKe.Legends[0].BackColor = Color.White;
            chartThongKe.Legends[0].Font = new Font("Arial", 8);
            chartThongKe.Legends[0].ForeColor = Color.Black;
            chartThongKe.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chartThongKe.Series["Doanh thu"].IsValueShownAsLabel = true;
            tinhToanDoanhThu(doanhThu);
        }
        void thongKeMonAn()
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            CultureInfo culture = new CultureInfo("vi-VN");

            if (startDate > endDate)
            {
                MessageBox.Show("Loi!!");
                return;
            }
            chartThongKe.Series.Clear();
            chartThongKe.Series.Add("Số lượng");
            
            List<string> listMon = db.LayDanhSachMon(startDate, endDate).ToList();
            List<int?> listSL = db.LaySoLuongMon(startDate, endDate).ToList();
            listView1.Items.Clear();
            for (int i = 0; i < listSL.Count; i++)
            {

                ListViewItem lstItem = new ListViewItem(listMon[i]);
                lstItem.SubItems.Add(listSL[i].Value.ToString());
                listView1.Items.Add(lstItem);
                if (listSL[i] > 0)
                {
                    chartThongKe.Series["Số lượng"].Points.AddXY(listMon[i], listSL[i]);
                }

            }
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = -50;
            chartThongKe.ChartAreas[0].BackColor = Color.White;
            chartThongKe.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chartThongKe.ChartAreas[0].BorderColor = Color.Gray;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Tahoma", 8,FontStyle.Bold);
            chartThongKe.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Tahoma", 8,FontStyle.Bold);
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.Series[0].ChartType = SeriesChartType.Column;
            chartThongKe.Series["Số lượng"]["PixelPointWidth"] = "20";
            chartThongKe.Series[0].Color = System.Drawing.Color.FromArgb(22, 115, 126);
            chartThongKe.Series[0].BorderWidth = 2;
            chartThongKe.Series[0].IsValueShownAsLabel = true;
            chartThongKe.Series[0].LabelForeColor = Color.Black;
            chartThongKe.Series[0].LabelFormat = "#,##0";
            chartThongKe.Legends[0].Docking = Docking.Bottom;
            chartThongKe.Legends[0].BackColor = Color.White;
            chartThongKe.Legends[0].Font = new Font("Arial", 8);
            chartThongKe.Legends[0].ForeColor = Color.Black;
            chartThongKe.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
        }
        void thongKeNhanVien()
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            CultureInfo culture = new CultureInfo("vi-VN");

            if (startDate > endDate)
            {
                MessageBox.Show("Loi!!");
                return;
            }
            chartThongKe.Series.Clear();
            chartThongKe.Series.Add("Doanh thu");
            List<string> listNgay = db.LayDanhSachNhanVien(startDate,endDate).ToList();
            List<double?> doanhThu = db.LayDoanhThuNhanVien(startDate,endDate).ToList();


            listView1.Items.Clear();
            for (int i = 0; i < listNgay.Count; i++)
            {

                ListViewItem lstItem = new ListViewItem(listNgay[i]);
                lstItem.SubItems.Add(doanhThu[i].Value.ToString("C1"));

                listView1.Items.Add(lstItem);
                if (doanhThu[i] > 0)
                {
                    chartThongKe.Series["Doanh thu"].Points.AddXY(listNgay[i], doanhThu[i]);
                }

            }
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
            chartThongKe.ChartAreas[0].BackColor = Color.White;
            chartThongKe.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chartThongKe.ChartAreas[0].BorderColor = Color.Gray;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Tahoma", 8);
            chartThongKe.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Tahoma", 8);
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartThongKe.Series[0].ChartType = SeriesChartType.Column;
            chartThongKe.Series["Doanh thu"]["PixelPointWidth"] = "20";
            chartThongKe.Series[0].Color = System.Drawing.Color.FromArgb(22, 115, 126);
            chartThongKe.Series[0].BorderWidth = 2;
            chartThongKe.Series[0].IsValueShownAsLabel = true;
            chartThongKe.Series[0].LabelForeColor = Color.Black;
            chartThongKe.Series[0].LabelFormat = "#,##0";
            chartThongKe.Legends[0].Docking = Docking.Bottom;
            chartThongKe.Legends[0].BackColor = Color.White;
            chartThongKe.Legends[0].Font = new Font("Arial", 8);
            chartThongKe.Legends[0].ForeColor = Color.Black;
            chartThongKe.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chartThongKe.Series["Doanh thu"].IsValueShownAsLabel = true;
        }
        void loadITem()
        {
            List<string> mylist = new List<string>(new string[] { "Doanh thu", "Món ăn","Nhân viên"});
            foreach (var item in mylist)
            {
                comboBoxThongKe.Items.Add(item);
            }
            comboBoxThongKe.SelectedIndex = 0;
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadITem();
        }
    }
}
