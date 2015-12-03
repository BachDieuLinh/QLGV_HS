using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_HSSV
{
    public class Hocsinh
    {
        public DataTable Show_HS()
        {
            string sql = "HS_Show";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        //Sủa 
        public void Sua_HS(string MAHS, string TENHS, DateTime NS, string GT, string DIACHI, string MALOP)
        {
            string sql = "HS_Upd";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", MAHS);
            cmd.Parameters.AddWithValue("@tenHS", TENHS);
            cmd.Parameters.AddWithValue("@ns", NS);
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@diachi", DIACHI);
            cmd.Parameters.AddWithValue("@maLOP", MALOP);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void ThemHS(string TENHS, DateTime NS, string GT, string DIACHI, string MALOP)
        {
            string sql = "HS_Ins";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenHS", TENHS);
            cmd.Parameters.AddWithValue("@ns", NS);
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@diachi", DIACHI);
            cmd.Parameters.AddWithValue("@maLOP", MALOP);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        // Xóa
        public void Xoa_HS(string MAHS)
        {
            string sql = "HS_Del";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHS", MAHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable LayThongTinLop()
        {
            string sql = "SELECT * FROM LOP";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
