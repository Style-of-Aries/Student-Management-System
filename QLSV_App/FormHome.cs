using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_App
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Bạn có muốn đăng xuất khỏi tài khoản này không?",
                "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
