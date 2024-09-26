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
    public partial class thoigianvangmat : Form
    {
        string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True;";

        public thoigianvangmat()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmpv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dtnv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtmsv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO thoigian_vangmat (ma_phieuvangmat, ngayvang, ma_sinhvien) VALUES (@maPhieuVangMat, @ngayVang, @maSinhVien)";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@maPhieuVangMat", txtmpv.Text);
                    cmd.Parameters.AddWithValue("@ngayVang", dtnv.Value); // Sử dụng giá trị ngày từ DateTimePicker
                    cmd.Parameters.AddWithValue("@maSinhVien", txtmsv.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                try
                {
                    connection.Open();
                    String ma = txtmpv.Text;
                    string sql = "DELETE FROM thoigian_vangmat WHERE ma_phieuvangmat = @ma";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@ma", ma);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        HienThiDuLieu(); // Load lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa!");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void thoigianvangmat_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            SqlConnection connection = new SqlConnection(ketnoi);
            try
            {
                connection.Open();
                string sql;
                sql = "select * from thoigian_vangmat";
                SqlDataAdapter sqldt = new SqlDataAdapter(sql, ketnoi);
                DataSet ds = new DataSet();
                sqldt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmpv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dtnv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtmsv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            reportthoigianvangmat rp = new reportthoigianvangmat();
            rp.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string timKiemMa = txtTim.Text.Trim();

            using (SqlConnection con = new SqlConnection(ketnoi))
            {
                con.Open();

                string query = "SELECT * FROM thoigian_vangmat WHERE ma_phieuvangmat LIKE @ma";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ma", "%" + timKiemMa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
