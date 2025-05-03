using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class messageBLL
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("chào") || input.Contains("xin chào"))
            {
                return "Chào bạn! Mình có thể giúp gì cho bạn?";
            }
            if (input.Contains("giảm giá") || input.Contains("khuyến mãi"))
            {
                return "Hôm nay có khuyến mãi giảm 10K cho hoá đơn từ 60K nha!";
            }
            if (input.Contains("giờ mở cửa") || input.Contains("mấy giờ mở cửa"))
            {
                return "Bên mình mở cửa từ 7h sáng đến 9h tối mỗi ngày bạn nhé.";
            }
            if (input.Contains("loại bánh") || input.Contains("có bánh"))
            {
                return "Mình có bánh mặn, ngọt, bánh mì, cookies nha!";
            }
            if (input.Contains("bánh nóng") || input.Contains("vừa ra lò"))
            {
                return "Có luôn nha! Bánh ngọt vừa ra lò lúc nãy còn thơm phức nè.";
            }
            if (input.Contains("giao hàng"))
            {
                return "Bên mình giao hàng nội thành bằng nhân viên hoặc Grab/ShopeeFood nha!";
            }
            if (input.Contains("phí giao hàng"))
            {
                return "Phí giao hàng từ 10k đến 20k tùy khoảng cách bạn nhé.";
            }
            if (input.Contains("thanh toán") || input.Contains("trả tiền"))
            {
                return "Bạn có thể thanh toán bằng tiền mặt, MoMo, VNPay nha.";
            }
            if (input.Contains("bánh chay") || input.Contains("ăn chay"))
            {
                return "Bên mình có bánh chay phù hợp người ăn chay nhé!";
            }
            if (input.Contains("hủy đơn") || input.Contains("huỷ đơn"))
            {
                return "Bạn nhắn mình sớm để hủy đơn trước khi giao nha!";
            }
            if (input.Contains("đặt hàng") || input.Contains("mua hàng"))
            {
                return "Bạn có thể đặt hàng tại quán, hoặc ShopeeFood và GrabFood bạn nhé!";
            }
            if (input.Contains("địa chỉ"))
            {
                return "Tiệm mình ở 10 Đường Lê Duẩn, Quận 1, TP.HCM nha.";
            }
            if (input.Contains("bánh nào ngon") || input.Contains("gợi ý"))
            {
                return "Bánh TIRAMISU và MACARON là best seller luôn đó!";
            }
            if (input.Contains("hôm nay có gì mới") || input.Contains("món mới"))
            {
                return "Hôm nay có bánh CROISSANT siêu ngon vừa ra lò nè!";
            }
            if (input.Contains("ship xa không"))
            {
                return "Bên mình có thể ship toàn TP.HCM qua bên thứ ba nha.";
            }
            if (input.Contains("không thấy phản hồi"))
            {
                return "Bạn chờ mình tí nhé, mình đang kiểm tra đơn hàng cho bạn đây.";
            }
            if (input.Contains("giao bao lâu"))
            {
                return "Thường từ 15–30 phút tùy khu vực, có thể nhanh hơn vào buổi sáng nha.";
            }
            if (input.Contains("tư vấn"))
            {
                return "Bạn đang cần tư vấn gì ạ? Về bánh, giá, combo hay dịp đặc biệt?";
            }
            if (input.Contains("bán sỉ") || input.Contains("mua số lượng"))
            {
                return "Bên mình có bán sỉ, mua nhiều sẽ được giá ưu đãi nha!";
            }
            if (input.Contains("bánh sinh nhật"))
            {
                return "Hiện bên mình có nhận đặt bánh sinh nhật cỡ nhỏ đến trung bình nha!";
            }
            if (input.Contains("combo") || input.Contains("set"))
            {
                return "Mình có combo sáng, combo chiều giá hạt dẻ luôn đó bạn!";
            }
            if (input.Contains("dịp đặc biệt") || input.Contains("sale nhiều"))
            {
                return "Mình có combo 30/4 mừng ngày thống nhất đất nước giá siêu ưu đãi luôn đó bạn!";
            }
                if (input.Contains("thành phần") || input.Contains("nguyên liệu"))
            {
                return "Nguyên liệu sạch, có nguồn gốc rõ ràng nha bạn, đảm bảo an toàn!";
            }
            if (input.Contains("giữ bánh") || input.Contains("bảo quản"))
            {
                return "Bánh ngọt nên bảo quản ngăn mát, dùng trong 2-3 ngày bạn nhé.";
            }
            if (input.Contains("cảm ơn") || input.Contains("thanks"))
            {
                return "Không có chi đâu ạ, rất vui được hỗ trợ bạn!. Chúc bạn một ngày vui vẻ ❤️";
            }
            if (input.Contains("bye") || input.Contains("tạm biệt"))
            {
                return "Tạm biệt bạn nhé! Chúc bạn một ngày vui vẻ ❤️";
            }

            return "Xin lỗi, mình chưa hiểu câu hỏi của bạn. Bạn hỏi lại giúp mình nhé!";
        }
    }
}
