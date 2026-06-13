namespace WindowsFormsApp01
{
    partial class UC_QLLH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_classNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_className = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_classId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_class = new System.Windows.Forms.Button();
            this.btn_edit_class = new System.Windows.Forms.Button();
            this.btn_delete_class = new System.Windows.Forms.Button();
            this.btn_clear_class = new System.Windows.Forms.Button();
            this.btn_view_list_student = new System.Windows.Forms.Button();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.text_search_class = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.btn_tail = new System.Windows.Forms.Button();
            this.btn_next_click = new System.Windows.Forms.Button();
            this.lblPageInfo_class = new System.Windows.Forms.Label();
            this.btn_previous_click = new System.Windows.Forms.Button();
            this.btn_head = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txt_classNote);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_className);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_classId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(361, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // txt_classNote
            // 
            this.txt_classNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_classNote.Location = new System.Drawing.Point(20, 235);
            this.txt_classNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_classNote.Name = "txt_classNote";
            this.txt_classNote.Size = new System.Drawing.Size(304, 27);
            this.txt_classNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(16, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú:";
            // 
            // txt_className
            // 
            this.txt_className.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_className.Location = new System.Drawing.Point(20, 175);
            this.txt_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(304, 27);
            this.txt_className.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên lớp:";
            // 
            // txt_classId
            // 
            this.txt_classId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_classId.Location = new System.Drawing.Point(20, 115);
            this.txt_classId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_classId.Name = "txt_classId";
            this.txt_classId.Size = new System.Drawing.Size(304, 27);
            this.txt_classId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lớp:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.Location = new System.Drawing.Point(20, 55);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(304, 27);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID:";
            // 
            // btn_add_class
            // 
            this.btn_add_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_add_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_class.ForeColor = System.Drawing.Color.White;
            this.btn_add_class.Location = new System.Drawing.Point(16, 405);
            this.btn_add_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(168, 44);
            this.btn_add_class.TabIndex = 1;
            this.btn_add_class.Text = "Thêm";
            this.btn_add_class.UseVisualStyleBackColor = false;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit_class
            // 
            this.btn_edit_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_edit_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_edit_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_class.ForeColor = System.Drawing.Color.White;
            this.btn_edit_class.Location = new System.Drawing.Point(205, 405);
            this.btn_edit_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit_class.Name = "btn_edit_class";
            this.btn_edit_class.Size = new System.Drawing.Size(172, 44);
            this.btn_edit_class.TabIndex = 2;
            this.btn_edit_class.Text = "Sửa";
            this.btn_edit_class.UseVisualStyleBackColor = false;
            this.btn_edit_class.Click += new System.EventHandler(this.btn_edit_class_Click);
            // 
            // btn_delete_class
            // 
            this.btn_delete_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_delete_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_class.ForeColor = System.Drawing.Color.White;
            this.btn_delete_class.Location = new System.Drawing.Point(16, 453);
            this.btn_delete_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_class.Name = "btn_delete_class";
            this.btn_delete_class.Size = new System.Drawing.Size(168, 44);
            this.btn_delete_class.TabIndex = 3;
            this.btn_delete_class.Text = "Xóa";
            this.btn_delete_class.UseVisualStyleBackColor = false;
            this.btn_delete_class.Click += new System.EventHandler(this.btn_delete_class_Click);
            // 
            // btn_clear_class
            // 
            this.btn_clear_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_clear_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_class.ForeColor = System.Drawing.Color.White;
            this.btn_clear_class.Location = new System.Drawing.Point(205, 453);
            this.btn_clear_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_class.Name = "btn_clear_class";
            this.btn_clear_class.Size = new System.Drawing.Size(172, 44);
            this.btn_clear_class.TabIndex = 4;
            this.btn_clear_class.Text = "Làm mới";
            this.btn_clear_class.UseVisualStyleBackColor = false;
            this.btn_clear_class.Click += new System.EventHandler(this.btn_clear_class_Click);
            // 
            // btn_view_list_student
            // 
            this.btn_view_list_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_view_list_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_view_list_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_list_student.ForeColor = System.Drawing.Color.White;
            this.btn_view_list_student.Location = new System.Drawing.Point(16, 501);
            this.btn_view_list_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_view_list_student.Name = "btn_view_list_student";
            this.btn_view_list_student.Size = new System.Drawing.Size(361, 34);
            this.btn_view_list_student.TabIndex = 5;
            this.btn_view_list_student.Text = "Xem danh sách sinh viên";
            this.btn_view_list_student.UseVisualStyleBackColor = false;
            this.btn_view_list_student.Click += new System.EventHandler(this.btn_view_list_student_Click);
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTimKiem.Location = new System.Drawing.Point(425, 18);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(265, 20);
            this.labelTimKiem.TabIndex = 6;
            this.labelTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            // 
            // text_search_class
            // 
            this.text_search_class.Location = new System.Drawing.Point(429, 44);
            this.text_search_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_search_class.Name = "text_search_class";
            this.text_search_class.Size = new System.Drawing.Size(181, 22);
            this.text_search_class.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(620, 40);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Location = new System.Drawing.Point(429, 80);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 29;
            this.dgvLopHoc.Size = new System.Drawing.Size(581, 421);
            this.dgvLopHoc.TabIndex = 9;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);
            // 
            // btn_tail
            // 
            this.btn_tail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tail.Location = new System.Drawing.Point(870, 505);
            this.btn_tail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tail.Name = "btn_tail";
            this.btn_tail.Size = new System.Drawing.Size(62, 46);
            this.btn_tail.TabIndex = 26;
            this.btn_tail.Text = ">>";
            this.btn_tail.UseVisualStyleBackColor = true;
            this.btn_tail.Click += new System.EventHandler(this.btn_tail_Click);
            // 
            // btn_next_click
            // 
            this.btn_next_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next_click.Location = new System.Drawing.Point(812, 505);
            this.btn_next_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next_click.Name = "btn_next_click";
            this.btn_next_click.Size = new System.Drawing.Size(62, 46);
            this.btn_next_click.TabIndex = 25;
            this.btn_next_click.Text = ">";
            this.btn_next_click.UseVisualStyleBackColor = true;
            this.btn_next_click.Click += new System.EventHandler(this.btn_next_click_Click);
            // 
            // lblPageInfo_class
            // 
            this.lblPageInfo_class.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageInfo_class.AutoSize = true;
            this.lblPageInfo_class.Location = new System.Drawing.Point(636, 519);
            this.lblPageInfo_class.Name = "lblPageInfo_class";
            this.lblPageInfo_class.Size = new System.Drawing.Size(127, 16);
            this.lblPageInfo_class.TabIndex = 24;
            this.lblPageInfo_class.Text = "Trang 1/1 | 2 bản ghi";
            // 
            // btn_previous_click
            // 
            this.btn_previous_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_previous_click.Location = new System.Drawing.Point(545, 505);
            this.btn_previous_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_previous_click.Name = "btn_previous_click";
            this.btn_previous_click.Size = new System.Drawing.Size(62, 46);
            this.btn_previous_click.TabIndex = 23;
            this.btn_previous_click.Text = "<";
            this.btn_previous_click.UseVisualStyleBackColor = true;
            this.btn_previous_click.Click += new System.EventHandler(this.btn_previous_click_Click);
            // 
            // btn_head
            // 
            this.btn_head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_head.Location = new System.Drawing.Point(487, 505);
            this.btn_head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_head.Name = "btn_head";
            this.btn_head.Size = new System.Drawing.Size(62, 46);
            this.btn_head.TabIndex = 22;
            this.btn_head.Text = "<<";
            this.btn_head.UseVisualStyleBackColor = true;
            this.btn_head.Click += new System.EventHandler(this.btn_head_Click);
            // 
            // UC_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_tail);
            this.Controls.Add(this.btn_next_click);
            this.Controls.Add(this.lblPageInfo_class);
            this.Controls.Add(this.btn_previous_click);
            this.Controls.Add(this.btn_head);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.text_search_class);
            this.Controls.Add(this.labelTimKiem);
            this.Controls.Add(this.btn_view_list_student);
            this.Controls.Add(this.btn_clear_class);
            this.Controls.Add(this.btn_delete_class);
            this.Controls.Add(this.btn_edit_class);
            this.Controls.Add(this.btn_add_class);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_QLLH";
            this.Size = new System.Drawing.Size(1030, 557);
            this.Load += new System.EventHandler(this.UC_QLLH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_classNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_className;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_classId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_class;
        private System.Windows.Forms.Button btn_edit_class;
        private System.Windows.Forms.Button btn_delete_class;
        private System.Windows.Forms.Button btn_clear_class;
        private System.Windows.Forms.Button btn_view_list_student;
        private System.Windows.Forms.Label labelTimKiem;
        private System.Windows.Forms.TextBox text_search_class;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btn_tail;
        private System.Windows.Forms.Button btn_next_click;
        private System.Windows.Forms.Label lblPageInfo_class;
        private System.Windows.Forms.Button btn_previous_click;
        private System.Windows.Forms.Button btn_head;
    }

}
