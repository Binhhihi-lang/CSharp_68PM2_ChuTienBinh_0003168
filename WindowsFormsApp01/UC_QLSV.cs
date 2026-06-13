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
        int pageSize = 10;          // Số lượng bản ghi trên 1 trang (10 sinh viên)
        int currentPage = 1;        // Trang hiện tại
        int totalPages = 1;         // Tổng số trang
        string currentSearchStr = ""; // Lưu trữ từ khóa tìm kiếm hiện tại
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
        // Chọn Sinh Viên khi chọn hiển thị lên 
        // bắt sự kiện cho nút sửa 
        // khi bấm vào nút sửa với , không cho phép sửa mssv 
        // Xóa chọn vào 1 sinh viên , khi người dùng chọn sinh viên dgrv 
        // xóa mềm : update , agentdelete: false , 
        // xóa cứng: Delete and submit 
        // where biến đánh dấu thể hiện xóa mềm = false 
        // Nút làm mới đặt giá trị mặc định : ngày thì ngày hiện thời 
        // Phân trang cùng 1 hàm : 2 giá trị : số lượng bản ghi trên 1 trang (pageSize) và currentPage ,trang 1: 1-10, trang 2 lấy bản ghi từ 11 đến 20
        // trang 3 21 đến 30 (x-1)* 10+1 đến x*10 
        // skip bỏ qua bao nhiêu bản ghi và lấy bản ghi thứ bao nhiêu 
        // search Student 

        // QL lớp học 
        // Tạo form quản lý lớp học tương tự như quản lý sinh viên, có các chức năng thêm, sửa, xóa, tìm kiếm và phân trang.
        // xem 
        public void LoadData()
        {
            // 1. Lấy toàn bộ dữ liệu CHƯA BỊ XÓA MỀM (IsDeleted == false)
            var query = db.Students.Where(s => s.IsDeleted == false || s.IsDeleted == null);

            // 2. Nếu có từ khóa tìm kiếm thì áp dụng bộ lọc (Tìm theo Tên, MSSV hoặc Lớp)
            if (!string.IsNullOrEmpty(currentSearchStr))
            {
                // lấy sinh viên nào mà có từ khóa 
                query = query.Where(s => s.FullName.Contains(currentSearchStr) ||
                                         s.MSSV.Contains(currentSearchStr) ||
                                         s.ClassId.Contains(currentSearchStr));
            }

            // 3. Tính toán tổng số trang
            int totalRecords = query.Count();
            // làm tròn lên 
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages == 0) totalPages = 1; // Nếu không có dữ liệu thì vẫn tính là trang 1
            if (currentPage > totalPages) currentPage = totalPages;

            // Lấy danh sách phân trang 
            // Skip: Bỏ qua các bản ghi của trang trước. Take: Chỉ lấy đúng 10 bản ghi cho trang này.
            var pagedData = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

           
            dgvSinhVien.DataSource = pagedData;

            if (dgvSinhVien.Columns["Class"] != null)
            {
                dgvSinhVien.Columns["Class"].Visible = false;
            }
            // bỏ qua cột IsDeleted 
            if (dgvSinhVien.Columns["IsDeleted"] != null)
            {
                dgvSinhVien.Columns["IsDeleted"].Visible = false;
            }
            lblPageInfo.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";
        }

        public void LoadLopHoc()
        {
            List<Class> dsLopHoc = db.Classes.ToList();
            cbxLopHoc.DataSource = dsLopHoc;

            // hiển thị tên , lúc lấy về lấy mã lớp 
            cbxLopHoc.DisplayMember = "ClassName"; // Tên cột hiển thị trong ComboBox
            cbxLopHoc.ValueMember = "ClassId"; // Tên cột làm giá trị (ID của lớp học)
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = txt_mssv.Text;
                // Tìm sinh viên theo MSSV đang hiển thị
                Student sv = db.Students.FirstOrDefault(s => s.MSSV == mssv);

                if (sv != null)
                {
                    sv.FullName = txt_name.Text;
                    sv.Gender = cboGioiTinh.Text;
                    sv.DateOfBirth = dtpNgaySinh.Value;
                    sv.ClassId = cbxLopHoc.SelectedValue?.ToString();

                    db.SubmitChanges(); // Lưu thay đổi
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mssv.Text = "";
            txt_name.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            cbxLopHoc.SelectedIndex = 0;

            // Ngày thì lấy ngày hiện thời
            dtpNgaySinh.Value = DateTime.Now;

            // Mở khóa lại ô MSSV để cho phép Thêm mới
            txt_mssv.Enabled = true;

            // Reset trạng thái tìm kiếm và phân trang
            currentSearchStr = "";
            if (text_search != null) text_search.Text = ""; // Xóa text ở ô tìm kiếm nếu có
            currentPage = 1;

            LoadData();
        }
        // phân trang 
        private void btn_head_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        // previous click 
        private void button7_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btn_next_click_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void btn_tail_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData();
        }

        // tìm kiếm theo tên , mssv , lớp học
        private void btn_search_Click(object sender, EventArgs e)
        {
            // Cập nhật từ khóa và ép load lại từ trang 1
            currentSearchStr = text_search.Text.Trim(); 
            currentPage = 1;
            LoadData();
        }


        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // C1 của thầy dòng dữ liệu sẽ lấy cột trong bảng sẽ set lên giao diên 
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txt_mssv.Text = row.Cells["MSSV"].Value?.ToString();
                txt_name.Text = row.Cells["FullName"].Value?.ToString();
                cboGioiTinh.Text = row.Cells["Gender"].Value?.ToString();

                if (row.Cells["DateOfBirth"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                }

                cbxLopHoc.SelectedValue = row.Cells["ClassId"].Value?.ToString();

                txt_mssv.Enabled = false;
            }
        }

    }
}
