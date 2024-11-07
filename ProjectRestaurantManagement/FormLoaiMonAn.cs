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
    public partial class FormLoaiMonAn : Form
    {
        public FormLoaiMonAn()
        {
            InitializeComponent();
            loadData();
        }
        bool _them;
        ClassLoaiMonAn cLoaiMA = new ClassLoaiMonAn();

        void loadData()
        {
            dataGridViewLoaiMonAn.DataSource = cLoaiMA.getList();
            dataGridViewLoaiMonAn.AutoResizeColumns();
            dataGridViewLoaiMonAn.Columns.Remove("MonAns");
        }
        void reset()
        {
            textBoxMaLoaiMonAn.Clear();
            textBoxTenLoaiMonAn.Clear();
        }
        void show()
        {
            buttonLuu.Hide();
            buttonHuy.Hide();
            buttonThemLoaiMonAn.Show();
            buttonSuaLoaiMonAn.Show();
            buttonXoaLoaiMonAn.Show();
        }
        void hide()
        {
            buttonLuu.Show();
            buttonHuy.Show();
            buttonThemLoaiMonAn.Hide();
            buttonSuaLoaiMonAn.Hide();
            buttonXoaLoaiMonAn.Hide();
        }
        

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        private void buttonThemLoaiMonAn_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        private void buttonXoaLoaiMonAn_Click(object sender, EventArgs e)
        {
            LoaiMonAn l = cLoaiMA.getItem(dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString());
            cLoaiMA.delete(l);
            loadData();
        }

        private void buttonSuaLoaiMonAn_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();
        }
        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            if (_them)
            {
                textBoxMaLoaiMonAn.Text = cLoaiMA.lastCode();
                LoaiMonAn l = new LoaiMonAn();
                l.MaLoaiMonAn = textBoxMaLoaiMonAn.Text;
                l.TenLoaiMonAn = textBoxTenLoaiMonAn.Text;
                cLoaiMA.add(l);
            }
            else
            {
                LoaiMonAn l = cLoaiMA.getItem(dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString());
                l.TenLoaiMonAn = textBoxTenLoaiMonAn.Text;
                cLoaiMA.update(l);
            }
            show();
            _them = false;
            loadData();
        }

        private void FormLoaiMonAn_Load(object sender, EventArgs e)
        {
            
            dataGridViewLoaiMonAn.DataSource = cLoaiMA.getList();
            dataGridViewLoaiMonAn.AutoResizeColumns();
            dataGridViewLoaiMonAn.Columns.Remove("MonAns");
            if (dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString() != null)
            {
                LoaiMonAn l = cLoaiMA.getItem(dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString());
                textBoxMaLoaiMonAn.Text = l.MaLoaiMonAn.ToString();
                textBoxTenLoaiMonAn.Text = l.TenLoaiMonAn.ToString();

            }
        }

        private void dataGridViewLoaiMonAn_Click(object sender, EventArgs e)
        {
            //if (dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString() != null)
            //{
            //    MonAn m = cMonAn.getItem(dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString());
            //    textBoxMaMonAn.Text = m.MaMonAn.ToString();
            //    textBoxTenMonAn.Text = m.TenMonAn.ToString();
            //    textBoxDonGia.Text = m.DonGia.ToString();
            //    comboBox1.Text = m.LoaiMonAn.TenLoaiMonAn.ToString();
            //}
            if (dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString() != null)
            {
                LoaiMonAn l = cLoaiMA.getItem(dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString());
                textBoxMaLoaiMonAn.Text = l.MaLoaiMonAn;
                textBoxTenLoaiMonAn.Text = l.TenLoaiMonAn;

            }
        }
    }
}
