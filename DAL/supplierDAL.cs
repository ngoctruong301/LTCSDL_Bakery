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
    public class supplierDAL
    {
        public static List<supplierDTO> GetAllSuppliers()
        {
            List<supplierDTO> suppliers = new List<supplierDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM NHACUNGCAP";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            supplierDTO supplier = new supplierDTO
                            {
                                MaNCC = reader["MaNCC"].ToString(),
                                TenNCC = reader["TenNCC"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT = Convert.ToInt32(reader["SDT"]) // ✅ chuyển đổi từ object sang int
                            };
                            suppliers.Add(supplier);
                        }
                    }
                }
            }

            return suppliers;
        }

        public static bool InsertSupplier(supplierDTO supplier)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT) VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", supplier.MaNCC);
                    cmd.Parameters.AddWithValue("@TenNCC", supplier.TenNCC);
                    cmd.Parameters.AddWithValue("@DiaChi", supplier.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", supplier.SDT); // ✅ int được chấp nhận

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateSupplier(supplierDTO supplier)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE NHACUNGCAP SET TenNCC = @TenNCC, DiaChi = @DiaChi, SDT = @SDT WHERE MaNCC = @MaNCC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", supplier.MaNCC);
                    cmd.Parameters.AddWithValue("@TenNCC", supplier.TenNCC);
                    cmd.Parameters.AddWithValue("@DiaChi", supplier.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", supplier.SDT);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteSupplier(string maNCC)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "DELETE FROM NHACUNGCAP WHERE MaNCC = @MaNCC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
