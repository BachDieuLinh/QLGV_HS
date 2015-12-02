using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QUANLY_HSSV
{
    public class ttgiangday
    {
        KetNoi cn = new KetNoi();
        public DataTable HienThiTTGD(string _MALOP)
        {
            string sql = "TTGD_Show_GV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLop", _MALOP);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable HienThiGiaoVien()
        {
            string sql = "TTGD_Show_checkGV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public DataTable HienThiHocSinh(string _MALOP)
        {
            string sql = "TTGD_Show_HS";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLop", _MALOP);

            SqlDataAdapter da = new SqlDataAdapter( cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;
        }

        public DataTable HienThiLop()
        {
            string sql = "TTGD_Show_Lop";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemGV(string MALOP, string MAGV)
        {
            string sql = "TTGD_Ins_GV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@maLOP", MALOP);
            cmd.Parameters.AddWithValue("@maGV", MAGV);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void ThemHS ( string TENHS, DateTime NS, string GT, string DIACHI, string MALOP)
        {
            string sql = "TTGD_Ins_HS";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenHS", TENHS);
            cmd.Parameters.AddWithValue("@ns", NS);
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@diachi", DIACHI);
            cmd.Parameters.AddWithValue("@maLOP", MALOP);

            //cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaGV(string MALOP, string GV)
        {
            string sql = "Upd_NV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@maLOP", MALOP);
            cmd.Parameters.AddWithValue("@maGV", GV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaGV(string MALOP, string GV)
        {
            string sql = "TTGD_Del_GV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLOP", MALOP);
            cmd.Parameters.AddWithValue("@maGV", GV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaHS(string MALOP, string MAHS)
        {
            string sql = "TTGD_Del_GV";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLOP", MALOP);
            cmd.Parameters.AddWithValue("@maHS", MAHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
