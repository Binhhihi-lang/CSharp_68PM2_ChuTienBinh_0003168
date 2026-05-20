using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            String username = txt_username.Text;
            String password = txt_password.Text;

            if (username == "0003168@st.huce.edu.vn" && password == "0003168")
            {
                MessageBox.Show("Đăng nhập thành công");
                Form QLSinhVien  = new QLSinhVien();

                // 2. Hien thi Form moi
                QLSinhVien.Show();

                // 3. An Form hien tai (Form Quan ly Sinh vien)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
