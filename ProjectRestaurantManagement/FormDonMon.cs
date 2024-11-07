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

namespace ProjectRestaurantManagement
{
    public partial class FormDonMon : Form
    {
        RestaurantManagementDatabaseEntities1 db = new RestaurantManagementDatabaseEntities1();
        public FormDonMon()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            dataGridView1.DataSource = db.sp_DonMon();
            dataGridView1.Tag = "505";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Tag.ToString() == "505")
            {
                MessageBox.Show("Bạn chưa chọn đơn món!!!");
                return;
            }
            string maCTHD = dataGridView1.Tag.ToString();
            ChiTietHD cthd = db.ChiTietHDs.Where(row => row.MaCTHD == maCTHD).FirstOrDefault();
            if (cthd.TrangThaiMon == "Đã xong") return;
            cthd.TrangThaiMon = "Đã xong";
            db.SaveChanges();
            LoadDataGridView();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            dataGridView1.Tag = id;
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[5].Value.ToString() == "Đã xong")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
