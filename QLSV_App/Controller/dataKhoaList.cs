using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_App.Core;

namespace QLSV_App.Controller
{
    public class dataKhoaList
    {
        DataProvider provider = new DataProvider();
        private DataTable dataCboKhoa()
        {
            string query = "select * from Khoa";
            DataTable table = provider.ExecuteQuery(query);
            return table;
        }
        public void loadCboKhoa(ComboBox cbo)
        {
            cbo.DataSource = dataCboKhoa();
            cbo.DisplayMember = "TenKhoa";
            cbo.ValueMember = "MaKhoa";
        }
        //DBConnect db = new DBConnect();
        //private DataTable LoadCboKhoa()
        //{
        //    DataTable table = new DataTable();
        //    try
        //    {
        //        db.OpenConnection();
        //        string query = "SELECT * FROM Khoa";
        //        SqlCommand cmd = new SqlCommand(query, db.GetConnection());
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(table);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi: {ex.Message}");
        //    }
        //    finally
        //    {
        //        db.CloseConnection();
        //    }
        //    return table;
        //}
        //public void LoadCboKhoa(ComboBox cbo)
        //{
        //    cbo.DataSource = LoadCboKhoa();
        //    cbo.DisplayMember = "TenKhoa";
        //    cbo.ValueMember = "MaKhoa";
        //}
    }
}
