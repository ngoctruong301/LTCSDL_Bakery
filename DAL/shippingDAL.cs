using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;


public class shippingDAL
{
    public void ThemGiaoHang(int maDonHang, string diaChi, int sdt, string trangThai)
    {
        using (SqlConnection conn = SqlconnectionData.Connect())
        {
            conn.Open();
            string query = "INSERT INTO GIAOHANG (MaDonHang, DiaChi, SDT, TrangThai) VALUES (@MaDonHang, @DiaChi, @SDT, @TrangThai)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);

            cmd.ExecuteNonQuery();
        }
    }

    public DataTable LayDanhSachGiaoHang()
    {
        using (SqlConnection conn = SqlconnectionData.Connect())
        {
            conn.Open();
            string query = "SELECT * FROM GIAOHANG";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public void XoaGiaoHang(int maGiaoHang)
    {
        using (SqlConnection conn = SqlconnectionData.Connect())
        {
            conn.Open();
            string query = "DELETE FROM GIAOHANG WHERE MaGiaoHang = @MaGiaoHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaGiaoHang", maGiaoHang);
            cmd.ExecuteNonQuery();
        }
    }

    public void SuaGiaoHang(int maGiaoHang, int maDonHang, string diaChi, int sdt, string trangThai)
    {
        using (SqlConnection conn = SqlconnectionData.Connect())
        {
            conn.Open();
            string query = @"UPDATE GIAOHANG SET MaDonHang = @MaDonHang, DiaChi = @DiaChi, SDT = @SDT, TrangThai = @TrangThai
                             WHERE MaGiaoHang = @MaGiaoHang";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MaGiaoHang", maGiaoHang);
            cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);

            cmd.ExecuteNonQuery();
        }
    }
}