using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapSinhvien
{
    public partial class frmLogin : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nguoidung, password;
            nguoidung = txtTaiKhoan.Text;
            password = txtMatKhau.Text;
            try
            {
                String query = "SELECT * FROM DangNhap  WHERE TaiKhoan = '" + txtTaiKhoan.Text + "' AND MatKhau = '" + txtMatKhau.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nguoidung = txtTaiKhoan.Text;
                    password = txtMatKhau.Text;
                    this.Hide();
                    Luachonform frm2 = new Luachonform();
                    frm2.ShowDialog();
                    frm2 = null;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Chưa kết nối tới SQL !!!");
                throw;
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
