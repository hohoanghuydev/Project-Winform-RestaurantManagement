namespace ProjectRestaurantManagement
{
    partial class FormQuanLyBan
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTable.Location = new System.Drawing.Point(9, 8);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(568, 590);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.nudSoLuong);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.cbLoaiMon);
            this.panel1.Location = new System.Drawing.Point(581, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 92);
            this.panel1.TabIndex = 1;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(264, 46);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(120, 40);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click_1);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(290, 13);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(55, 23);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMon
            // 
            this.cbMon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(37, 56);
            this.cbMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(191, 24);
            this.cbMon.TabIndex = 0;
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(37, 12);
            this.cbLoaiMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(191, 24);
            this.cbLoaiMon.TabIndex = 0;
            this.cbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMon_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Controls.Add(this.labelTable);
            this.panel2.Location = new System.Drawing.Point(581, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 372);
            this.panel2.TabIndex = 1;
            // 
            // lstBill
            // 
            this.lstBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBill.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstBill.GridLines = true;
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(3, 49);
            this.lstBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(391, 322);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            this.lstBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 216;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelTable.Location = new System.Drawing.Point(110, 12);
            this.labelTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(74, 29);
            this.labelTable.TabIndex = 3;
            this.labelTable.Text = "Bàn: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTongTien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnChangeTable);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.cbChangeTable);
            this.panel3.Location = new System.Drawing.Point(581, 480);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 118);
            this.panel3.TabIndex = 1;
            // 
            // txbTongTien
            // 
            this.txbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTongTien.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.txbTongTien.Location = new System.Drawing.Point(139, 10);
            this.txbTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(244, 40);
            this.txbTongTien.TabIndex = 4;
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTable.ForeColor = System.Drawing.Color.White;
            this.btnChangeTable.Location = new System.Drawing.Point(139, 63);
            this.btnChangeTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(120, 40);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = false;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click_1);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(263, 63);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 40);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(25, 74);
            this.cbChangeTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(98, 24);
            this.cbChangeTable.TabIndex = 0;
            // 
            // FormQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuanLyBan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelTable;
    }
}