using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class reportBLL
    {
        public static DataTable GetDoanhThu()
        {
            return reportDAL.GetDoanhThu(); 
        }
        public static DataTable GetSoLuongDon()
        {
            return reportDAL.GetSoLuongDon();
        }
        public static DataTable GetDoanhThuTheoHinhThuc()
        {
            return reportDAL.GetDoanhThuTheoHinhThuc();
        }
    }
}
