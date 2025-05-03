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
    public class userDAL
    {
        public static string CheckLogic(userDTO user)
        {
            return data_providerDAL.CheckLogic(user);
        }
        public static List<userDTO> GetAllUsers()
        {
            List<userDTO> users = new List<userDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM TAIKHOAN";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userDTO user = new userDTO
                            {
                                TaiKhoan = reader["TaiKhoan"].ToString(),
                                MatKhau = reader["MatKhau"].ToString(),
                                LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString()
                            };
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }
        public static bool InsertUser(userDTO user)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO TAIKHOAN (TaiKhoan, MatKhau, LoaiTaiKhoan) VALUES (@TaiKhoan, @MatKhau, @LoaiTaiKhoan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", user.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", user.MatKhau);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", user.LoaiTaiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool UpdateUser(userDTO user)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE TAIKHOAN SET MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE TaiKhoan = @TaiKhoan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", user.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", user.MatKhau);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", user.LoaiTaiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public static bool DeleteUser(string taiKhoan)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM TAIKHOAN WHERE TaiKhoan = @TaiKhoan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
        }
    }
}
