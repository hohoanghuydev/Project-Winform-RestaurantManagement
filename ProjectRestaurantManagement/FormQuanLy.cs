using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectRestaurantManagement.Models;

namespace ProjectRestaurantManagement
{
    public partial class FormQuanLy : Form
    {
        Button cButton;
        
        public FormQuanLy()
        {
            InitializeComponent();
        }
        void Active(object sender, Color color)
        {
            if (sender != null)
            {
                Disable();
                cButton = (Button)sender;
                cButton.BackColor = Color.White ;
                cButton.ForeColor = color;
                
            }
        }
        void Disable()
        {
            if (cButton != null)
            {
                cButton.BackColor = Color.FromArgb(22, 115, 126);

                cButton.ForeColor = Color.White;
            }
        }
        public void LoadForm(object Form)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new FormCaNhan());
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void buttonQuanLyBan_Click(object sender, EventArgs e)
        {
            LoadForm(new FormQuanLyBan());
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBan());
            Active(sender, Color.FromArgb(22, 115, 126));

        }

        private void buttonThucAn_Click(object sender, EventArgs e)
        {
            LoadForm(new FormMonAn());
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void buttonDanhMuc_Click(object sender, EventArgs e)
        {
            LoadForm(new FormLoaiMonAn());
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            LoadForm(new FormThongKe());
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadForm(new FormTaiKhoan() );
            Active(sender, Color.FromArgb(22, 115, 126));
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            LoadForm(new FormCaNhan());
            if (Const.nv.ChucVu != "Quản lý")
            {
                buttonBan.Hide();
                buttonDanhMuc.Hide();
                buttonThucAn.Hide();
                buttonThongKe.Hide();
                buttonTaiKhoan.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnFormDonMon_Click(object sender, EventArgs e)
        {
            LoadForm(new FormDonMon());
        }

        private void btnFormDonMon_Click_1(object sender, EventArgs e)
        {
            LoadForm(new FormDonMon());
            Active(sender, Color.FromArgb(22, 115, 126));
        }
    }
}
