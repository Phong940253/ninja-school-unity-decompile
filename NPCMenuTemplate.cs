using System;

public class NPCMenuTemplate
{
	public NPCMenuTemplate()
	{
	}

	public static MyVector getVectorMenu(MyVector vector, int npcId)
    {
        switch (npcId)
        {
            case 1:
                vector.addElement(new Command("Binh khí",  GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Gia tộc",  GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Hang động sau trường",  GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Lôi đài",  GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Nói chuyện",  GameCanvas.instance, 88820, {}));

            case 3:
                vector.addElement(new Command("Dược phẩm (Yên)", GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Dược phẩm (Xu)", GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("Nói chuyện", GameCanvas.instance, 88820, {}));
                break;
            case 4:
                vector.addElement(new Command("thức ăn (yên)", GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("thức ăn (xu)", GameCanvas.instance, 88820, {}));
                vector.addElement(new Command("nói chuyện", GameCanvas.instance, 88820, {}));

                string[] option4 = { "đăng ký", "chinh phục", "thiên bảng", "địa bảng" };
                vector.addElement(new Command("thiên địa bảng", GameCanvas.instance, 88820, option4));

                break;
            default:
                break;
        }

        return vector;
    }
}
