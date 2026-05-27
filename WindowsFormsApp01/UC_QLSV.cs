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
    public partial class UC_QLSV : UserControl
    {
        QLsinhvienDataContext db = new QLsinhvienDataContext();
        public UC_QLSV()
        {
            InitializeComponent();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            LoadData();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            String mssv = txt_mssv.Text;
            String name = txt_name.Text;
            String gioitinh = cboGioiTinh.Text;
            DateTime dateTime = dtpNgaySinh.Value;

            Student sv = new Student();

            sv.MSSV = mssv;
            sv.FullName = name;
            sv.Gender = gioitinh;
            sv.DateOfBirth = dateTime;
            if (cbxLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Danh sách lớp học đang trống hoặc bạn chưa chọn lớp! Vui lòng kiểm tra lại CSDL.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // lấy mã lớp học từ combo box, vì combo box đã được thiết lập ValueMember là "Id" nên khi lấy SelectedValue sẽ trả về mã lớp học
            sv.ClassId = cbxLopHoc.SelectedValue.ToString();

            try
            {
                // thực hiện truy vấn thêm sinh viên vào database
                db.Students.InsertOnSubmit(sv);
                db.SubmitChanges();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        public void LoadData()
        {
            List<Student> dsSinhVien = db.Students.ToList();
            dgvSinhVien.DataSource = dsSinhVien;
            if (dgvSinhVien.Columns["Class"] != null)
            {
                dgvSinhVien.Columns["Class"].Visible = false;
            }
        }
        public void LoadLopHoc()
        {
            List<Class> dsLopHoc = db.Classes.ToList();
            cbxLopHoc.DataSource = dsLopHoc;

            // hiển thị tên , lúc lấy về lấy mã lớp 
            cbxLopHoc.DisplayMember = "ClassName"; // Tên cột hiển thị trong ComboBox
            cbxLopHoc.ValueMember = "ClassId"; // Tên cột làm giá trị (ID của lớp học)
        }
    }
}
