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
    public partial class Phieuyeucau : Form
    {
        string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True;";
        public void load()
        {

            SqlConnection connection = new SqlConnection(ketnoi);

            try
            {
                connection.Open();
                string sql;
                sql = "select * from phieu_yeucau";
                SqlDataAdapter sqldt = new SqlDataAdapter(sql, ketnoi);
                DataSet ds = new DataSet();
                sqldt.Fill(ds);
                dgvPhieu.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                Console.WriteLine(ex.Message);
            }
        }
        public Phieuyeucau()
        {
            InitializeComponent();
    
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";
            String ma = txtmyc.Text;
            String ten = txtlyc.Text;
            String sdt = txtmtyc.Text;
            String diachi = txtttyc.Text;
            String msv = txtmsv.Text;

            using (SqlConnection con = new SqlConnection(ketnoi))
            {
                con.Open();

                // Kiểm tra xem mã sinh viên có tồn tại trong bảng sinh_vien không
                String checkMsv = "SELECT COUNT(*) FROM phieu_yeucau WHERE ma_sinhvien = @msv";
                using (SqlCommand checkCmd = new SqlCommand(checkMsv, con))
                {
                    checkCmd.Parameters.AddWithValue("@msv", msv);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã sinh viên tồn tại. Vui lòng nhập lại mã sinh viên.");
                        return; // Dừng lại nếu mã sinh viên không tồn tại
                    }
                }

                // Nếu mã sinh viên tồn tại, thực hiện chèn dữ liệu
                String insert = "INSERT INTO phieu_yeucau(ma_yeucau, loai_yeucau, mota_yeucau, tinhtrang_yeucau, ma_sinhvien) VALUES (@ma, @ten, @sdt, @diachi, @msv)";
                using (SqlCommand cmd = new SqlCommand(insert, con))
                {
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@msv", msv);
                    cmd.ExecuteNonQuery();
                }

                load();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhieu.CurrentRow.Index;
            txtmyc.Text = dgvPhieu.Rows[i].Cells[0].Value.ToString();
            txtlyc.Text = dgvPhieu.Rows[i].Cells[1].Value.ToString();
            txtmtyc.Text = dgvPhieu.Rows[i].Cells[2].Value.ToString();
            txtttyc.Text = dgvPhieu.Rows[i].Cells[3].Value.ToString();
            txtmsv.Text = dgvPhieu.Rows[i].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True;";           
                    String ma = txtmyc.Text;
                    String ten = txtlyc.Text;
                    String sdt = txtmtyc.Text;
                    String diachi = txtttyc.Text;
                    String msv = txtmsv.Text;
            using (SqlConnection con = new SqlConnection(ketnoi))
            {
                con.Open();

                // Kiểm tra xem mã sinh viên có tồn tại trong bảng sinh_vien không
                String checkMsv = "SELECT COUNT(*) FROM sinh_vien WHERE ma_sinhvien = @msv";
                using (SqlCommand checkCmd = new SqlCommand(checkMsv, con))
                {
                    checkCmd.Parameters.AddWithValue("@msv", msv);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã sinh viên không tồn tại. Vui lòng nhập lại mã sinh viên.");
                        return; // Dừng lại nếu mã sinh viên không tồn tại
                    }
                }

                // Nếu mã sinh viên tồn tại, thực hiện chèn dữ liệu
                String insert = "update phieu_yeucau set loai_yeucau = @ten,mota_yeucau = @sdt,tinhtrang_yeucau = @diachi,ma_sinhvien = @msv where ma_yeucau = @ma";
                using (SqlCommand cmd = new SqlCommand(insert, con))
                {
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@msv", msv);
                    cmd.ExecuteNonQuery();
                }

                load();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ketnoi))
            {
                conn.Open();
                string ma = txtmyc.Text;
                string delete = "Delete from  phieu_yeucau where ma_yeucau = @ma ";
                using (SqlCommand cmd = new SqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.ExecuteNonQuery();
                }
            }
            load();
           
        }
    
    

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phieuyeucau_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow selectedRow = dgvPhieu.Rows[e.RowIndex];
                txtmyc.Text = selectedRow.Cells["ma_yeucau"].Value.ToString();
                txtlyc.Text = selectedRow.Cells["loai_yeucau"].Value.ToString();
                txtmtyc.Text = selectedRow.Cells["mota_yeucau"].Value.ToString();
                txtttyc.Text = selectedRow.Cells["tinhtrang_yeucau"].Value.ToString();
                txtmsv.Text = selectedRow.Cells["ma_sinhvien"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timKiemMa = txtTim.Text.Trim();

            using (SqlConnection con = new SqlConnection(ketnoi))
            {
                con.Open();

                string query = "SELECT * FROM phieu_yeucau WHERE ma_yeucau  LIKE @ma";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ma", "%" + timKiemMa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPhieu.DataSource = dt;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            reportPhieuyeucau rp = new reportPhieuyeucau();
            rp.ShowDialog();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
    
    
    

