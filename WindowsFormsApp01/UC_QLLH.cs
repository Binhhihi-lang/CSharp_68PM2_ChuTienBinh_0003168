using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public partial class UC_QLLH : UserControl
    {
        QLsinhvienDataContext db = new QLsinhvienDataContext();

        int pageSize = 10;            // Số lượng bản ghi trên 1 trang
        int currentPage = 1;          // Trang hiện tại
        int totalPages = 1;           // Tổng số trang
        string currentSearchStr = "";   // Từ khóa tìm kiếm lớp học hiện tại


        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // PHÂN TRANG + SEARCH + XÓA MỀM
        public void LoadData()
        {
            // Lọc lớp học chưa bị xóa mềm
            var query = db.Classes.Where(c => c.IsDeleted == false || c.IsDeleted == null);

            // Tìm kiếm theo cả: ID, Mã lớp hoặc Tên lớp
            if (!string.IsNullOrEmpty(currentSearchStr))
            {
                query = query.Where(c => c.ID.Contains(currentSearchStr) ||
                                         c.ClassId.Contains(currentSearchStr) ||
                                         c.ClassName.Contains(currentSearchStr));
            }

            // Tính toán tổng số trang
            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            // Phân trang bằng Skip và Take
            // Em đã gán dữ liệu đổ về vào object nên khi đổ lên giao diện thì không cần chỉ định cột 
            // Nó sẽ lấy cột trong bảng Classes để đổ lên datagridView
            var pagedData = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            // Đổ dữ liệu lên lưới dgvLopHoc
            dgvLopHoc.DataSource = pagedData;

            // Ẩn cột IsDeleted
            if (dgvLopHoc.Columns["IsDeleted"] != null) dgvLopHoc.Columns["IsDeleted"].Visible = false;

            lblPageInfo_class.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];
                //Cách 2: Em sẽ gán hàng dữ liệu vào Object Class để lên giao diện 
                Class cl = row.DataBoundItem as Class;

                if (cl != null)
                {
                    // Đổ dữ liệu ID, Mã lớp, Tên lớp lên các TextBox tương ứng
                    if (txt_id != null) txt_id.Text = cl.ID.ToString();
                    if (txt_classId != null) txt_classId.Text = cl.ClassId;
                    if (txt_className != null) txt_className.Text = cl.ClassName;
                    if (txt_classNote != null) txt_classNote.Text = cl.Note;

                    // Không cho phép sửa ID và Mã lớp
                    if (txt_id != null )
                    {
                        txt_id.Enabled = false;
                        txt_classId.Enabled = false;
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string idLop = txt_id.Text.Trim(); 
            string maLop = txt_classId.Text.Trim();
            string tenLop = txt_className.Text.Trim();
            string ghiChu = txt_classNote.Text.Trim();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã lớp và Tên lớp!", "Cảnh báo");
                return;
            }

            // Kiểm tra trùng mã lớp
            var check = db.Classes.FirstOrDefault(c => c.ClassId == maLop);
            if (check != null)
            {
                MessageBox.Show("Mã lớp này đã tồn tại trong hệ thống!", "Cảnh báo");
                return;
            }

            try
            {
                Class newClass = new Class();
                
                newClass.ID = idLop;
                newClass.ClassId = maLop;
                newClass.ClassName = tenLop;
                newClass.Note = ghiChu;
                newClass.IsDeleted = false;

                db.Classes.InsertOnSubmit(newClass);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học mới thành công!", "Thông báo");
                LoadData();
                btn_clear_class_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_edit_class_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txt_classId.Text.Trim();
                //
                Class cl = db.Classes.FirstOrDefault(c => c.ClassId == maLop);

                if (cl != null)
                {
                    cl.ClassName = txt_className.Text.Trim();
                    cl.Note = txt_classNote.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp học trên danh sách để sửa!", "Cảnh báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_delete_class_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_className.Text))
            {
                MessageBox.Show("Vui lòng click chọn lớp học trên danh sách để xóa!", "Cảnh báo");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa lớp học này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string maLop = txt_classId.Text;
                    Class cl = db.Classes.FirstOrDefault(c => c.ClassId == maLop);

                    if (cl != null)
                    {
                        cl.IsDeleted = true; // Đánh dấu xóa mềm
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo");
                        btn_clear_class_Click(null, null); // Reset form nhập liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_clear_class_Click(object sender, EventArgs e)
        {
            if (txt_id != null) txt_id.Text = ""; 
            txt_id.Text = "";
            txt_classId.Text = "";
            txt_className.Text = "";
            txt_classNote.Text = "";

            if (txt_id != null) txt_id.Enabled = false;
            if (txt_classId != null) txt_classId.Enabled = false;
           
            txt_id.Enabled = true;
            txt_classId.Enabled = true;

            // Khôi phục trạng thái tìm kiếm và phân trang ban đầu
            currentSearchStr = "";
            if (text_search_class != null) text_search_class.Text = "";
            currentPage = 1;

            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            currentSearchStr = text_search_class.Text.Trim();
            currentPage = 1; // Ép về trang đầu khi tìm kiếm mới để hiển thị chính xác số trang
            LoadData();
        }

        private void btn_head_Click(object sender, EventArgs e) // Về đầu
        {
            currentPage = 1;
            LoadData();
        }

        private void btn_previous_click_Click(object sender, EventArgs e) // Trang trước
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btn_next_click_Click(object sender, EventArgs e) // Trang sau
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void btn_tail_Click(object sender, EventArgs e) // Về cuối
        {
            currentPage = totalPages;
            LoadData();
        }

        private void btn_view_list_student_Click(object sender, EventArgs e)
        {
            // Lấy thông tin lớp học hiện tại đang hiển thị trên các ô TextBox của ông
            string maLop = txt_classId.Text.Trim();
            string tenLop = txt_className.Text.Trim();

            // Kiểm tra xem người dùng đã chọn lớp nào chưa
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng click chọn một lớp học trên danh sách trước khi xem sinh viên!", "Thông báo");
                return;
            }

            Form DSSinhVien = new DSSinhVien(maLop, tenLop);

            // Hien thi Form moi
            DSSinhVien.Show();

        }
    }
}