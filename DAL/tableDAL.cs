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
    public class tableDAL
    {
        public static List<tableDTO> GetAllTables()
        {
            List<tableDTO> tables = new List<tableDTO>();
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM BAN";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Add(new tableDTO
                        {
                            MaBan = Convert.ToInt32(reader["MaBan"]),
                            TenBan = reader["TenBan"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
            }
            return tables;
        }

        public static bool InsertTable(tableDTO table)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO BAN (TenBan, TrangThai) VALUES (@TenBan, @TrangThai)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenBan", table.TenBan);
                    cmd.Parameters.AddWithValue("@TrangThai", table.TrangThai);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateTable(tableDTO table)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE BAN SET TenBan = @TenBan, TrangThai = @TrangThai WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", table.MaBan);
                    cmd.Parameters.AddWithValue("@TenBan", table.TenBan);
                    cmd.Parameters.AddWithValue("@TrangThai", table.TrangThai);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteTable(int maBan)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM BAN WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", maBan);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}