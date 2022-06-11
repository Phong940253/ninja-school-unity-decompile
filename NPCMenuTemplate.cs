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
        default:
            break;
        }

        return vector;
    }
}