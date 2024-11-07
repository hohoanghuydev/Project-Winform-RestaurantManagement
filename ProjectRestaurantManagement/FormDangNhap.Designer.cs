using System.Drawing;
using System.Windows.Forms;

namespace ProjectRestaurantManagement
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxHien = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.textBoxTenDangNhap);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 49);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectRestaurantManagement.Properties.Resources.id_card;
            this.pictureBox3.Location = new System.Drawing.Point(16, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(91, 7);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(228, 30);
            this.textBoxTenDangNhap.TabIndex = 1;
            this.textBoxTenDangNhap.Text = "NV002";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.Color.White;
            this.buttonDangNhap.Location = new System.Drawing.Point(19, 184);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(119, 35);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.White;
            this.buttonThoat.Location = new System.Drawing.Point(176, 184);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(132, 35);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 414);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 106);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUẢN LÝ NHÀ HÀNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectRestaurantManagement.Properties.Resources.restaurant;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.textBoxMatKhau);
            this.panel2.Location = new System.Drawing.Point(3, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 53);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjectRestaurantManagement.Properties.Resources.padlock;
            this.pictureBox4.Location = new System.Drawing.Point(16, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(91, 16);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '•';
            this.textBoxMatKhau.Size = new System.Drawing.Size(228, 30);
            this.textBoxMatKhau.TabIndex = 2;
            this.textBoxMatKhau.Text = "123456";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxHien);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.buttonThoat);
            this.panel4.Controls.Add(this.buttonDangNhap);
            this.panel4.Location = new System.Drawing.Point(276, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 222);
            this.panel4.TabIndex = 5;
            // 
            // pictureBoxHien
            // 
            this.pictureBoxHien.Image = global::ProjectRestaurantManagement.Properties.Resources.hide__1_;
            this.pictureBoxHien.Location = new System.Drawing.Point(334, 108);
            this.pictureBoxHien.Name = "pictureBoxHien";
            this.pictureBoxHien.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHien.TabIndex = 6;
            this.pictureBoxHien.TabStop = false;
            this.pictureBoxHien.Click += new System.EventHandler(this.pictureBoxHien_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectRestaurantManagement.Properties.Resources.view;
            this.pictureBox2.Location = new System.Drawing.Point(334, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormDangNhap
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 414);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBoxTenDangNhap;
        private Button buttonDangNhap;
        private Button buttonThoat;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxMatKhau;
        private Panel panel4;
        private PictureBox pictureBoxHien;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}

