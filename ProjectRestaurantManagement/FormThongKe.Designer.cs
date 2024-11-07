namespace ProjectRestaurantManagement
{
    partial class FormThongKe
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDTThapNhat = new System.Windows.Forms.Label();
            this.labelthapNhat = new System.Windows.Forms.Label();
            this.labelCaoNhat = new System.Windows.Forms.Label();
            this.labelTong = new System.Windows.Forms.Label();
            this.labelDTCaoNhat = new System.Windows.Forms.Label();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxThongKe = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(485, 448);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 130);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doanh thu";
            this.columnHeader2.Width = 305;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDTThapNhat);
            this.panel1.Controls.Add(this.labelthapNhat);
            this.panel1.Controls.Add(this.labelCaoNhat);
            this.panel1.Controls.Add(this.labelTong);
            this.panel1.Controls.Add(this.labelDTCaoNhat);
            this.panel1.Controls.Add(this.labelTongDoanhThu);
            this.panel1.Location = new System.Drawing.Point(11, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 130);
            this.panel1.TabIndex = 14;
            // 
            // labelDTThapNhat
            // 
            this.labelDTThapNhat.AutoSize = true;
            this.labelDTThapNhat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDTThapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelDTThapNhat.Location = new System.Drawing.Point(259, 86);
            this.labelDTThapNhat.Name = "labelDTThapNhat";
            this.labelDTThapNhat.Size = new System.Drawing.Size(159, 23);
            this.labelDTThapNhat.TabIndex = 0;
            this.labelDTThapNhat.Text = "Chưa có dữ liệu";
            // 
            // labelthapNhat
            // 
            this.labelthapNhat.AutoSize = true;
            this.labelthapNhat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelthapNhat.Location = new System.Drawing.Point(20, 86);
            this.labelthapNhat.Name = "labelthapNhat";
            this.labelthapNhat.Size = new System.Drawing.Size(207, 23);
            this.labelthapNhat.TabIndex = 0;
            this.labelthapNhat.Text = "Doanh thu thấp nhất";
            // 
            // labelCaoNhat
            // 
            this.labelCaoNhat.AutoSize = true;
            this.labelCaoNhat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaoNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelCaoNhat.Location = new System.Drawing.Point(20, 51);
            this.labelCaoNhat.Name = "labelCaoNhat";
            this.labelCaoNhat.Size = new System.Drawing.Size(197, 23);
            this.labelCaoNhat.TabIndex = 0;
            this.labelCaoNhat.Text = "Doanh thu cao nhất";
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelTong.Location = new System.Drawing.Point(20, 18);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(161, 23);
            this.labelTong.TabIndex = 0;
            this.labelTong.Text = "Tổng doanh thu";
            // 
            // labelDTCaoNhat
            // 
            this.labelDTCaoNhat.AutoSize = true;
            this.labelDTCaoNhat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDTCaoNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelDTCaoNhat.Location = new System.Drawing.Point(259, 51);
            this.labelDTCaoNhat.Name = "labelDTCaoNhat";
            this.labelDTCaoNhat.Size = new System.Drawing.Size(159, 23);
            this.labelDTCaoNhat.TabIndex = 0;
            this.labelDTCaoNhat.Text = "Chưa có dữ liệu";
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.labelTongDoanhThu.Location = new System.Drawing.Point(259, 18);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(159, 23);
            this.labelTongDoanhThu.TabIndex = 0;
            this.labelTongDoanhThu.Text = "Chưa có dữ liệu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(341, 25);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(311, 27);
            this.dateTimePickerEnd.TabIndex = 16;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 25);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(311, 27);
            this.dateTimePickerStart.TabIndex = 15;
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(12, 58);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(948, 384);
            this.chartThongKe.TabIndex = 18;
            this.chartThongKe.Text = "chart1";
            // 
            // comboBoxThongKe
            // 
            this.comboBoxThongKe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThongKe.FormattingEnabled = true;
            this.comboBoxThongKe.Location = new System.Drawing.Point(784, 17);
            this.comboBoxThongKe.Name = "comboBoxThongKe";
            this.comboBoxThongKe.Size = new System.Drawing.Size(165, 31);
            this.comboBoxThongKe.TabIndex = 19;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.comboBoxThongKe);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDTThapNhat;
        private System.Windows.Forms.Label labelthapNhat;
        private System.Windows.Forms.Label labelCaoNhat;
        private System.Windows.Forms.Label labelTong;
        private System.Windows.Forms.Label labelDTCaoNhat;
        private System.Windows.Forms.Label labelTongDoanhThu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.ComboBox comboBoxThongKe;
    }
}