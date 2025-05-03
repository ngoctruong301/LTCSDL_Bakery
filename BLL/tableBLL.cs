using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class tableBLL
    {
        public static List<tableDTO> GetAllTables()
        {
            return tableDAL.GetAllTables();
        }

        public static bool InsertTable(tableDTO table)
        {
            return tableDAL.InsertTable(table);
        }

        public static bool UpdateTable(tableDTO table)
        {
            return tableDAL.UpdateTable(table);
        }

        public static bool DeleteTable(int maBan)
        {
            return tableDAL.DeleteTable(maBan);
        }
    }
}