namespace ProjectRestaurantManagement
{
    partial class FormBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBan = new System.Windows.Forms.DataGridView();
            this.buttonSuaBan = new System.Windows.Forms.Button();
            this.buttonXoaBan = new System.Windows.Forms.Button();
            this.buttonThemBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenBan = new System.Windows.Forms.TextBox();
            this.textBoxMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBan
            // 
            this.dataGridViewBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(125)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBan.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewBan.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewBan.Name = "dataGridViewBan";
            this.dataGridViewBan.RowHeadersWidth = 62;
            this.dataGridViewBan.Size = new System.Drawing.Size(540, 520);
            this.dataGridViewBan.TabIndex = 3;
            this.dataGridViewBan.Click += new System.EventHandler(this.dataGridViewBan_Click);
            // 
            // buttonSuaBan
            // 
            this.buttonSuaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonSuaBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaBan.ForeColor = System.Drawing.Color.White;
            this.buttonSuaBan.Location = new System.Drawing.Point(432, 538);
            this.buttonSuaBan.Name = "buttonSuaBan";
            this.buttonSuaBan.Size = new System.Drawing.Size(120, 40);
            this.buttonSuaBan.TabIndex = 4;
            this.buttonSuaBan.Text = "Sửa";
            this.buttonSuaBan.UseVisualStyleBackColor = false;
            this.buttonSuaBan.Click += new System.EventHandler(this.buttonSuaBan_Click);
            // 
            // buttonXoaBan
            // 
            this.buttonXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonXoaBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaBan.ForeColor = System.Drawing.Color.White;
            this.buttonXoaBan.Location = new System.Drawing.Point(216, 538);
            this.buttonXoaBan.Name = "buttonXoaBan";
            this.buttonXoaBan.Size = new System.Drawing.Size(120, 40);
            this.buttonXoaBan.TabIndex = 5;
            this.buttonXoaBan.Text = "Xóa";
            this.buttonXoaBan.UseVisualStyleBackColor = false;
            this.buttonXoaBan.Click += new System.EventHandler(this.buttonXoaBan_Click);
            // 
            // buttonThemBan
            // 
            this.buttonThemBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonThemBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemBan.ForeColor = System.Drawing.Color.White;
            this.buttonThemBan.Location = new System.Drawing.Point(12, 538);
            this.buttonThemBan.Name = "buttonThemBan";
            this.buttonThemBan.Size = new System.Drawing.Size(120, 40);
            this.buttonThemBan.TabIndex = 6;
            this.buttonThemBan.Text = "Thêm";
            this.buttonThemBan.UseVisualStyleBackColor = false;
            this.buttonThemBan.Click += new System.EventHandler(this.buttonThemBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(625, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã bàn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTenBan
            // 
            this.textBoxTenBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenBan.Location = new System.Drawing.Point(756, 150);
            this.textBoxTenBan.Name = "textBoxTenBan";
            this.textBoxTenBan.Size = new System.Drawing.Size(196, 23);
            this.textBoxTenBan.TabIndex = 7;
            this.textBoxTenBan.TextChanged += new System.EventHandler(this.textBoxTenBan_TextChanged);
            // 
            // textBoxMaBan
            // 
            this.textBoxMaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaBan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaBan.Location = new System.Drawing.Point(756, 50);
            this.textBoxMaBan.Name = "textBoxMaBan";
            this.textBoxMaBan.ReadOnly = true;
            this.textBoxMaBan.Size = new System.Drawing.Size(196, 23);
            this.textBoxMaBan.TabIndex = 8;
            this.textBoxMaBan.TextChanged += new System.EventHandler(this.textBoxMaBan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(625, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên bàn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.Location = new System.Drawing.Point(216, 538);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(120, 40);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.buttonLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(12, 538);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(120, 40);
            this.buttonLuu.TabIndex = 12;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel3.Location = new System.Drawing.Point(568, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 591);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel2.Location = new System.Drawing.Point(756, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 3);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.panel1.Location = new System.Drawing.Point(755, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 3);
            this.panel1.TabIndex = 38;
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonXoaBan);
            this.Controls.Add(this.buttonThemBan);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTenBan);
            this.Controls.Add(this.textBoxMaBan);
            this.Controls.Add(this.buttonSuaBan);
            this.Controls.Add(this.dataGridViewBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBan";
            this.Text = "FormBan";
            this.Load += new System.EventHandler(this.FormBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBan;
        private System.Windows.Forms.Button buttonSuaBan;
        private System.Windows.Forms.Button buttonXoaBan;
        private System.Windows.Forms.Button buttonThemBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenBan;
        private System.Windows.Forms.TextBox textBoxMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}