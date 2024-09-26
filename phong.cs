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
    public partial class phong : Form
    {
        SqlConnection sqlcon;
        public void load()
        {
            string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";


             sqlcon = new SqlConnection(ketnoi);

            try
            {
                sqlcon.Open();
                string sql;
                sql = "select * from phong";
                SqlDataAdapter sqldt = new SqlDataAdapter(sql, ketnoi);
                DataSet ds = new DataSet();
                sqldt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                MessageBox.Show("loi ket nói" + ex.Message);
            }
        }

        public phong()
        {
            InitializeComponent();
        }

        private void phong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(ketnoi);

            try
            {
                connection.Open();
                string sql = "insert into phong values('" + tbsophong.Text + "','" + tbsucchua.Text + "','" + tbtinhtrang.Text + "','" + dtngayktr.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("them thanh cong :");
                    load();
                }
                else
                    MessageBox.Show("them that bai:");

                connection.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                MessageBox.Show("loi ket nói" + ex.Message);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE phong Set suc_chua=@suc_chua , tinh_trang_phong=@tinh_trang_phong ,ngay_kiemtracuoi=@ngay_kiemtracuoi where so_phong=@so_phong";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        // Adding parameters to the SqlCommand
                        cmd.Parameters.AddWithValue("@so_phong", tbsophong.Text);
                        cmd.Parameters.AddWithValue("@suc_chua", tbsucchua.Text);
                        cmd.Parameters.AddWithValue("@tinh_trang_phong", tbtinhtrang.Text);
                        cmd.Parameters.AddWithValue("@ngay_kiemtracuoi", dtngayktr.Text);



                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbsophong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbsucchua.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbtinhtrang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtngayktr.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timkiemma = timkiem.Text.Trim();

            string query = "SELECT * FROM phong WHERE so_phong LIKE @so_phong";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                cmd.Parameters.AddWithValue("@so_phong", "%" + timkiemma + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string sql = "DELETE FROM phong WHERE so_phong=@so_phong And suc_chua=@suc_chua And tinh_trang_phong=@tinh_trang_phong And ngay_kiemtracuoi=@ngay_kiemtracuoi";
                SqlCommand cmd = new SqlCommand(sql, connection);

                // Thêm các tham số để ngăn chặn SQL injection
                cmd.Parameters.AddWithValue("@so_phong", tbsophong.Text);
                cmd.Parameters.AddWithValue("@suc_chua", tbsucchua.Text);
                cmd.Parameters.AddWithValue("@tinh_trang_phong", tbtinhtrang.Text);
                cmd.Parameters.AddWithValue("@ngay_kiemtracuoi", dtngayktr.Text);



                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công:");
                    load();  // Giả sử đây là phương thức để làm mới dữ liệu
                }
                else
                {
                    MessageBox.Show("Xóa thất bại:");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ReportPhong rp = new ReportPhong();
            rp.ShowDialog();
        }

        private void tbtinhtrang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
