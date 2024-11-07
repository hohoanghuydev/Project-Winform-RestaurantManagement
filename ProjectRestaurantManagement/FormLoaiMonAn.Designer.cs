namespace ProjectRestaurantManagement
{ 
partial class FormLoaiMonAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLoaiMonAn = new System.Windows.Forms.DataGridView();
            this.buttonThemLoaiMonAn = new System.Windows.Forms.Button();
            this.textBoxTenLoaiMonAn = new System.Windows.Forms.TextBox();
            this.textBoxMaLoaiMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoaLoaiMonAn = new System.Windows.Forms.Button();
            this.buttonSuaLoaiMonAn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiMonAn
            // 
            this.dataGridViewLoaiMonAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoaiMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoaiMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoaiMonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLoaiMonAn.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLoaiMonAn.Name = "dataGridViewLoaiMonAn";
            this.dataGridViewLoaiMonAn.Size = new System.Drawing.Size(540, 520);
            this.dataGridViewLoaiMonAn.TabIndex = 3;
            this.dataGridViewLoaiMonAn.Click += new System.EventHandler(this.dataGridViewLoaiMonAn_Click);
            // 
            // buttonThemLoaiMonAn
            // 
            this.buttonThemLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThemLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemLoaiMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonThemLoaiMonAn.Location = new System.Drawing.Point(12, 538);
            this.buttonThemLoaiMonAn.Name = "buttonThemLoaiMonAn";
            this.buttonThemLoaiMonAn.Size = new System.Drawing.Size(120, 40);
            this.buttonThemLoaiMonAn.TabIndex = 9;
            this.buttonThemLoaiMonAn.Text = "Thêm";
            this.buttonThemLoaiMonAn.UseVisualStyleBackColor = false;
            this.buttonThemLoaiMonAn.Click += new System.EventHandler(this.buttonThemLoaiMonAn_Click);
            // 
            // textBoxTenLoaiMonAn
            // 
            this.textBoxTenLoaiMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenLoaiMonAn.Location = new System.Drawing.Point(756, 150);
            this.textBoxTenLoaiMonAn.Name = "textBoxTenLoaiMonAn";
            this.textBoxTenLoaiMonAn.Size = new System.Drawing.Size(193, 23);
            this.textBoxTenLoaiMonAn.TabIndex = 12;
            // 
            // textBoxMaLoaiMonAn
            // 
            this.textBoxMaLoaiMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLoaiMonAn.Location = new System.Drawing.Point(756, 50);
            this.textBoxMaLoaiMonAn.Name = "textBoxMaLoaiMonAn";
            this.textBoxMaLoaiMonAn.ReadOnly = true;
            this.textBoxMaLoaiMonAn.Size = new System.Drawing.Size(196, 23);
            this.textBoxMaLoaiMonAn.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(583, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã loại món ăn";
            // 
            // buttonXoaLoaiMonAn
            // 
            this.buttonXoaLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonXoaLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaLoaiMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonXoaLoaiMonAn.Location = new System.Drawing.Point(222, 538);
            this.buttonXoaLoaiMonAn.Name = "buttonXoaLoaiMonAn";
            this.buttonXoaLoaiMonAn.Size = new System.Drawing.Size(120, 40);
            this.buttonXoaLoaiMonAn.TabIndex = 9;
            this.buttonXoaLoaiMonAn.Text = "Xóa";
            this.buttonXoaLoaiMonAn.UseVisualStyleBackColor = false;
            this.buttonXoaLoaiMonAn.Click += new System.EventHandler(this.buttonXoaLoaiMonAn_Click);
            // 
            // buttonSuaLoaiMonAn
            // 
            this.buttonSuaLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonSuaLoaiMonAn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaLoaiMonAn.ForeColor = System.Drawing.Color.White;
            this.buttonSuaLoaiMonAn.Location = new System.Drawing.Point(432, 538);
            this.buttonSuaLoaiMonAn.Name = "buttonSuaLoaiMonAn";
            this.buttonSuaLoaiMonAn.Size = new System.Drawing.Size(120, 40);
            this.buttonSuaLoaiMonAn.TabIndex = 9;
            this.buttonSuaLoaiMonAn.Text = "Sửa";
            this.buttonSuaLoaiMonAn.UseVisualStyleBackColor = false;
            this.buttonSuaLoaiMonAn.Click += new System.EventHandler(this.buttonSuaLoaiMonAn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(583, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên loại món ăn";
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(12, 538);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(120, 40);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click_1);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.Location = new System.Drawing.Point(222, 538);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(120, 40);
            this.buttonHuy.TabIndex = 9;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel3.Location = new System.Drawing.Point(558, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 591);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel2.Location = new System.Drawing.Point(758, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 3);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.Location = new System.Drawing.Point(757, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 3);
            this.panel1.TabIndex = 37;
            // 
            // FormLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonXoaLoaiMonAn);
            this.Controls.Add(this.buttonThemLoaiMonAn);
            this.Controls.Add(this.textBoxTenLoaiMonAn);
            this.Controls.Add(this.textBoxMaLoaiMonAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSuaLoaiMonAn);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewLoaiMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoaiMonAn";
            this.Text = "FormDanhMuc";
            this.Load += new System.EventHandler(this.FormLoaiMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewLoaiMonAn;
    private System.Windows.Forms.Button buttonThemLoaiMonAn;
    private System.Windows.Forms.TextBox textBoxTenLoaiMonAn;
    private System.Windows.Forms.TextBox textBoxMaLoaiMonAn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonXoaLoaiMonAn;
    private System.Windows.Forms.Button buttonSuaLoaiMonAn;
    private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}