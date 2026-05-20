namespace WindowsFormsApp01
{
    partial class Main
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQLLH = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnQLLH);
            this.panelMenu.Controls.Add(this.btnQLSV);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1100, 45);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDangXuat.Location = new System.Drawing.Point(368, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(129, 45);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQLLH
            // 
            this.btnQLLH.AutoSize = true;
            this.btnQLLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLLH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLLH.FlatAppearance.BorderSize = 0;
            this.btnQLLH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQLLH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLLH.Location = new System.Drawing.Point(191, 0);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnQLLH.Size = new System.Drawing.Size(177, 45);
            this.btnQLLH.TabIndex = 1;
            this.btnQLLH.Text = "Quản lý Lớp Học";
            this.btnQLLH.UseVisualStyleBackColor = true;
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.AutoSize = true;
            this.btnQLSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLSV.FlatAppearance.BorderSize = 0;
            this.btnQLSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQLSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLSV.Location = new System.Drawing.Point(0, 0);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnQLSV.Size = new System.Drawing.Size(191, 45);
            this.btnQLSV.TabIndex = 0;
            this.btnQLSV.Text = "Quản lý Sinh Viên";
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 45);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1100, 655);
            this.panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh Viên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQLLH;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Panel panelContainer;
    }
}