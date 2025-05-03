using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class userBLL
    {
        public static string CheckLogic(userDTO user)
        {
            if (string.IsNullOrEmpty(user.TaiKhoan))
            {
                return "requeid_taikhoan";
            }
            if (string.IsNullOrEmpty(user.MatKhau))
            {
                return "requeid_MatKhau";
            }
            string result = data_providerDAL.CheckLogic(user);
            if (result == "invalid")
            {
                return "invalid";
            }

            return "success";
        }
        public static List<userDTO> GetAllUsers()
        {
            try
            {
                return userDAL.GetAllUsers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy tất cả người dùng: {ex.Message}");
                return new List<userDTO>();
            }
        }
        public static bool InsertUser(userDTO user)
        {
            try
            {
                return userDAL.InsertUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm người dùng: {ex.Message}");
                return false;
            }
        }
        public static bool UpdateUser(userDTO user)
        {
            try
            {
                return userDAL.UpdateUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật người dùng: {ex.Message}");
                return false;
            }
        }
        public static bool DeleteUser(string username)
        {
            try
            {
                return userDAL.DeleteUser(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa người dùng: {ex.Message}");
                return false;
            }
        }
        public static string GetUserRole(string taiKhoan)
        {
            var user = GetAllUsers().FirstOrDefault(u => u.TaiKhoan.Equals(taiKhoan, StringComparison.OrdinalIgnoreCase));
            return user?.LoaiTaiKhoan ?? "unknown";
        }
    }
}
