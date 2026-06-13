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
    public partial class DSSinhVien : Form
    {
        QLsinhvienDataContext db = new QLsinhvienDataContext();

        private string _classId;
        private string _className;

        // khởi tạo forem với tham số được truyền từ QLLH 
        public DSSinhVien(string classId, string className)
        {
            InitializeComponent();
            this._classId = classId;
            this._className = className;
        }
        private void OnLoadDsSinhVien(object sender, EventArgs e)
        {
            // hiển thị tiêu đề động 
            lblTitle.Text = $"Danh sách sinh viên - Lớp: {_classId} - {_className}";

            // Gọi hàm nạp dữ liệu sinh viên
            LoadDataSinhVien();
        }

        private void LoadDataSinhVien()
        {
            try
            {
                // Tìm những sinh viên có thuộc tính ClassId trùng với lớp đang xem
                var query = db.Students
                    .Where(s => s.ClassId == _classId)
                              .Where(s => s.IsDeleted == false || s.IsDeleted == null)
                              .Select(s => new
                              {
                                  MaSV = s.MSSV,       
                                  HoTen = s.FullName,     
                                  GioiTinh = s.Gender,      
                                  NgaySinh = s.DateOfBirth, 
                                  Lop = _classId
                              }).ToList();

                // Đổ dữ liệu vào lưới DataGridView
                dgvSinhVien.DataSource = query;

                // hiện thị lên giao diện 
                if (dgvSinhVien.Columns["MaSV"] != null) dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                if (dgvSinhVien.Columns["HoTen"] != null) dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và tên";
                if (dgvSinhVien.Columns["GioiTinh"] != null) dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                if (dgvSinhVien.Columns["NgaySinh"] != null) dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                if (dgvSinhVien.Columns["Lop"] != null) dgvSinhVien.Columns["Lop"].HeaderText = "Lớp";

                if (dgvSinhVien.Columns["NgaySinh"] != null)
                {
                    dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Cập nhật số lượng đếm tổng số sinh viên lên giao diện
                lblTotal.Text = $"Tổng số: {query.Count} sinh viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải danh sách sinh viên: " + ex.Message, "Thông báo lỗi");
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
