using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ordersDAL
    {
        public void ThemDonHang(int maBan, string maKhuyenMai, string trangThai)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemDonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaBan", maBan);
                if (string.IsNullOrEmpty(maKhuyenMai))
                    cmd.Parameters.AddWithValue("@MaKhuyenMai", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable LayDanhSachDonHang()
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachDonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void XoaDonHang(int maDonHang)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaDonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                cmd.ExecuteNonQuery();
            }
        }
        public void SuaDonHang(int maDonHang, int maBan, string trangThai, string maKhuyenMai)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SuaDonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                if (string.IsNullOrEmpty(maKhuyenMai))
                    cmd.Parameters.AddWithValue("@MaKhuyenMai", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
