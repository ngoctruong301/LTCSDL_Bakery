# LTCSDL_Bakery
Một hệ thống quản lý tiệm bánh được phát triển trong môn **Lập trình cơ sở dữ liệu**.

## Mô tả dự án
Hệ thống này giúp quản lý các chức năng:
- Đăng nhập hệ thống với phân quyền tài khoản
- Quản lý sản phẩm (tên bánh, giá, số lượng,…)
- Quản lý khách hàng, hoá đơn, thanh toán
- Báo cáo thống kê doanh thu theo phương thức thanh toán, sản phẩm, ngày
- Chatbot AI tư vấn, hỗ trợ khách hàng

## Công nghệ sử dụng
- **Ngôn ngữ**: C# (Windows Forms)
- **Database**: SQL Server
- **AI hỗ trợ**: Chatbot demo nội bộ
- **Báo cáo thống kê**: Giao diện thống kê tự thiết kế

## Mô hình cơ sở dữ liệu
Gồm các bảng:
- 'TAI KHOAN' - thông tin người dùng
- 'SAN PHAM' - danh mục bánh
- 'DON HANG' - đơn đặt hàng
- 'NHA CUNG CAP' - quản lý nhà cung cấp nguyên liệu
- 'CHI TIET DON HANG' - chi tiết từng đơn hàng
- 'THANH TOAN' - phương thức thanh toán
- 'KHUYEN MAI' - chương trình khuyến mãi
- 'BAO CAO THONG KE' - dữ liệu phục vụ báo cáo

## Giao diện demo
- [Form Đăng nhập] (images/login.jpeg)
- [Form Trang chủ] (images/main.jpeg)
- [Form Tài khoản] (images/account.jpeg)
- [Form Sản phẩm] (images/products.jpeg)
- [Form Chi tiết sản phẩm] (images/productsdetail.jpeg)
- [Form Hoá đơn] (images/bill.jpeg)
- [Form Thanh toán] (images/payment.jpeg)
- [Form Chương trình khuyến mãi] (images/promo.jpeg)
- [Form Báo cáo thống kê] (images/report.jpeg)
- [Form Chat bot] (images/chatbot.jpeg)
## Cách cài đặt và chạy
- Clone repo:
   ```bash
   git clone https://github.com/ngoctruong301/LTCSDL_Bakery.git
- Mở file .sln trong Visual Studio
- Khôi phục CSDL SQL Server từ file backup nếu có (.bak)
- Cập nhật chuỗi kết nối (connection string) trong project cho đúng thông tin máy bạn
- Build & Run project
