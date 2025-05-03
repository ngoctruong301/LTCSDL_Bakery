using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DAL
{
    public class productDAL
    {
        public static List<productDTO> GetAllProducts()
        {
            List<productDTO> products = new List<productDTO>();
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM SANPHAM";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productDTO product = new productDTO
                            {
                                MaSanPham = reader["MaSanPham"].ToString(),
                                TenSanPham = reader["TenSanPham"].ToString(),
                                GiaTien = Convert.ToInt32(reader["GiaTien"]),
                                MaNCC = reader["MaNCC"].ToString(),
                                MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"])
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public static bool InsertProduct(productDTO product)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO SANPHAM (MaSanPham, TenSanPham, GiaTien, MaNCC, MaDanhMuc) VALUES (@MaSanPham, @TenSanPham, @GiaTien, @MaNCC, @MaDanhMuc)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", product.MaSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", product.TenSanPham);
                    cmd.Parameters.AddWithValue("@GiaTien", product.GiaTien);
                    cmd.Parameters.AddWithValue("@MaNCC", product.MaNCC);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", product.MaDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateProduct(productDTO product)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE SANPHAM SET TenSanPham=@TenSanPham, GiaTien=@GiaTien, MaNCC=@MaNCC, MaDanhMuc=@MaDanhMuc WHERE MaSanPham=@MaSanPham";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", product.MaSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", product.TenSanPham);
                    cmd.Parameters.AddWithValue("@GiaTien", product.GiaTien);
                    cmd.Parameters.AddWithValue("@MaNCC", product.MaNCC);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", product.MaDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteProduct(string maSanPham)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM SANPHAM WHERE MaSanPham = @MaSanPham";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
