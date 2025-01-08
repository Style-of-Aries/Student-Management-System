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
    public partial class FrmNganh : Form
    {
        DBConnect db = new DBConnect();
        public FrmNganh()
        {
            InitializeComponent();
        }
        
        
        #region Method
        private void loadNganhHocList()
        {
            db.OpenConnection();
            string query = "select MaNganh,TenNganh,Khoa.MaKhoa from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa = @TenKhoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvNganh.DataSource = table;
            db.CloseConnection();
            dtgvNganh.Columns[0].HeaderText = "Mã ngành";
            dtgvNganh.Columns[1].HeaderText = "Tên ngành";
            dtgvNganh.Columns[2].HeaderText = "Mã khoa";
        }
        private void loadCboKhoa()
        {
            //db.OpenConnection();
            //string query = "select * from Khoa";
            //SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //cboKhoa.DataSource = table;
            //cboKhoa.DisplayMember = "TenKhoa";
            //cboKhoa.ValueMember = "MaKhoa";
            //db.CloseConnection();
            dataKhoaList khoaList = new dataKhoaList();
            khoaList.loadCboKhoa(cboKhoa);
        }
        #endregion

        #region Event
        private void dtgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNganh.Text = dtgvNganh.CurrentRow.Cells[0].Value.ToString();
            txtTenNganh.Text = dtgvNganh.CurrentRow.Cells[1].Value.ToString();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNganhHocList();
        }

        private void cboKhoa_Click(object sender, EventArgs e)
        {
            loadCboKhoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string queryGetMaKhoa = "select MaKhoa from Khoa where TenKhoa = @TenKhoa";
                SqlCommand cmdGetMaKhoa = new SqlCommand(queryGetMaKhoa, db.GetConnection());
                cmdGetMaKhoa.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());
                string result = cmdGetMaKhoa.ExecuteScalar().ToString();
                db.CloseConnection();
                db.OpenConnection();
                string queryThem = "insert into NganhHoc values ('" + txtMaNganh.Text + "', N'" + txtTenNganh.Text + "', '" + result + "')";
                SqlCommand cmdThem = new SqlCommand(queryThem, db.GetConnection());
                cmdThem.ExecuteNonQuery();
                db.CloseConnection();
                loadNganhHocList();
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
                db.OpenConnection();
                string query = "delete from NganhHoc where MaNganh = '" + txtMaNganh.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadNganhHocList();
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

                db.OpenConnection();
                string query = "update NganhHoc set TenNganh = N'" + txtTenNganh.Text + "' where MaNganh = '" + txtMaNganh.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadNganhHocList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }
        #endregion
    }
}
