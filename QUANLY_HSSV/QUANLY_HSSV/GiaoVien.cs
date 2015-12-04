using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_HSSV
{
    public class GiaoVien
    {
        public DataTable Show()
        {
            string sql = "GV_Show";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void ThemGV(string TENGV, DateTime NS, string GT, string SDT, string LUONG, string DIACHI, string MAMH,string TENDN, string MATKHAU)
        {
            string sql = "GV_Ins";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenGV", TENGV);
            cmd.Parameters.AddWithValue("@ns", NS);
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@sdt", SDT);
            cmd.Parameters.AddWithValue("@luong", int.Parse(LUONG));
            cmd.Parameters.AddWithValue("@diaChi", DIACHI);
            cmd.Parameters.AddWithValue("@maMH", MAMH);
            cmd.Parameters.AddWithValue("@tendn", TENDN);
            cmd.Parameters.AddWithValue("@mk", MATKHAU);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Sua 
        public void Sua_GV(string MAGV, string TENGV, DateTime NS, string GT, string SDT, string LUONG, string DIACHI, string MAMH, string TENDN, string MATKHAU)
        {
            string sql = "GV_Upd";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("maGV", MAGV);
            cmd.Parameters.AddWithValue("@tenGV", TENGV);
            cmd.Parameters.AddWithValue("@ns", NS);
            cmd.Parameters.AddWithValue("@gt", GT);
            cmd.Parameters.AddWithValue("@sdt", SDT);
            cmd.Parameters.AddWithValue("@luong", int.Parse(LUONG));
            cmd.Parameters.AddWithValue("@diaChi", DIACHI);
            cmd.Parameters.AddWithValue("@maMH", MAMH);
            cmd.Parameters.AddWithValue("@tendn", TENDN);
            cmd.Parameters.AddWithValue("@mk", MATKHAU);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void Xoa_GV(string MAGV)
        {
            string sql = "GV_Del";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maGV", MAGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        //lay thong tin mon hoc
        public DataTable LayThongTinMonHoc()
        {
            string sql = "SELECT * FROM MONHOC";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
