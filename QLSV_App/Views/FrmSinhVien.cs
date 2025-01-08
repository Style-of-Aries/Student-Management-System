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

namespace QLSV_App.Views
{
    public partial class FrmSinhVien : Form
    {
        DBConnect db = new DBConnect();
        DataProvider provider = new DataProvider();
        public FrmSinhVien()
        {
            InitializeComponent();
        }
        #region Method
        private void loadCboKhoa()
        {
            dataKhoaList khoaList = new dataKhoaList();
            khoaList.loadCboKhoa(cboKhoa);
        }
        private void loadCboNganh()
        {
            string query = "select * from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa = @TenKhoa";
            
            DataTable table = provider.ExecuteQuery(query, new object[] { cboKhoa.Text.Trim() });
            cboNganh.DataSource = table;
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
        }
        private void loadCboLop()
        {
            db.OpenConnection();
            string query = "select * from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh = @TenNganh";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenNganh", cboNganh.Text.Trim());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboLop.DataSource = table;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            db.CloseConnection();
        }
        private void loadSinhVienList()
        {
            db.OpenConnection();
            string query = "select MaSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Cccd, Email, Lop.MaLop from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop where TenLop = @TenLop";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenLop", cboLop.Text.Trim());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvSinhVien.DataSource = table;
            db.CloseConnection();
            dtgvSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dtgvSinhVien.Columns[1].HeaderText = "Họ tên";
            dtgvSinhVien.Columns[2].HeaderText = "Ngày sinh";
            dtgvSinhVien.Columns[3].HeaderText = "Giới tính";
            dtgvSinhVien.Columns[4].HeaderText = "Địa chỉ";
            dtgvSinhVien.Columns[5].HeaderText = "Số điện thoại";
            dtgvSinhVien.Columns[6].HeaderText = "Số CCCD";
            dtgvSinhVien.Columns[7].HeaderText = "Email";
            dtgvSinhVien.Columns[8].HeaderText = "Mã lớp";
        }
        private string getMaLop()
        {
            string query = "select MaLop from Lop where TenLop = @TenLop";
            DataProvider provider = new DataProvider();
            return provider.ExecuteScalar(query, new object[] { cboLop.Text.Trim() }).ToString();
        }
        #endregion

        #region Event
        private void cboKhoa_Click(object sender, EventArgs e)
        {
            loadCboKhoa();
        }
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCboNganh();
        }
        private void cboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCboLop();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSinhVienList();
        }

        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSinhVien.Text = dtgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txtTenSinhVien.Text = dtgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dtgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            if (dtgvSinhVien.CurrentRow.Cells[3].Value.ToString().Trim().Equals(radNam.Text.Trim()))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDiaChi.Text = dtgvSinhVien.CurrentRow.Cells[4].Value.ToString();
            txtSoDienThoai.Text = dtgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            txtCccd.Text = dtgvSinhVien.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dtgvSinhVien.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = getMaLop();
                string query = "insert into SinhVien values ('" + txtMaSinhVien.Text + "', N'" + txtTenSinhVien.Text + "', '" + dtpNgaySinh.Value + "', N'" + (radNam.Checked ? radNam.Text : radNu.Text) + "', N'" + txtDiaChi.Text + "', '" + txtSoDienThoai.Text + "', '" + txtCccd.Text + "', '" + txtEmail.Text + "', '" + maLop + "')";
                provider.ExecuteNonQuery(query);
                loadSinhVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from SinhVien where MaSV = '" + txtMaSinhVien.Text + "'";
                provider.ExecuteNonQuery(query);
                loadSinhVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "update SinhVien set TenSV = N'" + txtTenSinhVien.Text + "', NgaySinh = '" + dtpNgaySinh.Value + "', GioiTinh = N'" + (radNam.Checked ? radNam.Text : radNu.Text) + "', DiaChi = N'" + txtDiaChi.Text + "', SoDienThoai = '" + txtSoDienThoai.Text + "', Cccd = '" + txtCccd.Text + "', Email = '" + txtEmail.Text + "' where MaSV = '" + txtMaSinhVien.Text + "'";
                provider.ExecuteNonQuery(query);
                loadSinhVienList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from SinhVien where MaSV like N'" + txtTuKhoa.Text + "%'";
                DataTable table = provider.ExecuteQuery(query);
                dtgvSinhVien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        #endregion

        
    }
}
