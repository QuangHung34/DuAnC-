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
    

    public partial class Sinhvien : Form

    {
        SqlConnection sqlcon;
        string ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";
        public void load()
        {
            
            sqlcon = new SqlConnection(ketnoi);

            try
            {
                sqlcon.Open();
                string sql;
                sql = "select * from sinh_vien";
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
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            load();

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            string connectionString = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";

           
            SqlConnection connection = new SqlConnection(connectionString);
            {
                try
                {
                    connection.Open();
                    string sql = "insert into sinh_vien values('" + tbma.Text + "','" + tbten.Text + "','" + namsinh.Text + "','" + sdt.Text + "','" + phong.Text + "','" + ngayvao.Text + "','" + ngayra.Text + "','" + cbgioitinh.Text + "')";
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
                    MessageBox.Show("loi ket noi:" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            namsinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            sdt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            phong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ngayvao.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            ngayra.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            cbgioitinh.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming 'ma' is the primary key or unique identifier for the student record
                    string sql = "UPDATE sinh_vien Set ten_sinhvien=@ten_sinhvien , nam_sinh=@nam_sinh   where ma_sinhvien=@ma_sinhvien";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        // Adding parameters to the SqlCommand
                        cmd.Parameters.AddWithValue("@ma_sinhvien", tbma.Text);
                        cmd.Parameters.AddWithValue("@ten_sinhvien", tbten.Text);
                        cmd.Parameters.AddWithValue("@nam_sinh", namsinh.Text);
                        


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
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string sql = "DELETE FROM sinh_vien WHERE ma_sinhvien=@ma_sinhvien AND ten_sinhvien=@ten_sinhvien AND nam_sinh=@nam_sinh ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                // Thêm các tham số để ngăn chặn SQL injection
                cmd.Parameters.AddWithValue("@ma_sinhvien", tbma.Text);
                cmd.Parameters.AddWithValue("@ten_sinhvien", tbten.Text);
                cmd.Parameters.AddWithValue("@nam_sinh", namsinh.Text);
                

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

        private void namsinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gr1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            load();
            string timkiemma = timkiem.Text.Trim();

            string query = "SELECT * FROM sinh_vien WHERE ma_sinhvien LIKE @ma_sinhvien";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                cmd.Parameters.AddWithValue("@ma_sinhvien", "%" + timkiemma + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            reportSinhvien rp = new reportSinhvien();
            rp.ShowDialog();
        }
    }
    }

