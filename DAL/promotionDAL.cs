using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace DAL
{
    public class promotionDAL
    {
        public void ThemKhuyenMai(string maKhuyenMai, string tenKhuyenMai, int soTienGiam, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", tenKhuyenMai);
                cmd.Parameters.AddWithValue("@SoTienGiam", soTienGiam);
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable LayDanhSachKhuyenMai()
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void XoaKhuyenMai(string maKhuyenMai)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                cmd.ExecuteNonQuery();
            }
        }
        public void SuaKhuyenMai(string maKhuyenMai, string tenKhuyenMai, int soTienGiam, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", tenKhuyenMai);
                cmd.Parameters.AddWithValue("@SoTienGiam", soTienGiam);
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
