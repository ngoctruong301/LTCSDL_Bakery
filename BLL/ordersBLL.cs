using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ordersBLL
    {
        private ordersDAL OrdersDAL = new ordersDAL();

        public void ThemDonHang(int maBan, string maKhuyenMai, string trangThai)
        {
            if (maBan <= 0)
                throw new Exception("Mã bàn không hợp lệ.");
            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Trạng thái không được để trống.");


            OrdersDAL.ThemDonHang(maBan, maKhuyenMai, trangThai);
        }

        public DataTable LayDanhSachDonHang()
        {
            return OrdersDAL.LayDanhSachDonHang();
        }

        public void XoaDonHang(int maDonHang)
        {
            if (maDonHang <= 0)
                throw new Exception("Mã đơn hàng không hợp lệ.");
            paymentDAL PaymentDAL = new paymentDAL();
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM THANHTOAN WHERE MaDonHang = @MaDonHang", conn);
                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                cmd.ExecuteNonQuery();
            }

            OrdersDAL.XoaDonHang(maDonHang);
        }

        public void SuaDonHang(int maDonHang, int maBan, string trangThai, string maKhuyenMai)
        {
            if (maDonHang <= 0 || maBan <= 0)
                throw new Exception("Mã đơn hàng hoặc mã bàn không hợp lệ.");
            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Trạng thái không được để trống.");

            OrdersDAL.SuaDonHang(maDonHang, maBan, trangThai, maKhuyenMai);
        }
    }
}
