using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace DAL
{
    public class ordersitemDAL
    {
        public static string CheckLogic(ordersitemDTO ordersitem)
        {
            if (ordersitem == null)
            {
                return "invalid_ordersitem";
            }
            if (ordersitem.MaDonHang <= 0)
            {
                return "invalid_MaDonHang";
            }
            if (string.IsNullOrEmpty(ordersitem.MaSanPham))
            {
                return "invalid_MaSanPham";
            }
            if (ordersitem.SoLuong <= 0)
            {
                return "invalid_SoLuong";
            }
            return "valid";
        }

        public static List<ordersitemDTO> GetAllOrders()
        {
            List<ordersitemDTO> OrdersitemDTO = new List<ordersitemDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM CHITIETDONHANG";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordersitemDTO ordersitem = new ordersitemDTO
                            {
                                MaDonHang = Convert.ToInt32(reader["MaDonHang"]),
                                MaSanPham = reader["MaSanPham"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SoLuong"])
                            };
                            OrdersitemDTO.Add(ordersitem);
                        }
                    }
                }
            }

            return OrdersitemDTO;
        }

        public static bool InsertOrdersitem(ordersitemDTO ordersitem)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO CHITIETDONHANG (MaDonHang, MaSanPham, SoLuong) VALUES (@MaDonHang, @MaSanPham, @SoLuong)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDonHang", ordersitem.MaDonHang);
                    cmd.Parameters.AddWithValue("@MaSanPham", ordersitem.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", ordersitem.SoLuong);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool UpdateOrdersitem(ordersitemDTO ordersitem)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM CHITIETDONHANG WHERE MaDonHang = @MaDonHang AND MaSanPham = @MaSanPham";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaDonHang", ordersitem.MaDonHang);
                    checkCmd.Parameters.AddWithValue("@MaSanPham", ordersitem.MaSanPham);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        Console.WriteLine("Bản ghi không tồn tại, không thể cập nhật.");
                        return false;
                    }
                }
                string query = "UPDATE CHITIETDONHANG SET SoLuong = @SoLuong WHERE MaDonHang = @MaDonHang AND MaSanPham = @MaSanPham";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDonHang", ordersitem.MaDonHang);
                    cmd.Parameters.AddWithValue("@MaSanPham", ordersitem.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", ordersitem.SoLuong);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool DeleteOrdersitem(int maDonHang)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM CHITIETDONHANG WHERE MaDonHang = @MaDonHang";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
