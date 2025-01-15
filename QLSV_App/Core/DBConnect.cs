using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_App.Core
{
    public class DBConnect
    {
            private SqlConnection con = new SqlConnection("Data Source=\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            public SqlConnection GetConnection()
            {
                return con;
            }
            public void OpenConnection()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            public void CloseConnection()
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }

