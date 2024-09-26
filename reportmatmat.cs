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
    public partial class reportmatmat : Form
    {
        public reportmatmat()
        {
            InitializeComponent();
        }

        private void reportmatmat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet7.mat_mat' table. You can move, or remove it, as needed.
            this.mat_matTableAdapter.Fill(this.KY_TUC_XADataSet7.mat_mat);

            this.reportViewer1.RefreshReport();
        }
    }
}
