using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class paymentDTO
    {
        public int MaThanhToan { get; set; }
        public int MaDonHang { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int SoTien { get; set; }
        public string HinhThuc { get; set; }
    }
}
