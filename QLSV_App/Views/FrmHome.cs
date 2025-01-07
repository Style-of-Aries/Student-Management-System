using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_App.Core;
using QLSV_App.Views;

namespace QLSV_App
{
    public partial class FrmHome : Form
    {
        DBConnect db = new DBConnect();
        public FrmHome()
        {
            InitializeComponent();
        }
        #region Event
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            FrmKhoa khoa = new FrmKhoa();
            khoa.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lblTenHienThi_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //db.OpenConnection();
            //SqlCommand cmd_TenHienThi = new SqlCommand("select TenHienThi from TaiKhoan where TenTaiKhoan = @TenTaiKhoan", db.GetConnection());
            //cmd_TenHienThi.Parameters.AddWithValue("@TenTaiKhoan", frmLogin.loginName);
            //lblTenHienThi.Text = cmd_TenHienThi.ExecuteScalar().ToString();
            //db.CloseConnection();
            //db.OpenConnection();
            //SqlCommand cmd_QuyenTruyCap = new SqlCommand("select QuyenTruyCap from TaiKhoan where TenTaiKhoan = @TenTaiKhoan", db.GetConnection());
            //cmd_QuyenTruyCap.Parameters.AddWithValue("@TenTaiKhoan", frmLogin.loginName);
            //lblRole.Text= cmd_QuyenTruyCap.ExecuteScalar().ToString();
            //db.CloseConnection();
            lblTenHienThi.Text = getTenHienThi();
            lblRole.Text = getRole();
            if (lblRole.Text != "Admin")
            {
                btnTaiKhoan.Hide();
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan taiKhoan = new FrmTaiKhoan();
            taiKhoan.ShowDialog();
        }

        private void btnNganhHoc_Click(object sender, EventArgs e)
        {
            FrmNganh frmNganh = new FrmNganh();
            frmNganh.ShowDialog();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            FrmLop frmLop = new FrmLop();
            frmLop.ShowDialog();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            FrmSinhVien frmSinhVien = new FrmSinhVien();
            frmSinhVien.ShowDialog();
        }
        #endregion
        #region Method
        private string getRole()
        {
            db.OpenConnection();
            SqlCommand cmd_QuyenTruyCap = new SqlCommand("select QuyenTruyCap from TaiKhoan where TenTaiKhoan = @TenTaiKhoan", db.GetConnection());
            cmd_QuyenTruyCap.Parameters.AddWithValue("@TenTaiKhoan", frmLogin.loginName);
            string role = cmd_QuyenTruyCap.ExecuteScalar().ToString();
            db.CloseConnection();
            return role;
        }

        private string getTenHienThi()
        {
            db.OpenConnection();
            SqlCommand cmd_TenHienThi = new SqlCommand("select TenHienThi from TaiKhoan where TenTaiKhoan = @TenTaiKhoan", db.GetConnection());
            cmd_TenHienThi.Parameters.AddWithValue("@TenTaiKhoan", frmLogin.loginName);
            string tenHienThi = cmd_TenHienThi.ExecuteScalar().ToString();
            db.CloseConnection();
            return tenHienThi;
        }
        #endregion

        
    }
}
