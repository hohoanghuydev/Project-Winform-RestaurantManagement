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
    public partial class FormQuanLyBan : Form
    {
        //RestaurantManagementDatabaseEntities1 db2 = new RestaurantManagementDatabaseEntities1();
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        public FormQuanLyBan()
        {
            InitializeComponent();
            LoadTable();
            LoadCategories();

        }
        void LoadForm(object Form)
        {
            Form f = Form as Form;
            f.ShowDialog();
        }
        void LoadTableChange(string maBan)
        {
            List<Ban> ban = db.Bans.Where(row => row.MaBan != maBan && row.TenBan != "Remove" && row.TrangThai != "Đã đặt").ToList();
            cbChangeTable.DataSource = ban;
            cbChangeTable.DisplayMember = "TenBan";
        }
        #region methods
        void LoadTable()
        {
            List<Ban> ban = db.Bans.Where(b => b.TenBan !="Remove").ToList();
            LoadTableChange("");
            foreach (Ban item in ban)
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 100,
                    BackColor = System.Drawing.Color.FromArgb(22, 115, 126),
                    ForeColor = System.Drawing.Color.White,
                    Font = new Font("Tahoma", 10, FontStyle.Bold)
                };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;

                btn.Click += btnClick;
                btn.Tag = item;
                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(22, 115, 126);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(190, 52, 85);
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(string id)
        {
            int tongTien = 0;
            lstBill.Items.Clear();
            if (id != null)
            {
                List<ChiTietHD> cthd = db.ChiTietHDs.Where(row => row.MaHD == id).ToList();
                HoaDon tongHD = db.HoaDons.Where(row => row.MaHD == id).FirstOrDefault();
                tongHD.TongTien = 0;
                foreach (ChiTietHD item in cthd)
                {
                    ListViewItem lsvItem = new ListViewItem(item.MonAn.TenMonAn.ToString());
                    lsvItem.SubItems.Add(item.SoLuong.ToString());
                    lsvItem.SubItems.Add(item.MonAn.DonGia.ToString());
                    lsvItem.SubItems.Add((item.MonAn.DonGia * item.SoLuong).ToString());
                    tongTien += (int)item.MonAn.DonGia * (int)item.SoLuong;
                    lstBill.Items.Add(lsvItem);
                }
                tongHD.TongTien = tongTien;
                db.SaveChanges();
            }
            txbTongTien.Text = tongTien.ToString("c");
        }
        void LoadFoods(string id)
        {
            List<MonAn> monAn = db.MonAns.Where(row => row.MaLoaiMonAn == id && row.TenMonAn != "Remove").ToList();
            cbMon.DataSource = monAn;
            cbMon.DisplayMember = "TenMonAn";
        }
        void LoadCategories()
        {
            List<LoaiMonAn> LoaiMonAn = db.LoaiMonAns.Where(r => r.TenLoaiMonAn != "Remove").ToList();
            cbLoaiMon.DataSource = LoaiMonAn;
            cbLoaiMon.DisplayMember = "TenLoaiMonAn";
        }
        int kiemTraChuSo(int n)
        {
            int count = 1;
            while (n >= 10)
            {
                n /= 10;
                count += 1;
            }
            return count;
        }
        string TangMaChiTietHD()
        {
            List<ChiTietHD> cthd = db.ChiTietHDs.ToList();
            if (cthd.Count == 0)
            {
                return "CTHD001";
            }
            string maCTHD = cthd.LastOrDefault().MaCTHD.ToString();
            if (maCTHD == null)
                maCTHD = "CTHD000";
            int numBillID = int.Parse(maCTHD.Substring(4, 3));
            numBillID += 1;
            maCTHD = maCTHD.Substring(0, 4);
            int chuoiDayDu = 3 - kiemTraChuSo(numBillID);
            if (chuoiDayDu == 0)
                maCTHD += numBillID.ToString();
            else if (chuoiDayDu == 1)
                maCTHD += ("0" + numBillID.ToString());
            else
                maCTHD += ("00" + numBillID.ToString());
            return maCTHD;
        }
        string TangMaHD()
        {
            List<HoaDon> hd = db.HoaDons.ToList();
            if (hd.Count == 0)
            {
                return "HD001";
            }
            string maHD = hd.LastOrDefault().MaHD;
            if (maHD == null)
                maHD = "HD000";
            int numBillID = int.Parse(maHD.Substring(2, 3));
            numBillID += 1;

            maHD = maHD.Substring(0, 2);
            int chuoiDayDu = 3 - kiemTraChuSo(numBillID);
            if (chuoiDayDu == 0)
                maHD += numBillID.ToString();
            else if (chuoiDayDu == 1)
                maHD += ("0" + numBillID.ToString());
            else
                maHD += ("00" + numBillID.ToString());
            return maHD;
        }
        #endregion
        void btnClick(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Ban).MaBan;
            lstBill.Tag = (sender as Button).Tag;
            HoaDon billID = db.HoaDons.Where(row => row.MaBan == tableID && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            labelTable.Text = ((sender as Button).Tag as Ban).TenBan;
            LoadTableChange(tableID);
            if (billID == null)
                ShowBill(null);
            else
                ShowBill(billID.MaHD);
        }
        private void cbLoaiMon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbLoaiMon.SelectedItem == null) return;
            LoaiMonAn lma = cbLoaiMon.SelectedItem as LoaiMonAn;
            LoadFoods(lma.MaLoaiMonAn);
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;
            HoaDon hd = db.HoaDons.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (hd == null) return;
            FormHoaDon f = new FormHoaDon();
            f.Tag = hd;
            LoadForm(f);
            if (f.Tag.ToString() != "ok") return;
            ban.TrangThai = "Trống";
            hd.TrangThaiThanhToan = "Đã thanh toán";
            hd.MaNV = Const.nv.MaNV;
            db.SaveChanges();
            ShowBill(null);
            flpTable.Controls.Clear();
            LoadTable();
        }

        private void btnChangeTable_Click_1(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            Ban newBan = new Ban();
            newBan = (cbChangeTable.SelectedItem as Ban);
            HoaDon hdNewTable = db.HoaDons.Where(row => row.MaBan == newBan.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (hdNewTable != null) return;
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;
            ban.TrangThai = "Trống";
            HoaDon hd = db.HoaDons.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (hd == null) return;
            newBan = (cbChangeTable.SelectedItem as Ban);
            newBan.TrangThai = "Đã đặt";
            hd.MaBan = newBan.MaBan;
            db.SaveChanges();
            flpTable.Controls.Clear();
            LoadTable();
            ShowBill(hd.MaHD);
        }
        private void btnThemMon_Click_1(object sender, EventArgs e)
        {
            if (labelTable.Text == "Bàn: " || cbMon.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn!!!");
                return;
            }
            MonAn maMon = (cbMon.SelectedItem as MonAn);
            Ban ban = new Ban();
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;
            ban.TrangThai = "Đã đặt";
            db.SaveChanges();
            flpTable.Controls.Clear();
            LoadTable();
            HoaDon hd = db.HoaDons.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            int soLuong = (int)nudSoLuong.Value;
            if (hd != null)
            {
                List<ChiTietHD> listMon = db.ChiTietHDs.Where(row => row.MaHD == hd.MaHD).ToList();
                ChiTietHD idMatch = listMon.Where(row => row.MaMonAn == maMon.MaMonAn && row.TrangThaiMon == "Chưa chuẩn bị").FirstOrDefault();
                if (idMatch == null)
                {
                    ChiTietHD newCTHD = new ChiTietHD() { MaCTHD = TangMaChiTietHD(), MaMonAn = maMon.MaMonAn, SoLuong = soLuong, MaHD = hd.MaHD, TrangThaiMon = "Chưa chuẩn bị", ThoiGianDatMon = DateTime.Now };
                    db.ChiTietHDs.Add(newCTHD);
                }
                else
                {
                    idMatch.MaCTHD = idMatch.MaCTHD;
                    idMatch.MaHD = hd.MaHD;
                    idMatch.MaMonAn = idMatch.MaMonAn;
                    idMatch.SoLuong += soLuong;
                    idMatch.TrangThaiMon = "Chưa chuẩn bị";
                }
                db.SaveChanges();
                ShowBill(hd.MaHD);
            }
            else
            {
                HoaDon newHD = new HoaDon() { MaHD = TangMaHD(), MaBan = ban.MaBan, NgayLap = DateTime.Now, TrangThaiThanhToan = "Chưa thanh toán" };//Thêm mã nv và mã kh sau khi cài đặt role
                db.HoaDons.Add(newHD);
                db.SaveChanges();
                ChiTietHD newCTHD = new ChiTietHD() { MaCTHD = TangMaChiTietHD(), MaMonAn = maMon.MaMonAn, SoLuong = soLuong, MaHD = newHD.MaHD, TrangThaiMon = "Chưa chuẩn bị", ThoiGianDatMon = DateTime.Now };
                db.ChiTietHDs.Add(newCTHD);
                db.SaveChanges();
                ShowBill(newHD.MaHD);
            }
        }
    }
}
