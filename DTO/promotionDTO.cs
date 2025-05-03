using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class promotionDTO
    {
        public string MaKhuyenMai { get; set; }
        public string TenKhuyenMai { get; set; }
        public int SoTienGiam { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
