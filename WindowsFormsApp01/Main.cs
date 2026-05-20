using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public partial class Main : Form
    {
        // Khởi tạo sẵn 2 UserControl
        private UC_QLLH uc_qllh = new UC_QLLH();
        private UC_QLSV uc_qlsv = new UC_QLSV();

        public Main()
        {
            // Lệnh này bắt buộc phải gọi để nó nạp đoạn code trong Designer.cs lên màn hình
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Vừa mở lên thì nạp ngay màn hình sinh viên
            ShowUserControl(uc_qlsv);
        }

        // --- HÀM XỬ LÝ CHUYỂN TRANG ---
        private void ShowUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            ShowUserControl(uc_qllh);
            DoiTrangThaiNut(btnQLLH);
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            ShowUserControl(uc_qlsv);
            DoiTrangThaiNut(btnQLSV);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Đổi Font chữ bôi đậm
        private void DoiTrangThaiNut(Button activeBtn)
        {
            btnQLSV.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnQLLH.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            activeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
    }
}