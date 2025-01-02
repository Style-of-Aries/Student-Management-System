using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLSV_App.DAO;

namespace QLSV_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Bạn có muốn thoát chương trình không?", 
                "Thông báo", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUserName.Text;
            //string password = txtPassword.Text;
            //if (Login(username, password))
            //{
            //    FormHome frmHome = new FormHome();
            //    this.Hide();
            //    frmHome.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            //}
            try
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
    
}
