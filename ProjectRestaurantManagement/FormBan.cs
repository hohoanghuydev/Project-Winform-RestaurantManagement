using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectRestaurantManagement.EF;
using ProjectRestaurantManagement.Models;
namespace ProjectRestaurantManagement
{
    public partial class FormBan : Form
    {
        public FormBan()
        {
            InitializeComponent();
            loadData();
        }
        bool _them;
        ClassBan cBan = new ClassBan();
        bool KiemTraKyTuDacBiet(string input)
        {
            // Kiểm tra xem chuỗi có chứa số, ký tự đặc biệt hoặc ký tự tiếng Việt không
            Regex regex = new Regex("[^a-zA-Z0-9\\p{IsBasicLatin}\\p{IsLatin-1Supplement}\\p{IsLatinExtended-A}\\p{IsLatinExtended-B}]");
            return regex.IsMatch(input);
        }
        bool kiemTraNhapLieu()
        {
            if (KiemTraKyTuDacBiet(textBoxTenBan.Text))
            {
                
                return true;
            }
            return false;
        }
        void loadData()
        {
            dataGridViewBan.DataSource = cBan.getList();
            dataGridViewBan.Columns.Remove("HoaDons");
            dataGridViewBan.AutoResizeColumns();
        }
        void reset()
        {
            textBoxMaBan.Clear();
            textBoxTenBan.Clear();
        }
        void show()
        {
            buttonLuu.Hide();
            buttonHuy.Hide();
            buttonThemBan.Show();
            buttonXoaBan.Show();
            buttonSuaBan.Show();
        }

        void hide()
        {
            buttonLuu.Show();
            buttonHuy.Show();
            buttonThemBan.Hide();
            buttonXoaBan.Hide();
            buttonSuaBan.Hide();
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraKyTuDacBiet(textBoxTenBan.Text))
            {
                if (_them)
                {
                    textBoxMaBan.Text = cBan.lastCode();
                        Ban b = new Ban();
                        b.MaBan = textBoxMaBan.Text;
                        b.TenBan = textBoxTenBan.Text;
                        b.TrangThai = "Trống";
                        cBan.add(b);
                }
                else
                {
                    Ban b = cBan.getItem(dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString());
                    b.TenBan = textBoxTenBan.Text;
                    cBan.update(b);
                }
            }
            else
            {
                MessageBox.Show("Lỗi xảy ra");
            }


            show();
            _them = false;
            loadData();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        private void buttonThemBan_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        private void buttonXoaBan_Click(object sender, EventArgs e)
        {
            Ban b = cBan.getItem(dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString());
            cBan.delete(b);
            loadData();
        }

        private void buttonSuaBan_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();
        }

        private void dataGridViewBan_Click(object sender, EventArgs e)
        {
            if (dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString() != null)
            {
                Ban b = cBan.getItem(dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString());
                textBoxMaBan.Text = b.MaBan.ToString();
                textBoxTenBan.Text = b.TenBan.ToString();
            }
        }

        private void FormBan_Load(object sender, EventArgs e)
        {
            dataGridViewBan.DataSource = cBan.getList();
            dataGridViewBan.Columns.Remove("HoaDons");
            dataGridViewBan.AutoResizeColumns();
            if (dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString() != null)
            {
                Ban b = cBan.getItem(dataGridViewBan.SelectedCells[0].OwningRow.Cells["MaBan"].Value.ToString());
                textBoxMaBan.Text = b.MaBan.ToString();
                textBoxTenBan.Text = b.TenBan.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTenBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
