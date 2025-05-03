using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DTO;
using DAL;


namespace DAL
{
    public class SqlconnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = ConfigurationManager.ConnectionStrings["BakeryMS"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class data_providerDAL
    {
        public static string CheckLogic(userDTO user)
        {
            string loaiTaiKhoan = null;

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();

                string query = "SELECT * FROM TAIKHOAN WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", user.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", user.MatKhau);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                        }
                    }
                }
            }

            return loaiTaiKhoan ?? "invalid"; 
        }
    }
    public class DataProvider
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BakeryMS"].ConnectionString;
        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
       
    }

}
