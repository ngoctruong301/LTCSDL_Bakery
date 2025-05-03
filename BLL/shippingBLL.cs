using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class shippingBLL
    {
        private shippingDAL ShippingDAL = new shippingDAL();

        public void ThemGiaoHang(int maDonHang, string diaChi, int sdt, string trangThai)
        {
            if (maDonHang <= 0)
                throw new Exception("Mã đơn hàng không hợp lệ.");
            if (string.IsNullOrWhiteSpace(diaChi))
                throw new Exception("Địa chỉ không được để trống.");
            if (sdt <= 0)
                throw new Exception("Số điện thoại không hợp lệ.");
            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Trạng thái không được để trống.");

            ShippingDAL.ThemGiaoHang(maDonHang, diaChi, sdt, trangThai);
        }

        public DataTable LayDanhSachGiaoHang()
        {
            return ShippingDAL.LayDanhSachGiaoHang();
        }

        public void XoaGiaoHang(int maGiaoHang)
        {
            if (maGiaoHang <= 0)
                throw new Exception("Mã giao hàng không hợp lệ.");

            ShippingDAL.XoaGiaoHang(maGiaoHang);
        }

        public void SuaGiaoHang(int maGiaoHang, int maDonHang, string diaChi, int sdt, string trangThai)
        {
            if (maGiaoHang <= 0 || maDonHang <= 0)
                throw new Exception("Mã giao hàng hoặc mã đơn hàng không hợp lệ.");
            if (string.IsNullOrWhiteSpace(diaChi))
                throw new Exception("Địa chỉ không được để trống.");
            if (sdt <= 0)
                throw new Exception("Số điện thoại không hợp lệ.");
            if (string.IsNullOrWhiteSpace(trangThai))
                throw new Exception("Trạng thái không được để trống.");

            ShippingDAL.SuaGiaoHang(maGiaoHang, maDonHang, diaChi, sdt, trangThai);
        }
    }
}