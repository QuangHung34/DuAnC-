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
    public partial class matmat : Form
    {

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
            sql = "select * from mat_mat";
            sqlda = new SqlDataAdapter(sql, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Mã mất mát";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Mô tả mất mát";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "Ngày mất mát";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Số tiền phạt";
            dataGridView1.Columns[4].HeaderText = "Mã sinh viên ";
        }
        public matmat()
        {
            InitializeComponent();
        }

        private void matmat_Load(object sender, EventArgs e)
        {
            showdataongrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string sql;
                sql = "insert into mat_mat values(@ma_matmat,@mo_ta_matmat,@ngay_matmat,@so_tien_phat,@ma_sinhvien)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                sqlcom.Parameters.AddWithValue("@ma_matmat", tbma.Text);
                sqlcom.Parameters.AddWithValue("@mo_ta_matmat", tbmota.Text);
                sqlcom.Parameters.AddWithValue("@ngay_matmat", dtngay.Text);
                sqlcom.Parameters.AddWithValue("@so_tien_phat", tbtien.Text);
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

        private void tb3_TextChanged(object sender, EventArgs e)
        {

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
                    sql = "delete from mat_mat where ma_matmat=@ma_matmat";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    sqlcom.Parameters.AddWithValue("@ma_matmat", tbma.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string timkiemma = timkiem.Text.Trim();

            string query = "SELECT * FROM mat_mat WHERE ma_matmat LIKE @ma_matmat";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                cmd.Parameters.AddWithValue("@ma_matmat", "%" + timkiemma + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            
        }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            reportmatmat rp = new reportmatmat();
            rp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                string sql;
                sql = "UPDATE mat_mat Set mo_ta_matmat=@mo_ta_matmat,ngay_matmat=@ngay_matmat,so_tien_phat=@so_tien_phat,ma_sinhvien=@ma_sinhvien where ma_matmat=@ma_matmat";
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ma_matmat", tbma.Text);
                    cmd.Parameters.AddWithValue("@mo_ta_matmat", tbmota.Text);
                    cmd.Parameters.AddWithValue("@ngay_matmat", dtngay.Text);
                    cmd.Parameters.AddWithValue("@so_tien_phat", tbtien.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {


                this.Close();
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbmota.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtngay.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbtien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tbmasv.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }

}
