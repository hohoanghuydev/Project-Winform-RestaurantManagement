using System.Drawing;
using System.Windows.Forms;

namespace ProjectRestaurantManagement
{
    partial class FormQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCaNhan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonThucAn = new System.Windows.Forms.Button();
            this.buttonDanhMuc = new System.Windows.Forms.Button();
            this.buttonQuanLyBan = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFormDonMon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonCaNhan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonTaiKhoan);
            this.panel1.Controls.Add(this.buttonThongKe);
            this.panel1.Controls.Add(this.buttonThucAn);
            this.panel1.Controls.Add(this.buttonDanhMuc);
            this.panel1.Controls.Add(this.buttonQuanLyBan);
            this.panel1.Controls.Add(this.btnFormDonMon);
            this.panel1.Controls.Add(this.buttonBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 937);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(9, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1696, 26);
            this.panel3.TabIndex = 0;
            // 
            // buttonCaNhan
            // 
            this.buttonCaNhan.AutoSize = true;
            this.buttonCaNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonCaNhan.FlatAppearance.BorderSize = 0;
            this.buttonCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaNhan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCaNhan.ForeColor = System.Drawing.Color.White;
            this.buttonCaNhan.Location = new System.Drawing.Point(0, 217);
            this.buttonCaNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCaNhan.Name = "buttonCaNhan";
            this.buttonCaNhan.Size = new System.Drawing.Size(284, 72);
            this.buttonCaNhan.TabIndex = 3;
            this.buttonCaNhan.Text = "CÁ NHÂN";
            this.buttonCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaNhan.UseVisualStyleBackColor = false;
            this.buttonCaNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectRestaurantManagement.Properties.Resources.restaurant;
            this.pictureBox1.Location = new System.Drawing.Point(46, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.AutoSize = true;
            this.buttonTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.buttonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(0, 720);
            this.buttonTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(310, 72);
            this.buttonTaiKhoan.TabIndex = 2;
            this.buttonTaiKhoan.Text = "TÀI KHOẢN";
            this.buttonTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.AutoSize = true;
            this.buttonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.ForeColor = System.Drawing.Color.White;
            this.buttonThongKe.Location = new System.Drawing.Point(0, 647);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(254, 72);
            this.buttonThongKe.TabIndex = 2;
            this.buttonThongKe.Text = "THỐNG KÊ";
            this.buttonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonThucAn
            // 
            this.buttonThucAn.AutoSize = true;
            this.buttonThucAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThucAn.FlatAppearance.BorderSize = 0;
            this.buttonThucAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThucAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThucAn.ForeColor = System.Drawing.Color.White;
            this.buttonThucAn.Location = new System.Drawing.Point(0, 503);
            this.buttonThucAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonThucAn.Name = "buttonThucAn";
            this.buttonThucAn.Size = new System.Drawing.Size(280, 72);
            this.buttonThucAn.TabIndex = 2;
            this.buttonThucAn.Text = "MÓN ĂN";
            this.buttonThucAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThucAn.UseVisualStyleBackColor = false;
            this.buttonThucAn.Click += new System.EventHandler(this.buttonThucAn_Click);
            // 
            // buttonDanhMuc
            // 
            this.buttonDanhMuc.AutoSize = true;
            this.buttonDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonDanhMuc.FlatAppearance.BorderSize = 0;
            this.buttonDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanhMuc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhMuc.ForeColor = System.Drawing.Color.White;
            this.buttonDanhMuc.Location = new System.Drawing.Point(0, 575);
            this.buttonDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDanhMuc.Name = "buttonDanhMuc";
            this.buttonDanhMuc.Size = new System.Drawing.Size(348, 72);
            this.buttonDanhMuc.TabIndex = 2;
            this.buttonDanhMuc.Text = "LOẠI MÓN ĂN";
            this.buttonDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDanhMuc.UseVisualStyleBackColor = false;
            this.buttonDanhMuc.Click += new System.EventHandler(this.buttonDanhMuc_Click);
            // 
            // buttonQuanLyBan
            // 
            this.buttonQuanLyBan.AutoSize = true;
            this.buttonQuanLyBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonQuanLyBan.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyBan.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyBan.Location = new System.Drawing.Point(0, 289);
            this.buttonQuanLyBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuanLyBan.Name = "buttonQuanLyBan";
            this.buttonQuanLyBan.Size = new System.Drawing.Size(284, 72);
            this.buttonQuanLyBan.TabIndex = 2;
            this.buttonQuanLyBan.Text = "ĐẶT BÀN";
            this.buttonQuanLyBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyBan.UseVisualStyleBackColor = false;
            this.buttonQuanLyBan.Click += new System.EventHandler(this.buttonQuanLyBan_Click);
            // 
            // buttonBan
            // 
            this.buttonBan.AutoSize = true;
            this.buttonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonBan.FlatAppearance.BorderSize = 0;
            this.buttonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBan.ForeColor = System.Drawing.Color.White;
            this.buttonBan.Location = new System.Drawing.Point(0, 431);
            this.buttonBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(249, 72);
            this.buttonBan.TabIndex = 2;
            this.buttonBan.Text = "BÀN";
            this.buttonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBan.UseVisualStyleBackColor = false;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(222, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 895);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectRestaurantManagement.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(1635, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectRestaurantManagement.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1671, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnFormDonMon
            // 
            this.btnFormDonMon.AutoSize = true;
            this.btnFormDonMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnFormDonMon.FlatAppearance.BorderSize = 0;
            this.btnFormDonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormDonMon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDonMon.ForeColor = System.Drawing.Color.White;
            this.btnFormDonMon.Location = new System.Drawing.Point(0, 360);
            this.btnFormDonMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFormDonMon.Name = "btnFormDonMon";
            this.btnFormDonMon.Size = new System.Drawing.Size(249, 72);
            this.btnFormDonMon.TabIndex = 2;
            this.btnFormDonMon.Text = "ĐƠN MÓN";
            this.btnFormDonMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormDonMon.UseVisualStyleBackColor = false;
            this.btnFormDonMon.Click += new System.EventHandler(this.btnFormDonMon_Click_1);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1704, 937);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuanLyBan;
        private System.Windows.Forms.Button buttonThucAn;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.Button buttonDanhMuc;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button buttonCaNhan;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnFormDonMon;
    }
}