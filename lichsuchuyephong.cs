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
    public partial class lichsuchuyephong : Form
    {

        public lichsuchuyephong()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon;
        DataSet ds;
        SqlDataAdapter sqlda;
        public void connect()
        {
            //Bước 1: Tạo kết nối csdl
            string ketnoi;
            ketnoi = "Data Source=QUANGHƯNG;Initial Catalog=KY_TUC_XA;Integrated Security=True";
            sqlcon = new SqlConnection(ketnoi);
            //Bước 2: Mở kết nối
            sqlcon.Open();
        }
        public void closeconnect()
        {
            sqlcon.Close();
            sqlcon.Dispose();
        }
        public void showdataongrid()
        {
            connect();
            string sql;
            sql = "select * from lichsu_chuyenphong";
            sqlda = new SqlDataAdapter(sql, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Mã chuyển phong";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Số phòng cũ";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Số phòng mơi";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "ngay chuyển phòng";
            dataGridView1.Columns[4].HeaderText = "Mã sinh viên";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lichsuchuyephong_Load(object sender, EventArgs e)
        {
            showdataongrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reportlichsuchuyenphong rp = new reportlichsuchuyenphong();
            rp.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string sql;
                sql = "insert into lichsu_chuyenphong values(@machuyen_phong,@so_phongcu,@so_phongmoi,@ngay_chuyenphong,@ma_sinhvien)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                sqlcom.Parameters.AddWithValue("@machuyen_phong", tbma.Text);
                sqlcom.Parameters.AddWithValue("@so_phongcu", tbphongcu.Text);
                sqlcom.Parameters.AddWithValue("@so_phongmoi", tbphongmoi.Text);
                sqlcom.Parameters.AddWithValue("@ngay_chuyenphong", dtngay.Text);
                sqlcom.Parameters.AddWithValue("@ma_sinhvien", tbmasv.Text);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    showdataongrid();

                    MessageBox.Show("Bạn đã thêm thành công ", "Thêm dữ liệu");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống báo lỗi:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string sql;
                sql = "UPDATE lichsu_chuyenphong Set so_phongcu=@so_phongcu,so_phongmoi=@so_phongmoi,ngay_chuyenphong=@ngay_chuyenphong,ma_sinhvien=@ma_sinhvien where ma_chuyenphong=@ma_chuyenphong";
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ma_chuyenphong", tbma.Text);
                    cmd.Parameters.AddWithValue("@so_phongcu", tbphongcu.Text);
                    cmd.Parameters.AddWithValue("@so_phongmoi", tbphongmoi.Text);
                    cmd.Parameters.AddWithValue("@ngay_chuyenphong", dtngay.Text);
                    cmd.Parameters.AddWithValue("@ma_sinhvien", tbmasv.Text);
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        connect();
                        showdataongrid();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {
                    connect();
                    string sql;
                    sql = "delete from lichsu_chuyenphong where ma_chuyenphong=@ma_chuyenphong";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    sqlcom.Parameters.AddWithValue("@ma_chuyenphong", tbma.Text);
                    int kq = sqlcom.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        showdataongrid();

                        MessageBox.Show("Bạn đã xóa thành công :" + tbma.Text, "Xóa dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hệ thống báo lỗi:" + ex.Message);
                    //MessageBox.Show("Bạn chưa thêm được sinh viên mới vì trùng mã sinh viên", "Thêm dữ liệu");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbphongcu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbphongmoi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtngay.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tbmasv.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string timkiemma = timkiem.Text.Trim();

            string query = "SELECT * FROM lichsu_chuyenphong WHERE ma_chuyenphong LIKE @ma_chuyenphong";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                cmd.Parameters.AddWithValue("@ma_chuyenphong", "%" + timkiemma + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
