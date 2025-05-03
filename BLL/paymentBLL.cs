using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class paymentBLL
    {
        private paymentDAL PaymentDAL = new paymentDAL();

        public void ThemThanhToan(int maDonHang, int soTien, string hinhThuc)
        {
            if (maDonHang <= 0)
                throw new Exception("Mã đơn hàng không hợp lệ.");
            if (soTien <= 0)
                throw new Exception("Số tiền phải lớn hơn 0.");
            if (string.IsNullOrWhiteSpace(hinhThuc))
                throw new Exception("Hình thức thanh toán không được để trống.");

            PaymentDAL.ThemThanhToan(maDonHang, soTien, hinhThuc);
        }

        public DataTable LayDanhSachThanhToan()
        {
            return PaymentDAL.LayDanhSachThanhToan();
        }

        public void XoaThanhToan(int maThanhToan)
        {
            if (maThanhToan <= 0)
                throw new Exception("Mã thanh toán không hợp lệ.");

            PaymentDAL.XoaThanhToan(maThanhToan);
        }

        public void SuaThanhToan(int maThanhToan, int maDonHang, int soTien, string hinhThuc)
        {
            if (maDonHang <= 0)
                throw new Exception("Mã thanh toán hoặc mã đơn hàng không hợp lệ.");
            if (soTien <= 0)
                throw new Exception("Số tiền phải lớn hơn 0.");
            if (string.IsNullOrWhiteSpace(hinhThuc))
                throw new Exception("Hình thức thanh toán không được để trống.");

            PaymentDAL.SuaThanhToan(maThanhToan, maDonHang, soTien, hinhThuc);
        }
    }
}
