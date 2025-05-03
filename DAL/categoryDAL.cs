using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace DAL
{
    public class categoryDAL
    {
        public static string CheckLogic(categoryDTO category)
        {
            if (category == null)
            {
                return "invalid_category"; 
            }
            if (category.MaDanhMuc <= 0)
            {
                return "invalid_MaDanhMuc"; 
            }
            if (string.IsNullOrEmpty(category.TenDanhMuc))
            {
                return "invalid_TenDanhMuc";  
            }
            return "valid";  
        }
        public static List<categoryDTO> GetAllCategories()
        {
            List<categoryDTO> categories = new List<categoryDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM DANHMUCSANPHAM"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryDTO category = new categoryDTO
                            {
                                MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"]), 
                                TenDanhMuc = reader["TenDanhMuc"].ToString() 
                            };
                            categories.Add(category);  
                        }
                    }
                }
            }

            return categories;  
        }
        public static bool InsertCategory(categoryDTO category)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO DANHMUCSANPHAM (TenDanhMuc) VALUES (@TenDanhMuc)";  

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDanhMuc", category.TenDanhMuc);  

                    int rowsAffected = cmd.ExecuteNonQuery();  
                    return rowsAffected > 0;  
                }
            }
        }
        public static bool UpdateCategory(categoryDTO category)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE DANHMUCSANPHAM SET TenDanhMuc = @TenDanhMuc WHERE MaDanhMuc = @MaDanhMuc";  
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", category.MaDanhMuc);  
                    cmd.Parameters.AddWithValue("@TenDanhMuc", category.TenDanhMuc);  

                    int rowsAffected = cmd.ExecuteNonQuery();  
                    return rowsAffected > 0; 
                }
            }
        }
        public static bool DeleteCategory(int maDanhMuc)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM DANHMUCSANPHAM WHERE MaDanhMuc = @MaDanhMuc";  
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc); 
                    int rowsAffected = cmd.ExecuteNonQuery(); 
                    return rowsAffected > 0; 
                }
            }
        }
    }
}
