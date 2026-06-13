namespace WindowsFormsApp01
{
    partial class UC_QLSV
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxLopHoc = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_head = new System.Windows.Forms.Button();
            this.btn_previous_click = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btn_next_click = new System.Windows.Forms.Button();
            this.btn_tail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.cbxLopHoc);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_mssv);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.lop);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(497, 453);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cbxLopHoc
            // 
            this.cbxLopHoc.FormattingEnabled = true;
            this.cbxLopHoc.Items.AddRange(new object[] {
            "68PM1",
            "68PM2"});
            this.cbxLopHoc.Location = new System.Drawing.Point(29, 363);
            this.cbxLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLopHoc.Name = "cbxLopHoc";
            this.cbxLopHoc.Size = new System.Drawing.Size(421, 24);
            this.cbxLopHoc.TabIndex = 11;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(29, 284);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(421, 24);
            this.cboGioiTinh.TabIndex = 8;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lớp môn học :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(29, 203);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(421, 22);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(29, 124);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(421, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(29, 50);
            this.txt_mssv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(421, 22);
            this.txt_mssv.TabIndex = 4;
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(33, 185);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(70, 16);
            this.ngaysinh.TabIndex = 3;
            this.ngaysinh.Text = "Ngày sinh:";
            // 
            // lop
            // 
            this.lop.AutoSize = true;
            this.lop.Location = new System.Drawing.Point(33, 266);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(57, 16);
            this.lop.TabIndex = 2;
            this.lop.Text = "Giới tính:";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(34, 106);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(67, 16);
            this.hoten.TabIndex = 1;
            this.hoten.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên:";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add.Location = new System.Drawing.Point(0, 483);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(244, 50);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_edit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_edit.Location = new System.Drawing.Point(249, 483);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(248, 50);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(0, 538);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(244, 50);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_clear.Location = new System.Drawing.Point(249, 538);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(248, 50);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(524, 109);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(720, 382);
            this.dgvSinhVien.TabIndex = 12;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(525, 45);
            this.text_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(421, 22);
            this.text_search.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(521, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tìm kiếm (Tên/MSSV/Lớp)";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(950, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 34);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_head
            // 
            this.btn_head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_head.Location = new System.Drawing.Point(688, 512);
            this.btn_head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_head.Name = "btn_head";
            this.btn_head.Size = new System.Drawing.Size(62, 46);
            this.btn_head.TabIndex = 17;
            this.btn_head.Text = "<<";
            this.btn_head.UseVisualStyleBackColor = true;
            this.btn_head.Click += new System.EventHandler(this.btn_head_Click);
            // 
            // btn_previous_click
            // 
            this.btn_previous_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_previous_click.Location = new System.Drawing.Point(746, 512);
            this.btn_previous_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_previous_click.Name = "btn_previous_click";
            this.btn_previous_click.Size = new System.Drawing.Size(62, 46);
            this.btn_previous_click.TabIndex = 18;
            this.btn_previous_click.Text = "<";
            this.btn_previous_click.UseVisualStyleBackColor = true;
            this.btn_previous_click.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(837, 526);
            this.lblPageInfo.Name = "label4";
            this.lblPageInfo.Size = new System.Drawing.Size(127, 16);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "Trang 1/1 | 2 bản ghi";
            // 
            // btn_next_click
            // 
            this.btn_next_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next_click.Location = new System.Drawing.Point(1013, 512);
            this.btn_next_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next_click.Name = "btn_next_click";
            this.btn_next_click.Size = new System.Drawing.Size(62, 46);
            this.btn_next_click.TabIndex = 20;
            this.btn_next_click.Text = ">";
            this.btn_next_click.UseVisualStyleBackColor = true;
            this.btn_next_click.Click += new System.EventHandler(this.btn_next_click_Click);
            // 
            // btn_tail
            // 
            this.btn_tail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tail.Location = new System.Drawing.Point(1071, 512);
            this.btn_tail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tail.Name = "btn_tail";
            this.btn_tail.Size = new System.Drawing.Size(62, 46);
            this.btn_tail.TabIndex = 21;
            this.btn_tail.Text = ">>";
            this.btn_tail.UseVisualStyleBackColor = true;
            this.btn_tail.Click += new System.EventHandler(this.btn_tail_Click);
            // 
            // UC_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_tail);
            this.Controls.Add(this.btn_next_click);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btn_previous_click);
            this.Controls.Add(this.btn_head);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_QLSV";
            this.Size = new System.Drawing.Size(1255, 608);
            this.Load += new System.EventHandler(this.UC_QLSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxLopHoc;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_head;
        private System.Windows.Forms.Button btn_previous_click;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btn_next_click;
        private System.Windows.Forms.Button btn_tail;
    }
}
