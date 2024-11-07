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
    public partial class FormCaNhan : Form
    {
        public FormCaNhan()
        {
            InitializeComponent();
        }
        ClassNhanVien cNhanVien = new ClassNhanVien();
        public static bool IsValidString(string input)
        {
            if (input.Length < 6)
            {
                return false;
            }
            if (!input.Any(char.IsLetter))
            {
                return false;
            }
            if (!input.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }
        private void pictureBoxHien_Click(object sender, EventArgs e)
        {
            pictureBoxHien.Hide();
            textBoxMatKhauCu.PasswordChar = '•';
            textBoxMatKhauMoi.PasswordChar = '•';
            textBoxNhapLaiMK.PasswordChar = '•';
            pictureBoxAn.Show();
        }

        private void pictureBoxAn_Click(object sender, EventArgs e)
        {
            pictureBoxAn.Hide();
            textBoxMatKhauCu.PasswordChar = '\0';
            textBoxMatKhauMoi.PasswordChar = '\0';
            textBoxNhapLaiMK.PasswordChar = '\0';
            pictureBoxHien.Show();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (textBoxMatKhauCu.Text != Const.nv.MatKhau)
            {
                label3.Text = "Vui lòng nhập đúng mật khẩu cũ";
                textBoxMatKhauCu.Clear();
                textBoxMatKhauMoi.Clear();
                textBoxNhapLaiMK.Clear();
            }
            else
            {
                if (!IsValidString(textBoxMatKhauMoi.Text))
                {

                    label3.Text = "Mật khẩu mới phải chứa ít nhất 6 kí tự và chứa cả số cả chữ";
                    textBoxMatKhauCu.Clear();
                    textBoxMatKhauMoi.Clear();
                    textBoxNhapLaiMK.Clear();
                }
                else
                {
                    if (textBoxNhapLaiMK.Text != textBoxMatKhauMoi.Text)
                    {
                        label3.Text = "Vui lòng nhập đúng mật khẩu mới";
                        textBoxMatKhauCu.Clear();
                        textBoxMatKhauMoi.Clear();
                        textBoxNhapLaiMK.Clear();
                    }
                    else
                    {
                        cNhanVien.doiMatKhau(Const.nv.MaNV, textBoxMatKhauMoi.Text);
                        label3.Text = "Bạn đã đổi thông tin thành công";
                    }
                }
            }
        }

        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            textBoxTenDangNhap.Text = Const.nv.MaNV;
        }
    }
}
