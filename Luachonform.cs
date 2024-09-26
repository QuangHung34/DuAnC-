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
    public partial class Luachonform : Form
    {
        public Luachonform()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(childForm);
            pictureBox1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            sv.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            phong a = new phong();
            a.ShowDialog();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matmat a = new matmat();
            a.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thoigianvangmat a = new thoigianvangmat();  
            a.ShowDialog();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phieuyeucau a = new Phieuyeucau();
            a.ShowDialog();
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lichsuchuyephong a = new lichsuchuyephong();    
            a.ShowDialog();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thanhtoanphong a = new thanhtoanphong();
            a.ShowDialog();
         
        }

        private void Luachonform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            sv.Show();
            this.Close();
        }
    }
}
