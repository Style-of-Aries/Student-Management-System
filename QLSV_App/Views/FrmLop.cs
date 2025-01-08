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
    
    public partial class FrmLop : Form
    {
        DBConnect db = new DBConnect();
        public FrmLop()
        {
            InitializeComponent();
            //loadLopHocList();
        }
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
            loadLopHocList();
        }

        private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dtgvLop.CurrentRow.Cells[0].Value.ToString();
            txtTenLop.Text = dtgvLop.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = getMaNganh();
                DataProvider provider = new DataProvider();
                string query = "insert into Lop(MaLop, TenLop, MaNganh) values('" + txtMaLop.Text + "','" + txtTenLop.Text + "','" + maNganh + "')";
                provider.ExecuteNonQuery(query);
                loadLopHocList();
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
                DataProvider provider = new DataProvider();
                string query = "delete from Lop where MaLop = '" + txtMaLop.Text + "'";
                provider.ExecuteNonQuery(query);
                loadLopHocList();
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
                string maNganh = getMaNganh();
                DataProvider provider = new DataProvider();
                string query = "update Lop set TenLop = '" + txtTenLop.Text + "' where MaLop = '" + txtMaLop.Text + "'";
                provider.ExecuteNonQuery(query);
                loadLopHocList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        #endregion

        #region Method
        private void loadLopHocList()
        {
            db.OpenConnection();
            string query = "select MaLop, TenLop, SiSo, NganhHoc.MaNganh from Lop inner join NganhHoc on Lop.MaNganh = NganhHoc.MaNganh where TenNganh = @TenNganh update Lop set SiSo = (select count(*) from SinhVien where Lop.MaLop = SinhVien.MaLop)";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenNganh", cboNganh.Text.Trim());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvLop.DataSource = table;
            db.CloseConnection();
            dtgvLop.Columns[0].HeaderText = "Mã lớp";
            dtgvLop.Columns[1].HeaderText = "Lớp";
            dtgvLop.Columns[2].HeaderText = "Sĩ số";
            dtgvLop.Columns[3].HeaderText = "Mã ngành";
        }
        private void loadCboKhoa()
        {
            dataKhoaList khoaList = new dataKhoaList();
            khoaList.loadCboKhoa(cboKhoa);
        }

        private void loadCboNganh()
        {
            db.OpenConnection();
            string query = "select * from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa = @TenKhoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboNganh.DataSource = table;
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            db.CloseConnection();
        }
        private string getMaNganh()
        {
            string query = "select MaNganh from NganhHoc where TenNganh = @TenNganh";
            DataProvider provider = new DataProvider();
            return provider.ExecuteScalar(query, new object[] { cboNganh.Text.Trim() }).ToString();
        }
        #endregion


        
    }
}
