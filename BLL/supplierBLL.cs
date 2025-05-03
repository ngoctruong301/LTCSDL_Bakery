using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class supplierBLL
    {
        public static List<supplierDTO> LayDanhSachNhaCungCap()
        {
            try
            {
                return supplierDAL.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhà cung cấp: " + ex.Message);
                return new List<supplierDTO>();
            }
        }

        public static bool ThemNhaCungCap(supplierDTO supplier)
        {
            try
            {
                return supplierDAL.InsertSupplier(supplier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm nhà cung cấp: " + ex.Message);
                return false;
            }
        }

        public static bool SuaNhaCungCap(supplierDTO supplier)
        {
            try
            {
                return supplierDAL.UpdateSupplier(supplier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật nhà cung cấp: " + ex.Message);
                return false;
            }
        }

        public static bool XoaNhaCungCap(string maNCC)
        {
            try
            {
                return supplierDAL.DeleteSupplier(maNCC);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhà cung cấp: " + ex.Message);
                return false;
            }
        }
    }
}
