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

namespace QLSV_App
{
    public partial class FrmKhoa : Form
    {
        DBConnect db = new DBConnect();
        public FrmKhoa()
        {
            InitializeComponent();
            
            loadKhoaList();
        }
        #region Event
        private void dtgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dtgvKhoa.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "insert into Khoa values ('" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadKhoaList();
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
                string query = "delete from Khoa where MaKhoa = '" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadKhoaList();
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
                string query = "update Khoa set TenKhoa = N'" + txtTenKhoa.Text + "' where MaKhoa = '" + txtMaKhoa.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadKhoaList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        #endregion
        #region Method
        private void loadKhoaList()
        {
            db.OpenConnection();
            string query = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvKhoa.DataSource = table;
            db.CloseConnection();
            dtgvKhoa.Columns[0].HeaderText = "Mã khoa";
            dtgvKhoa.Columns[1].HeaderText = "Tên khoa";
        }
        #endregion

    }
}
