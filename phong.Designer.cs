namespace DangNhapSinhvien
{
    partial class phong
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsophong = new System.Windows.Forms.TextBox();
            this.tbsucchua = new System.Windows.Forms.TextBox();
            this.tbtinhtrang = new System.Windows.Forms.TextBox();
            this.dtngayktr = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(506, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sức chứa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ngay kiểm tra";
            // 
            // tbsophong
            // 
            this.tbsophong.Location = new System.Drawing.Point(104, 228);
            this.tbsophong.Margin = new System.Windows.Forms.Padding(2);
            this.tbsophong.Name = "tbsophong";
            this.tbsophong.Size = new System.Drawing.Size(76, 20);
            this.tbsophong.TabIndex = 5;
            // 
            // tbsucchua
            // 
            this.tbsucchua.Location = new System.Drawing.Point(104, 284);
            this.tbsucchua.Margin = new System.Windows.Forms.Padding(2);
            this.tbsucchua.Name = "tbsucchua";
            this.tbsucchua.Size = new System.Drawing.Size(76, 20);
            this.tbsucchua.TabIndex = 6;
            // 
            // tbtinhtrang
            // 
            this.tbtinhtrang.Location = new System.Drawing.Point(275, 228);
            this.tbtinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.tbtinhtrang.Name = "tbtinhtrang";
            this.tbtinhtrang.Size = new System.Drawing.Size(76, 20);
            this.tbtinhtrang.TabIndex = 7;
            this.tbtinhtrang.TextChanged += new System.EventHandler(this.tbtinhtrang_TextChanged);
            // 
            // dtngayktr
            // 
            this.dtngayktr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayktr.Location = new System.Drawing.Point(275, 284);
            this.dtngayktr.Margin = new System.Windows.Forms.Padding(2);
            this.dtngayktr.Name = "dtngayktr";
            this.dtngayktr.Size = new System.Drawing.Size(76, 20);
            this.dtngayktr.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(496, 222);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(56, 19);
            this.sua.TabIndex = 10;
            this.sua.Text = "Sửa ";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 11;
            this.button3.Text = "xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(209, 339);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 12;
            this.button4.Text = "tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(496, 281);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 13;
            this.button5.Text = "thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(335, 335);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(94, 23);
            this.btnXuat.TabIndex = 14;
            this.btnXuat.Text = "Xuất Dữ Liệu";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(80, 337);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(100, 20);
            this.timkiem.TabIndex = 15;
            // 
            // phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtngayktr);
            this.Controls.Add(this.tbtinhtrang);
            this.Controls.Add(this.tbsucchua);
            this.Controls.Add(this.tbsophong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "phong";
            this.Text = "phong";
            this.Load += new System.EventHandler(this.phong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsophong;
        private System.Windows.Forms.TextBox tbsucchua;
        private System.Windows.Forms.TextBox tbtinhtrang;
        private System.Windows.Forms.DateTimePicker dtngayktr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TextBox timkiem;
    }
}