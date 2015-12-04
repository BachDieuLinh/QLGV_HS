using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_HSSV
{
    public class TimKiem
    {
        // Tìm kiếm Giao vien theo tên
        public DataTable TKTenGiaoVien(string TENGV)
        {
            string sql = "GV_Sea_TenGV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@tenGV", TENGV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Hoc Sinh theo tên
        public DataTable TKTenHocSinh(string TENHS)
        {
            string sql = "HS_Sea_TenHS";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@tenHS", TENHS);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Hoc Sinh theo Ma
        public DataTable TK_Ma_HocSinh(string MAHS)
        {
            string sql = "HS_Sea_MaHS";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@maHS",MAHS );
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Giao Vien theo Ma
        public DataTable TK_Ma_GiaoVien(string MAGV)
        {
            string sql = "GV_Sea_MaHS";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@maGV", MAGV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
