using System;

public class NPCMenuTemplate {
    public NPCMenuTemplate() {}

    public static MyVector getVectorMenu(MyVector vector, int npcId) {
        switch (npcId) {
        case 0:
            // Kanata
            vector.addElement(new Command("Binh khí", GameCanvas.instance, 88820, new string[0]));

            string[] option02 = {
                "",
                "Thành lập",
                "Lãnh Địa gia tộc",
                "Đổi túi quà",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Gia tộc", GameCanvas.instance, 88820, option02));

            string[] option03 = {
                "",
                "Nhận thưởng",
                "Cấp 35",
                "Cấp 45",
                "Cấp 55",
                "Cấp 65",
                "Cấp 75",
                "Cấp 95"
            };
            vector.addElement(new Command("Hang động sau trường", GameCanvas.instance, 88820, option03));

            string[] option04 = {
                "",
                "Thách đấu",
                "Xem thi đấu",
                "Kết quả",
                "Ninja tài năng",
                "Xếp hạng tài năng"
            };
            vector.addElement(new Command("Lôi đài", GameCanvas.instance, 88820, option04));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 1:
            // Furoya
            string[] option11 = {
                "",
                "Nón",
                "Áo",
                "Găng tay",
                "Quần",
                "Giày"
            };
            vector.addElement(new Command("Y phục", GameCanvas.instance, 88820, option11));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 2:
            // Ameji
            string[] option21 = {
                "",
                "Liên",
                "Nhẫn",
                "Ngọc bội",
                "Phù",
            };
            vector.addElement(new Command("Trang sức", GameCanvas.instance, 88820, option21));
            string[] option22 = {
                "",
                "Nhận",
                "Trả",
                "Hủy",
                "Nhận Geningan",
                "Nâng cấp",
                "Nâng cấp vip",
                "Hướng dẫn / Nhiệm vụ"
            };
            vector.addElement(new Command("Nhiệm vụ danh vọng", GameCanvas.instance, 88820, option22));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 3:
            // Kiriko
            vector.addElement(new Command("Dược phẩm (Yên)", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Dược phẩm (Xu)", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 4:
            // Tabemono
            vector.addElement(new Command("thức ăn (yên)", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("thức ăn (xu)", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("nói chuyện", GameCanvas.instance, 88820, new string[0]));

            string[] option44 = {
                "",
                "đăng ký",
                "chinh phục",
                "thiên bảng",
                "địa bảng"
            };
            vector.addElement(new Command("thiên địa bảng", GameCanvas.instance, 88820, option44));

            break;

        case 5:
            // Kamakura
            string[] option51 = {
                "",
                "Rương đồ",
                "Bộ sưu tập",
                "Cải trang",
                "Tháo cải trang",
            };
            vector.addElement(new Command("Mở rương", GameCanvas.instance, 88820, option51));
            vector.addElement(new Command("Lưu tọa độ", GameCanvas.instance, 88820, new string[0]));
            string[] option53 = {
                "",
                "Đi tới",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Vùng đất Ma Quỷ", GameCanvas.instance, 88820, option53));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 6:
            // Kenshinto
            string[] option61 = {
                "",
                "Thường",
                "Cẩn thận",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Nâng cấp", GameCanvas.instance, 88820, option61));
            string[] option62 = {
                "",
                "Yên",
                "Xu",
            };
            vector.addElement(new Command("Luyện đá", GameCanvas.instance, 88820, option62));
            vector.addElement(new Command("Tách đá", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Chuyển hóa", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Luyện ngọc", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Khảm", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Gọt ngọc", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Tháo ngọc", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 7:
            // Umayaki lang
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Kojin", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Sanzu", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Tone", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng chài", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Chakumi", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Echigo", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Làng Oshin", GameCanvas.instance, 88820, new string[0]));
            break;
        case 8:
            // Umayaki truong
            vector.addElement(new Command("Trường Hirosaki", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Trường Haruna", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Trường Ookaza", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            break;
        case 9:
            // Cô Toyotomi
            string[] option91 = {
                "",
                "Top đại gia",
                "Top cao thủ",
                "Top gia tộc",
                "Top hang động"
            };
            vector.addElement(new Command("Bảng xếp hạng", GameCanvas.instance, 88820, option91));
            string[] option92 = {
                "",
                "Ninja Kiếm",
                "Ninja Phi Tiêu"
            };
            vector.addElement(new Command("Nhập học", GameCanvas.instance, 88820, option92));
            string[] option93 = {
                "",
                "Tiềm năng",
                "Kỹ năng",
            };
            vector.addElement(new Command("Tẩy điểm", GameCanvas.instance, 88820, option93));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            string[] option95 = {
                "",
                "Tham gia",
                "Thành tích",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Giao chiến", GameCanvas.instance, 88820, option95));
            break;
        case 10:
            // Thầy Ookamesama
            string[] option101 = {
                "",
                "Top đại gia",
                "Top cao thủ",
                "Top gia tộc",
                "Top hang động"
            };
            vector.addElement(new Command("Bảng xếp hạng", GameCanvas.instance, 88820, option101));
            string[] option102 = {
                "",
                "Ninja Kunai",
                "Ninja Cung"
            };
            vector.addElement(new Command("Nhập học", GameCanvas.instance, 88820, option102));
            string[] option103 = {
                "",
                "Tiềm năng",
                "Kỹ năng",
            };
            vector.addElement(new Command("Tẩy điểm", GameCanvas.instance, 88820, option103));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            string[] option105 = {
                "",
                "Tham gia",
                "Thành tích",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Giao chiến", GameCanvas.instance, 88820, option105));
            break;
        case 11:
            // Thầy Kazeto
            string[] option111 = {
                "",
                "Top đại gia",
                "Top cao thủ",
                "Top gia tộc",
                "Top hang động"
            };
            vector.addElement(new Command("Bảng xếp hạng", GameCanvas.instance, 88820, option111));
            string[] option112 = {
                "",
                "Ninja Đao",
                "Ninja Quạt"
            };
            vector.addElement(new Command("Nhập học", GameCanvas.instance, 88820, option112));
            string[] option113 = {
                "",
                "Tiềm năng",
                "Kỹ năng",
            };
            vector.addElement(new Command("Tẩy điểm", GameCanvas.instance, 88820, option113));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            string[] option115 = {
                "",
                "Tham gia",
                "Thành tích",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Giao chiến", GameCanvas.instance, 88820, option115));
            break;
        case 12:
            // Tajima
            string[] option121 = {
                "",
                "Cách chơi",
                "Nhân vật",
                "Chức năng PK",
                "Lập nhóm",
                "Luyện đá",
                "Nâng cấp",
                "Điểm hoạt động"
            };
            vector.addElement(new Command("Hướng dẫn", GameCanvas.instance, 88820, option121));
            vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Hủy vật phẩm và nhiệm vụ", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Thứ thân", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Chủ thân", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Nhận quà top event", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Cài đặt mời", GameCanvas.instance, 88820, new string[0]));
            break;
        case 25:
            // Rikudou
            string[] option251 = {
                "",
                "Nhận",
                "Hủy",
                "Hoàn thành",
                "Đi làm NV",
            };
            vector.addElement(new Command("NV mỗi ngày", GameCanvas.instance, 88820, option251));
        
            string[] option252 = {
                "",
                "Nhận",
                "Hủy",
                "Hoàn thành",
            };
            vector.addElement(new Command("NV truy bắt Tà thú", GameCanvas.instance, 88820, option252));

            string[] option253 = {
                "",
                "Bạch Giả",
                "Hắc Giả",
                "Tổng kết",
                "Hướng dẫn"
            };
            vector.addElement(new Command("Chiến trường", GameCanvas.instance, 88820, option253));
            vector.addElement(new Command("Thất thú ải", GameCanvas.instance, 88820, new string[0]));
            break;
        case 26:
            // Goosho
            vector.addElement(new Command("Cửa hàng", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Quầy sách", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Thời trang", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Gia tộc", GameCanvas.instance, 88820, new string[0]));
            break;
        case 27:
            // Shinwa
            vector.addElement(new Command("Gian hàng", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Bán vật phẩm", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Nhận lại vật phẩm", GameCanvas.instance, 88820, new string[0]));
            vector.addElement(new Command("Tìm kiếm vật phẩm", GameCanvas.instance, 88820, new string[0]));
            break;
        default:
            break;
        }

        return vector;
    }
}