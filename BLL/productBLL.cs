using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class productBLL
    {
        public static List<productDTO> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public static bool AddProduct(productDTO product)
        {
            return productDAL.InsertProduct(product);
        }

        public static bool UpdateProduct(productDTO product)
        {
            return productDAL.UpdateProduct(product);
        }

        public static bool DeleteProduct(string maSanPham)
        {
            return productDAL.DeleteProduct(maSanPham);
        }
    }
}
