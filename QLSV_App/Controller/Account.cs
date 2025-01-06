using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_App.Core;

namespace QLSV_App.Controller
{
    public class Account
    {
        DBConnect db = new DBConnect();
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account() { }

        public bool Login(string userName, string passWord, string Role)
        {
            string query = "select* from TaiKhoan where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and QuyenTruyCap = @QuyenTruyCap";
            //string query = "select * from TaiKhoan where TenTaiKhoan = N'admin' and MatKhau = 12345678";
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@TenTaiKhoan", userName);
            cmd.Parameters.AddWithValue("@MatKhau", passWord);
            cmd.Parameters.AddWithValue("@QuyenTruyCap", Role);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.CloseConnection();
            return table.Rows.Count > 0;
        }
    }
}
