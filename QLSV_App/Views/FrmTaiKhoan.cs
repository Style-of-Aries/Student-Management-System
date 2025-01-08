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
using QLSV_App.Controller;
using QLSV_App.Core;

namespace QLSV_App
{
    public partial class FrmTaiKhoan : Form
    {
        DBConnect db = new DBConnect();
        public FrmTaiKhoan()
        {
            InitializeComponent();
            loadTaiKhoanList();
        }
        #region Event
        private void dtgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }

        
        

        
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTaiKhoan.Text = dtgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtMatKhau.Text = dtgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dtgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            txtSoDT.Text = dtgvTaiKhoan.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dtgvTaiKhoan.CurrentRow.Cells[5].Value.ToString();
            if (dtgvTaiKhoan.CurrentRow.Cells[6].Value.ToString().Trim().Equals(radNam.Text))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            cboQuyenTruyCap.Text = dtgvTaiKhoan.CurrentRow.Cells[7].Value.ToString();
            txtTenHienThi.Text = dtgvTaiKhoan.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "delete from TaiKhoan where TenTaiKhoan = '" + txtTenTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadTaiKhoanList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
                //db.OpenConnection();
                //string query = "delete from TaiKhoan where TenTaiKhoan = '" + txtTenTaiKhoan.Text + "'";
                //SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                //cmd.ExecuteNonQuery();
                //db.CloseConnection();
                //loadTaiKhoanList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "insert into TaiKhoan values ('" + txtTenTaiKhoan.Text + "', '" + txtMatKhau.Text + "', '" + txtEmail.Text + "', '" + txtSoDT.Text + "', '" + dateTimePicker1.Value + "', N'" + (radNam.Checked ? radNam.Text : radNu.Text) + "', '" + cboQuyenTruyCap.Text + "', N'" + txtTenHienThi.Text + "')";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadTaiKhoanList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
                //db.OpenConnection();
                //string query = "insert into TaiKhoan values ('" + txtTenTaiKhoan.Text + "', '" + txtMatKhau.Text + "', '" + txtEmail.Text + "', '" + txtSoDT.Text + "', '" + dateTimePicker1.Value + "', N'" + (radNam.Checked ? radNam.Text : radNu.Text) + "', '" + cboQuyenTruyCap.Text + "', N'" + txtTenHienThi.Text + "')";
                //SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                //cmd.ExecuteNonQuery();
                //db.CloseConnection();
                //loadTaiKhoanList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "update TaiKhoan set MatKhau = '" + txtMatKhau.Text + "', Email = '" + txtEmail.Text + "', SoDienThoai = '" + txtSoDT.Text + "', NgaySinh = '" + dateTimePicker1.Value + "', GioiTinh = N'" + (radNam.Checked ? radNam.Text : radNu.Text) + "', QuyenTruyCap = '" + cboQuyenTruyCap.Text + "', TenHienThi = N'" + txtTenHienThi.Text + "' where TenTaiKhoan = '" + txtTenTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadTaiKhoanList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }
        #endregion
        #region Method
        //Hàm hiển thị danh sách tài khoản
        void loadTaiKhoanList()
        {
            db.OpenConnection();
            string query = "select * from TaiKhoan";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvTaiKhoan.DataSource = table;
            //SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetConnection());
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dtgvTaiKhoan.DataSource = ds.Tables[0];
            db.CloseConnection();
            dtgvTaiKhoan.Columns[1].HeaderText = "Tên tài khoản";
            dtgvTaiKhoan.Columns[2].HeaderText = "Mật khẩu";
            dtgvTaiKhoan.Columns[3].HeaderText = "Email";
            dtgvTaiKhoan.Columns[4].HeaderText = "Số điện thoại";
            dtgvTaiKhoan.Columns[5].HeaderText = "Ngày sinh";
            dtgvTaiKhoan.Columns[6].HeaderText = "Giới tính";
            dtgvTaiKhoan.Columns[7].HeaderText = "Quyền truy cập";
            dtgvTaiKhoan.Columns[8].HeaderText = "Tên hiển thị";
            dtgvTaiKhoan.ReadOnly = true;
        }
        #endregion
    }

}