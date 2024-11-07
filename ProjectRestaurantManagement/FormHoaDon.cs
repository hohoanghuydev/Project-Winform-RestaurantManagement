using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectRestaurantManagement.EF;
using ProjectRestaurantManagement.Models;

namespace ProjectRestaurantManagement
{
    public partial class FormHoaDon : Form
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        void LoadHoaDon()
        {
            HoaDon hd = this.Tag as HoaDon;
            label2.Text = "Mã hóa đơn: " + hd.MaHD;
            label3.Text = "Ngày: " + hd.NgayLap;
            label4.Text = "Bàn: " + hd.Ban.TenBan;
            label5.Text = "Thu ngân: " + Const.nv.TenNV ;// hd.NhanVien.TenNV;
            List<ChiTietHD> cthd = db.ChiTietHDs.Where(row => row.MaHD == hd.MaHD).ToList();
            foreach (ChiTietHD item in cthd)
            {
                ListViewItem lsvItem = new ListViewItem(item.MonAn.TenMonAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.MonAn.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                listView1.Items.Add(lsvItem);
            }
            label6.Text = "Tổng tiền: " + hd.TongTien;
        }
        private void button2_Click(object sender, EventArgs e)//Cancel
        {
            this.Tag = "cancel";
            this.Close();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void button1_Click(object sender, EventArgs e)//Ok
        {
            HoaDon hdShow = this.Tag as HoaDon;
            HoaDon hoaDon = db.HoaDons.Where(row => row.MaHD == hdShow.MaHD).FirstOrDefault();
            Ban b = db.Bans.Where(row => row.MaBan == hdShow.MaBan).FirstOrDefault();
            this.Tag = "ok";
            this.Close();
        }
    }
}
