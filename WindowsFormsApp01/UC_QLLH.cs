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

        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            List<Class> dsLopHoc = db.Classes.ToList();
            dgvLopHoc.DataSource = dsLopHoc;
        }
        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}