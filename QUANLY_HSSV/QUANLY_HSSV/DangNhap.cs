using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_HSSV
{
    public class DangNhap
    {
        public bool Login(string _Name, string _Pass)
        {
            string sql = @"select * from GIAOVIEN WHERE TENDN = '" + _Name + "' AND MATKHAU = '" + _Pass + "'";

            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}
