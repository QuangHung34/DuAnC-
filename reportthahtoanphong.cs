﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapSinhvien
{
    public partial class reportthahtoanphong : Form
    {
        public reportthahtoanphong()
        {
            InitializeComponent();
        }

        private void reportthahtoanphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet6.Hoadon_thanhtoan' table. You can move, or remove it, as needed.
            this.Hoadon_thanhtoanTableAdapter.Fill(this.KY_TUC_XADataSet6.Hoadon_thanhtoan);

            this.reportViewer1.RefreshReport();
        }
    }
}
