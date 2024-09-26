using System;
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
    public partial class reportlichsuchuyenphong : Form
    {
        public reportlichsuchuyenphong()
        {
            InitializeComponent();
        }

        private void reportlichsuchuyenphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet8.lichsu_chuyenphong' table. You can move, or remove it, as needed.
            this.lichsu_chuyenphongTableAdapter.Fill(this.KY_TUC_XADataSet8.lichsu_chuyenphong);

            this.reportViewer1.RefreshReport();
        }
    }
}
