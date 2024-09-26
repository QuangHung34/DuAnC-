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
    public partial class reportPhieuyeucau : Form
    {
        public reportPhieuyeucau()
        {
            InitializeComponent();
        }

        private void reportPhieuyeucau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet1.phieu_yeucau' table. You can move, or remove it, as needed.
            this.phieu_yeucauTableAdapter.Fill(this.KY_TUC_XADataSet1.phieu_yeucau);

            this.reportViewer1.RefreshReport();
        }
    }
}
