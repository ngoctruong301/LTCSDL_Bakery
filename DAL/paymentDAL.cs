using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class paymentDAL
    {
        public void ThemThanhToan(int maDonHang, int soTien, string hinhThuc)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemThanhToan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                cmd.Parameters.AddWithValue("@SoTien", soTien);
                cmd.Parameters.AddWithValue("@HinhThuc", hinhThuc);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable LayDanhSachThanhToan()
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachThanhToan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void XoaThanhToan(int maThanhToan)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaThanhToan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                cmd.ExecuteNonQuery();
            }
        }
        public void SuaThanhToan(int maThanhToan, int maDonHang, int soTien, string hinhThuc)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaThanhToan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                cmd.Parameters.AddWithValue("@SoTien", soTien);
                cmd.Parameters.AddWithValue("@HinhThuc", hinhThuc);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
