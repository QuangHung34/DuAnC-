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
    public partial class thanhtoanphong : Form
    {
        string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True;";
        public void load()
        {
            SqlConnection connection = new SqlConnection(ketnoi);
            try
            {
                connection.Open();
                string sql;
                sql = "select * from Hoadon_thanhtoan";
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
        public thanhtoanphong()
        {
            InitializeComponent();
            load();
        }

        private void thanhtoanphong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO Hoadon_thanhtoan (ma_hoadon, ten_sinhvien, so_phong, thang, so_tienphaitra) VALUES (@maHoadon, @tenSinhVien, @soPhong, @Thang, @soTienPhaiTra)";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@maHoadon", txtmhd.Text);
                    cmd.Parameters.AddWithValue("@tenSinhVien", txttsv.Text);
                    cmd.Parameters.AddWithValue("@soPhong", txtsp.Text);
                    cmd.Parameters.AddWithValue("@Thang", dtthang.Value); // Sử dụng giá trị ngày tháng trực tiếp từ DateTimePicker
                    cmd.Parameters.AddWithValue("@soTienPhaiTra", txtstpt.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                try
                {
                    connection.Open();
                    string sql = "DELETE FROM Hoadon_thanhtoan WHERE ma_hoadon = @maHoadon";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@maHoadon", txtmhd.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        load(); // Load lại dữ liệu sau khi xóa
                        clearBox();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }


        }
        private void clearBox()
        {
            txtmhd.Text = "";
            txttsv.Text = "";
            txtsp.Text = "";
            dtthang.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại
            txtstpt.Text = "";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmhd.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttsv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtsp.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            dtthang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtstpt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi))
            {
                try
                {
                    connection.Open();
                    string sql = "UPDATE Hoadon_thanhtoan SET ten_sinhvien = @tenSinhVien, so_phong = @soPhong, thang = @Thang, so_tienphaitra = @soTienPhaiTra WHERE ma_hoadon = @maHoadon";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@maHoadon", txtmhd.Text);
                    cmd.Parameters.AddWithValue("@tenSinhVien", txttsv.Text);
                    cmd.Parameters.AddWithValue("@soPhong", txtsp.Text);
                    cmd.Parameters.AddWithValue("@Thang", dtthang.Value); // Sử dụng giá trị ngày tháng trực tiếp từ DateTimePicker
                    cmd.Parameters.AddWithValue("@soTienPhaiTra", txtstpt.Text);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        load();
                        clearBox();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            reportthahtoanphong rp = new reportthahtoanphong();
            rp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timKiemMa = txtTim.Text.Trim();

            using (SqlConnection con = new SqlConnection(ketnoi))
            {
                con.Open();

                string query = "SELECT * FROM Hoadon_thanhtoan WHERE ma_hoadon LIKE @ma";
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
