using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ordersitemBLL
    {
        public static string CheckLogic(ordersitemDTO ordersitem)
        {
            if (ordersitem.MaDonHang <= 0)
            {
                return "required_MaDonHang";
            }
            if (string.IsNullOrEmpty(ordersitem.MaSanPham))
            {
                return "required_MaSanPham";
            }
            if (ordersitem.SoLuong <= 0)
            {
                return "required_SoLuong";
            }

            string result = ordersitemDAL.CheckLogic(ordersitem);
            if (result == "invalid")
            {
                return "invalid";
            }

            return "success";
        }

        public static List<ordersitemDTO> GetAllOrders()
        {
            try
            {
                return ordersitemDAL.GetAllOrders();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách đơn hàng: {ex.Message}");
                return new List<ordersitemDTO>();
            }
        }

        public static bool InsertOrdersitem(ordersitemDTO ordersitem)
        {
            try
            {
                return ordersitemDAL.InsertOrdersitem(ordersitem);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm đơn hàng: {ex.Message}");
                return false;
            }
        }

        public static bool UpdateOrdersitem(ordersitemDTO ordersitem)
        {
            try
            {
                return ordersitemDAL.UpdateOrdersitem(ordersitem);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật đơn hàng: {ex.Message}");
                return false;
            }
        }

        public static bool DeleteOrdersitem(int ordersitemid)
        {
            try
            {
                return ordersitemDAL.DeleteOrdersitem(ordersitemid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa đơn hàng: {ex.Message}");
                return false;
            }
        }
    }
}
