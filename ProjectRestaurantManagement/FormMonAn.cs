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
    public partial class FormMonAn : Form
    {
        public FormMonAn()
        {
            InitializeComponent();
            loadData();
        }
        bool _them;
        ClassMonAn cMonAn = new ClassMonAn();
        ClassLoaiMonAn cLMA = new ClassLoaiMonAn();
        void loadData()
        {
            dataGridViewMonAn.DataSource = cMonAn.getList();
            comboBox1.DataSource = cLMA.getList();
            comboBox1.DisplayMember = "TenLoaiMonAn";
            comboBox1.ValueMember = "MaLoaiMonAn";
            dataGridViewMonAn.AutoResizeColumns();
        }

        void reset()
        {
            textBoxMaMonAn.Clear();
            textBoxTenMonAn.Clear();
            textBoxDonGia.Clear();
        }
        void show()
        {
            buttonLuu.Hide();
            buttonHuy.Hide();
            buttonThemMonAn.Show();
            buttonXoaMonAn.Show();
            buttonSuaMonAn.Show();
        }

        void hide()
        {
            buttonLuu.Show();
            buttonHuy.Show();
            buttonThemMonAn.Hide();
            buttonXoaMonAn.Hide();
            buttonSuaMonAn.Hide();
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
                textBoxMaMonAn.Text = cMonAn.lastCode();
                MonAn m = new MonAn();
                m.MaMonAn = textBoxMaMonAn.Text;
                m.TenMonAn = textBoxTenMonAn.Text;
                m.DonGia = int.Parse(textBoxDonGia.Text);
                m.MaLoaiMonAn = comboBox1.SelectedValue.ToString();
                cMonAn.add(m);
            }
            else
            {
                MonAn m = cMonAn.getItem(dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
                m.TenMonAn = textBoxTenMonAn.Text;
                m.DonGia = int.Parse(textBoxDonGia.Text);
                m.MaLoaiMonAn = comboBox1.SelectedValue.ToString();
                cMonAn.update(m);
            }
            show();
            _them = false;
            loadData();
        }

        private void buttonXoaMonAn_Click(object sender, EventArgs e)
        {
            MonAn m = cMonAn.getItem(dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            cMonAn.delete(m);
            loadData();
        }

        private void buttonThemMonAn_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            dataGridViewMonAn.DataSource = cMonAn.getList();
            comboBox1.DataSource = cLMA.getList();
            comboBox1.DisplayMember = "TenLoaiMonAn";
            comboBox1.ValueMember = "MaLoaiMonAn";
            dataGridViewMonAn.Columns.Remove("LoaiMonAn");
            dataGridViewMonAn.Columns.Remove("ChiTietHDs");
            dataGridViewMonAn.AutoResizeColumns();
            if (dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString() != null)
            {
                MonAn m = cMonAn.getItem(dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
                textBoxMaMonAn.Text = m.MaMonAn.ToString();
                textBoxTenMonAn.Text = m.TenMonAn.ToString();
                textBoxDonGia.Text = m.DonGia.ToString();
            }
        }

        private void buttonSuaMonAn_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();

        }

        private void dataGridViewMonAn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString() != null)
            {
                MonAn m = cMonAn.getItem(dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
                textBoxMaMonAn.Text = m.MaMonAn.ToString();
                textBoxTenMonAn.Text = m.TenMonAn.ToString();
                textBoxDonGia.Text = m.DonGia.ToString();
                comboBox1.Text = m.LoaiMonAn.TenLoaiMonAn.ToString();
            }
        }

    }
}
