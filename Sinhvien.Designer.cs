namespace DangNhapSinhvien
{
    partial class Sinhvien
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
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbma = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.namsinh = new System.Windows.Forms.DateTimePicker();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ngayvao = new System.Windows.Forms.DateTimePicker();
            this.ngayra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbphong = new System.Windows.Forms.Label();
            this.phong = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.dataGridView1);
            this.gr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr1.Location = new System.Drawing.Point(9, 31);
            this.gr1.Margin = new System.Windows.Forms.Padding(2);
            this.gr1.Name = "gr1";
            this.gr1.Padding = new System.Windows.Forms.Padding(2);
            this.gr1.Size = new System.Drawing.Size(573, 376);
            this.gr1.TabIndex = 0;
            this.gr1.TabStop = false;
            this.gr1.Text = "Thông tin";
            this.gr1.Enter += new System.EventHandler(this.gr1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbma
            // 
            this.tbma.Location = new System.Drawing.Point(658, 59);
            this.tbma.Margin = new System.Windows.Forms.Padding(2);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(76, 20);
            this.tbma.TabIndex = 4;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(658, 107);
            this.tbten.Margin = new System.Windows.Forms.Padding(2);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(113, 20);
            this.tbten.TabIndex = 5;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(658, 192);
            this.sdt.Margin = new System.Windows.Forms.Padding(2);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(86, 20);
            this.sdt.TabIndex = 6;
            // 
            // namsinh
            // 
            this.namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.namsinh.Location = new System.Drawing.Point(658, 151);
            this.namsinh.Margin = new System.Windows.Forms.Padding(2);
            this.namsinh.Name = "namsinh";
            this.namsinh.Size = new System.Drawing.Size(76, 20);
            this.namsinh.TabIndex = 7;
            this.namsinh.ValueChanged += new System.EventHandler(this.namsinh_ValueChanged);
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbgioitinh.Location = new System.Drawing.Point(658, 354);
            this.cbgioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(76, 21);
            this.cbgioitinh.TabIndex = 8;
            this.cbgioitinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày vào";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày ra ";
            // 
            // ngayvao
            // 
            this.ngayvao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayvao.Location = new System.Drawing.Point(658, 269);
            this.ngayvao.Margin = new System.Windows.Forms.Padding(2);
            this.ngayvao.Name = "ngayvao";
            this.ngayvao.Size = new System.Drawing.Size(76, 20);
            this.ngayvao.TabIndex = 13;
            // 
            // ngayra
            // 
            this.ngayra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayra.Location = new System.Drawing.Point(658, 318);
            this.ngayra.Margin = new System.Windows.Forms.Padding(2);
            this.ngayra.Name = "ngayra";
            this.ngayra.Size = new System.Drawing.Size(76, 20);
            this.ngayra.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "sdt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(784, 93);
            this.bt1.Margin = new System.Windows.Forms.Padding(2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(56, 19);
            this.bt1.TabIndex = 16;
            this.bt1.Text = "Thêm";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 141);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(784, 197);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 412);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(784, 247);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 20;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbphong
            // 
            this.tbphong.AutoSize = true;
            this.tbphong.Location = new System.Drawing.Point(593, 228);
            this.tbphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbphong.Name = "tbphong";
            this.tbphong.Size = new System.Drawing.Size(54, 13);
            this.tbphong.TabIndex = 21;
            this.tbphong.Text = "Số Phòng";
            // 
            // phong
            // 
            this.phong.Location = new System.Drawing.Point(658, 228);
            this.phong.Margin = new System.Windows.Forms.Padding(2);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(76, 20);
            this.phong.TabIndex = 22;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(784, 361);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 23;
            this.btnXuat.Text = "Xuất Dữ Liệu";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(658, 412);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(100, 20);
            this.timkiem.TabIndex = 24;
            // 
            // Sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 453);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.phong);
            this.Controls.Add(this.tbphong);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ngayra);
            this.Controls.Add(this.ngayvao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.namsinh);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.tbma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gr1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sinhvien";
            this.Text = "Sinhvien";
            this.Load += new System.EventHandler(this.Sinhvien_Load);
            this.gr1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.DateTimePicker namsinh;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ngayvao;
        private System.Windows.Forms.DateTimePicker ngayra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label tbphong;
        private System.Windows.Forms.TextBox phong;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TextBox timkiem;
    }
}