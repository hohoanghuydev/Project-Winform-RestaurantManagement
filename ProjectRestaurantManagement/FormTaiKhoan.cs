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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            loadData();
        }
        bool _them;
        ClassNhanVien cNhanVien = new ClassNhanVien();
        void loadData()
        {
            dataGridViewTaiKhoan.DataSource = cNhanVien.getList();
            dataGridViewTaiKhoan.Columns.Remove("MatKhau");
            dataGridViewTaiKhoan.Columns.Remove("HoaDons");
            dataGridViewTaiKhoan.AutoResizeColumns();

        }
        void reset()
        {
            textBoxMaNhanVien.Clear();
            textBoxTenNhanVien.Clear();
            textBoxChucVu.Clear();
            textBoxLuong.Clear();
        }
        void show()
        {
            buttonLuu.Hide();
            buttonHuy.Hide();
            
            buttonThemNhanVien.Show();
            buttonXoaNhanVien.Show();
            buttonSuaNhanVien.Show();
        }

        void hide()
        {
            buttonLuu.Show();
            buttonHuy.Show();

            buttonThemNhanVien.Hide();
            buttonXoaNhanVien.Hide();
            buttonSuaNhanVien.Hide();
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                textBoxMaNhanVien.Text = cNhanVien.lastCode();
                NhanVien n = new NhanVien();
                n.MaNV = textBoxMaNhanVien.Text;
                n.TenNV = textBoxTenNhanVien.Text;
                n.Luong = int.Parse(textBoxLuong.Text);
                n.ChucVu = textBoxChucVu.Text;
                n.MatKhau = "123456";
                cNhanVien.add(n);
            }
            else
            {
                NhanVien n = cNhanVien.getItem(dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString());
                n.TenNV = textBoxTenNhanVien.Text;
                n.Luong = int.Parse(textBoxLuong.Text);
                n.ChucVu = textBoxChucVu.Text;
                cNhanVien.update(n);
            }
            show();
            _them = false;
            loadData();
        }

        private void buttonXoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien n = cNhanVien.getItem(dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString());
            cNhanVien.delete(n);
            loadData();
        }
        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        

        private void buttonSuaNhanVien_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridViewTaiKhoan.DataSource = cNhanVien.getList();
            dataGridViewTaiKhoan.Columns.Remove("MatKhau");
            dataGridViewTaiKhoan.Columns.Remove("HoaDons");
            dataGridViewTaiKhoan.AutoResizeColumns();
            NhanVien n = cNhanVien.getItem(dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString());
            textBoxMaNhanVien.Text = n.MaNV;
            textBoxTenNhanVien.Text = n.TenNV;
            textBoxLuong.Text = n.Luong.ToString();
            textBoxChucVu.Text = n.ChucVu.ToString();

        }


        private void dataGridViewTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString() != null)
            {
                
                NhanVien n = cNhanVien.getItem(dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString());
                textBoxMaNhanVien.Text = n.MaNV;
                textBoxTenNhanVien.Text = n.TenNV;
                textBoxLuong.Text = n.Luong.ToString();
                textBoxChucVu.Text = n.ChucVu.ToString();
            }



        }

        private void textBoxLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
