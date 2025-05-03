using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DAL
{
    public class reportDAL
    {
        public static DataTable GetDoanhThu()
        {
            string query = @"SELECT CONVERT(DATE, NgayThanhToan) AS Ngay, SUM(SoTien) AS TongDoanhThu FROM THANHTOAN GROUP BY CONVERT(DATE, NgayThanhToan) ORDER BY Ngay";
            return DataProvider.GetData(query);
        }

        public static DataTable GetSoLuongDon()
        {
            string query = @"SELECT TrangThai, COUNT(*) AS SoLuongDon FROM DONHANG GROUP BY TrangThai";
            return DataProvider.GetData(query);
        }

        public static DataTable GetDoanhThuTheoHinhThuc()
        {
            string query = @"SELECT HinhThuc, SUM(SoTien) AS DoanhThu FROM THANHTOAN GROUP BY HinhThuc";
            return DataProvider.GetData(query);
        }
    }
}
