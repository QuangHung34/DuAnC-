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
    public partial class reportthoigianvangmat : Form
    {
        public reportthoigianvangmat()
        {
            InitializeComponent();
        }

        private void reportthoigianvangmat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet2.thoigian_vangmat' table. You can move, or remove it, as needed.
            this.thoigian_vangmatTableAdapter.Fill(this.KY_TUC_XADataSet2.thoigian_vangmat);

            this.reportViewer1.RefreshReport();
        }
    }
}
