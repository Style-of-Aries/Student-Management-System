using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_App.Controller
{
    public class DataNganhList
    {
        DataProvider provider = new DataProvider();
        private DataTable dataCboKhoa()
        {
            string query = "select * from Nganh";
            DataTable table = provider.ExecuteQuery(query);
            return table;
        }
        public void loadCboKhoa(ComboBox cbo)
        {
            cbo.DataSource = dataCboKhoa();
            cbo.DisplayMember = "TenNganh";
            cbo.ValueMember = "MaKhoa";
        }
    }
}
