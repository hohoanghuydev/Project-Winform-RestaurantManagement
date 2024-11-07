using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectRestaurantManagement.Models;
namespace ProjectRestaurantManagement
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        bool login(string userName, string password)
        {
            return true;
        }
        ClassNhanVien cNhanVien = new ClassNhanVien(); 
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string userName = textBoxTenDangNhap.Text;
            string password = textBoxMatKhau.Text;
            if (cNhanVien.dangNhap(userName,password))
            {
                Const.nv = cNhanVien.getItem(userName);
                FormQuanLy f = new FormQuanLy();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            textBoxMatKhau.PasswordChar = '•';
            pictureBoxHien.Show();
        }

        private void pictureBoxHien_Click(object sender, EventArgs e)
        {
            pictureBoxHien.Hide();
            textBoxMatKhau.PasswordChar = '\0';
            pictureBox2.Show();
        }
    }
}
