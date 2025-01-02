using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_App.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = "Data Source=STYLE-OF-ARIES\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                    con.Close();
                }

                return dt;
            }

        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;

            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    dt = command.ExecuteNonQuery();
                    con.Close();
                }

                return dt;
            }
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;

            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    dt = command.ExecuteScalar();
                    con.Close();
                }

                return dt;
            }
        }
    }
}
