using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class promotionBLL
    {
        private promotionDAL PromotionDAL = new promotionDAL();
        public void ThemKhuyenMai(string maKhuyenMai, string tenKhuyenMai, int soTienGiam, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (string.IsNullOrWhiteSpace(maKhuyenMai) || string.IsNullOrWhiteSpace(tenKhuyenMai))
                throw new Exception("Mã và tên khuyến mãi không được để trống.");
            if (soTienGiam <= 0)
                throw new Exception("Số tiền giảm phải lớn hơn 0.");
            if (ngayKetThuc < ngayBatDau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu.");

            PromotionDAL.ThemKhuyenMai(maKhuyenMai, tenKhuyenMai, soTienGiam, ngayBatDau, ngayKetThuc);
        }
        public DataTable LayDanhSachKhuyenMai()
        {
            return PromotionDAL.LayDanhSachKhuyenMai();
        }

        public void XoaKhuyenMai(string maKhuyenMai)
        {
            if (string.IsNullOrWhiteSpace(maKhuyenMai))
                throw new Exception("Mã khuyến mãi không được để trống.");

            PromotionDAL.XoaKhuyenMai(maKhuyenMai);
        }
        public void SuaKhuyenMai(string maKhuyenMai, string tenKhuyenMai, int soTienGiam, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (string.IsNullOrWhiteSpace(maKhuyenMai) || string.IsNullOrWhiteSpace(tenKhuyenMai))
                throw new Exception("Mã và tên khuyến mãi không được để trống.");
            if (soTienGiam <= 0)
                throw new Exception("Số tiền giảm phải lớn hơn 0.");
            if (ngayKetThuc < ngayBatDau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu.");

            PromotionDAL.SuaKhuyenMai(maKhuyenMai, tenKhuyenMai, soTienGiam, ngayBatDau, ngayKetThuc);
        }
    }
}
