using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
   public class categoryBLL
    {
        public static string CheckLogic(categoryDTO category)
        {
            if (category.MaDanhMuc <= 0)
            {
                return "required_MaDanhMuc"; 
            }
            if (string.IsNullOrEmpty(category.TenDanhMuc))
            {
                return "required_TenDanhMuc"; 
            }
            string result = categoryDAL.CheckLogic(category);  
            if (result == "invalid")
            {
                return "invalid";  
            }

            return "success";  
        }
        public static List<categoryDTO> GetAllCategories()
        {
            try
            {
                return categoryDAL.GetAllCategories();  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy tất cả danh mục: {ex.Message}");
                return new List<categoryDTO>();  
            }
        }
        public static bool InsertCategory(categoryDTO category)
        {
            try
            {
                return categoryDAL.InsertCategory(category); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm danh mục: {ex.Message}");
                return false; 
            }
        }
        public static bool UpdateCategory(categoryDTO category)
        {
            try
            {
                return categoryDAL.UpdateCategory(category);  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật danh mục: {ex.Message}");
                return false; 
            }
        }
        public static bool DeleteCategory(int categoryId)
        {
            try
            {
                return categoryDAL.DeleteCategory(categoryId); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa danh mục: {ex.Message}");
                return false;  
            }
        }
    }
}
