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
    public partial class reportSinhvien : Form
    {
        public reportSinhvien()
        {
            InitializeComponent();
        }

        private void reportSinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KY_TUC_XADataSet4.sinh_vien' table. You can move, or remove it, as needed.
            this.sinh_vienTableAdapter.Fill(this.KY_TUC_XADataSet4.sinh_vien);

            this.reportViewer1.RefreshReport();
        }
    }
}
