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
using QLSV_App.Controller;

namespace QLSV_App
{
    public partial class frmLogin : Form
    {
        public static string loginName; // Lấy tên tài khoản đăng nhập để form Home sử dụng

        //DBConnection db = new DBConnection();
        public frmLogin()
        {
            InitializeComponent();
            
        }
        #region Event
        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboRole.SelectedIndex = 0;
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
            if(cboRole.SelectedIndex > 0)
            {
                if (txtUserName.Text == String.Empty && txtPassword.Text == String.Empty)
                {
                    MessageBox.Show
                        ("Vui lòng nhập tên tài khoản và mật khẩu!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                else if (txtUserName.Text == String.Empty)
                {
                    MessageBox.Show
                        ("Vui lòng nhập tên tài khoản!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (txtPassword.Text == String.Empty)
                {
                    MessageBox.Show
                        ("Vui lòng nhập mật khẩu!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {
                    if (Login(txtUserName.Text, txtPassword.Text, cboRole.Text))
                    {
                        FrmHome frmHome = new FrmHome();
                        this.Hide();
                        loginName = txtUserName.Text;
                        frmHome.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                    }
                        //SqlConnection con = new SqlConnection("Data Source=STYLE-OF-ARIES\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
                        //con.Open();
                        //SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and QuyenTruyCap = @QuyenTruyCap", con);
                        //cmd.Parameters.AddWithValue("@QuyenTruyCap", cboRole.Text.Trim());
                        //cmd.Parameters.AddWithValue("@TenTaiKhoan", txtUserName.Text.Trim());
                        //cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text.Trim());
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //DataTable dt = new DataTable();
                        //da.Fill(dt);
                        //if (dt.Rows.Count > 0)
                        //{
                        //    FormHome frmHome = new FormHome();
                        //    this.Hide();
                        //    loginName = txtUserName.Text;
                        //    frmHome.ShowDialog();
                        //    this.Show();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                        //}
                        //con.Close();
                        //if (cboRole.Text == "Manager")
                        //{
                        //    SqlConnection con = new SqlConnection("Data Source=STYLE-OF-ARIES\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
                        //    con.Open();
                        //    SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and TypeAccount != 1", con);
                        //    cmd.Parameters.AddWithValue("@TenTaiKhoan", txtUserName.Text.Trim());
                        //    cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text.Trim());
                        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //    DataTable dt = new DataTable();
                        //    da.Fill(dt);
                        //    if (dt.Rows.Count > 0)
                        //    {
                        //        FormHome frmHome = new FormHome();
                        //        this.Hide();
                        //        loginName = txtUserName.Text;
                        //        frmHome.ShowDialog();
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                        //    }
                        //    con.Close();
                        //}
                    }    
            }
            else
            {
                MessageBox.Show
                    ("Vui lòng chọn quyền truy cập!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            //    try
            //    {
            //        if (cboRole.SelectedIndex > 0)
            //        {
            //            if (txtUserName.Text == String.Empty && txtPassword.Text == String.Empty)
            //            {
            //                MessageBox.Show
            //                    ("Vui lòng nhập tên tài khoản và mật khẩu!",
            //                    "Lỗi",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);

            //            }
            //            else if (txtUserName.Text == String.Empty)
            //            {
            //                MessageBox.Show
            //                    ("Vui lòng nhập tên tài khoản!",
            //                    "Lỗi",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //                txtUserName.Focus();
            //            }
            //            else if (txtPassword.Text == String.Empty)
            //            {
            //                MessageBox.Show
            //                    ("Vui lòng nhập mật khẩu!",
            //                    "Lỗi",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Error);
            //                txtPassword.Focus();
            //            }
            //            else
            //            {
            //                if (cboRole.Text == "Admin")
            //                {
            //                    SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau", db.GetConnection());
            //                    db.OpenConnection();
            //                    cmd.Parameters.AddWithValue("@TenTaiKhoan", txtUserName.Text.Trim());
            //                    cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text.Trim());
            //                    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //                    DataTable dt = new DataTable();
            //                    da.Fill(dt);
            //                    if (dt.Rows.Count > 0)
            //                    {
            //                        FormHome frmHome = new FormHome();
            //                        this.Hide();
            //                        frmHome.ShowDialog();
            //                        this.Show();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            //                    }
            //                    db.CloseConnection();
            //                }
            //                else if (cboRole.Text == "User")
            //                {
            //                    SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau", db.GetConnection());
            //                    db.OpenConnection();
            //                    cmd.Parameters.AddWithValue("@TenTaiKhoan", txtUserName.Text.Trim());
            //                    cmd.Parameters.AddWithValue("@MatKhau", txtPassword.Text.Trim());
            //                    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //                    DataTable dt = new DataTable();
            //                    da.Fill(dt);
            //                    if (dt.Rows.Count > 0)
            //                    {
            //                        FormHome frmHome = new FormHome();
            //                        this.Hide();
            //                        frmHome.ShowDialog();
            //                        this.Show();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            //                    }
            //                    db.CloseConnection();   
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show
            //                ("Vui lòng chọn quyền truy cập!",
            //                "Lỗi",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Method
        private bool Login(string userName, string passWord, string Role)
        {
            return Account.Instance.Login(userName, passWord, Role);
        }
        #endregion
        
        
    }
    

}
