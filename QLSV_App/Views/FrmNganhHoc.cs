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
    public partial class FrmNganhHoc : Form
    {
        
        DBConnect db = new DBConnect();
        public FrmNganhHoc()
        {
            InitializeComponent();
            //loadNganhHocList();
        }

        

        

        private void FrmNganhHoc_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLSVDataSet.Khoa' table. You can move, or remove it, as needed.

        }

        void loadNganhHocList()
        {
            db.OpenConnection();
            string query = "select MaNganh,TenNganh,TenKhoa from NganhHoc inner join Khoa on NganhHoc.MaKhoa = Khoa.MaKhoa where TenKhoa = @TenKhoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dtgvNganhHoc.DataSource = table;
            db.CloseConnection();
            dtgvNganhHoc.Columns[0].HeaderText = "Mã ngành";
            dtgvNganhHoc.Columns[1].HeaderText = "Tên ngành";
            dtgvNganhHoc.Columns[2].HeaderText = "Tên khoa";
            
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNganhHocList();
            //loadCboKhoa();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            string queryGetMaKhoa = "select MaKhoa from Khoa where TenKhoa = @TenKhoa";
            SqlCommand cmdGetMaKhoa = new SqlCommand(queryGetMaKhoa, db.GetConnection());
            cmdGetMaKhoa.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());
            string result = cmdGetMaKhoa.ExecuteScalar().ToString();
            db.CloseConnection();
            
            db.OpenConnection();
            string queryThem = "insert into NganhHoc values ('" + txtMaNganhHoc.Text + "', N'" + txtTenNganhHoc.Text + "', '" + result + "')";
            SqlCommand cmdThem = new SqlCommand(queryThem, db.GetConnection());
            cmdThem.ExecuteNonQuery();
            db.CloseConnection();
            loadNganhHocList();

        }

        private void dtgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboKhoa.Text = dtgvNganhHoc.CurrentRow.Cells[2].Value.ToString();
            txtMaNganhHoc.Text = dtgvNganhHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenNganhHoc.Text = dtgvNganhHoc.CurrentRow.Cells[1].Value.ToString();
        }
        private void loadCboKhoa()
        {
            db.OpenConnection();
            string query = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cboKhoa.DataSource = table;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            db.CloseConnection();
        }

        private string getMaKhoa()
        {
            db.OpenConnection();
            string query = "select MaKhoa from Khoa where TenKhoa = @TenKhoa";
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenKhoa", cboKhoa.Text.Trim());
            string result = cmd.ExecuteScalar().ToString();
            db.CloseConnection();
            return result;
        }
        private void cboKhoa_Click(object sender, EventArgs e)
        {
            loadCboKhoa();
            
            //loadNganhHocList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "delete from NganhHoc where MaNganh = '" + txtMaNganhHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                loadNganhHocList();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    ("Không thể xóa ngành học này",
                    "error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
