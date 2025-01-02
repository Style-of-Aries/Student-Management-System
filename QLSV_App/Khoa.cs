using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_App.DAO;

namespace QLSV_App
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
            
            loadKhoaList();
        }

        void loadKhoaList()
        {
            string query = "SELECT * FROM TaiKhoan";

            DataProvider provider = new DataProvider();
            dtgvKhoa.DataSource = provider.ExecuteQuery(query);
        }
    }
}
