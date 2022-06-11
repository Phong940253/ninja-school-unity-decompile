public class RegisterScr : mScreen, IActionListener
{
	public static RegisterScr instance;

	private int xPanel;

	private int yPanel;

	private int wPanel;

	private int hPanel;

	private int wC;

	private int xT;

	private int focus;

	public TField[] tf = new TField[7];

	private string[] menuName = new string[8] { "Họ và tên", "Ngày, tháng, năm sinh", "Địa chỉ thường trú", "CMND", "Ngày cấp", "Nơi cấp", "Số điện thoại, địa chỉ thư điện tử (nếu có).", "* Dưới 18 tuổi chỉ có thể chơi 180p 1 ngày" };

	private string[] menuInfo = new string[8]
	{
		"Nguyen Van A",
		"17-03-1991",
		"34 Phan A p.12 q.BT",
		"987654321",
		"01-01-2011",
		"TP.Hồ Chí Minh",
		"abc@gmail.com",
		string.Empty
	};

	public Scroll scroll = new Scroll();

	private Command cmdDK;

	public RegisterScr()
	{
		instance = this;
		xPanel = GameCanvas.hw - 100;
		yPanel = 10;
		wPanel = 200;
		hPanel = GameCanvas.h - 40;
		wC = wPanel - 40;
		xT = GameCanvas.hw - wC / 2;
		for (int i = 0; i < tf.Length; i++)
		{
			tf[i] = new TField();
			tf[i].name = menuName[i];
			tf[i].x = xT;
			tf[i].y = (i + 1) * 50;
			tf[i].width = wC;
			tf[i].height = mScreen.ITEM_HEIGHT + 2;
			tf[i].isFocus = false;
			tf[i].setIputType(TField.INPUT_ALPHA_NUMBER_ONLY);
			tf[i].setText(menuInfo[i]);
			if (i == 0)
			{
				tf[i].isFocus = true;
			}
		}
		left = (cmdDK = new Command(mResources.REGISTER, this, 1, null));
	}

	public static RegisterScr gI()
	{
		if (instance == null)
		{
			instance = new RegisterScr();
		}
		return instance;
	}

	public override void update()
	{
		base.update();
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		for (int i = 0; i < tf.Length; i++)
		{
			tf[i].update();
		}
		ScrollResult scrollResult = new ScrollResult();
		scrollResult = scroll.updateKey();
		if (scrollResult.isDowning || scrollResult.isFinish)
		{
			focus = (byte)scrollResult.selected;
		}
		scroll.updatecm();
		if (scrollResult.isFinish)
		{
		}
		if (focus == -1)
		{
			for (int j = 0; j < tf.Length; j++)
			{
				tf[j].isFocus = false;
			}
		}
	}

	public override void keyPress(int keyCode)
	{
		base.keyPress(keyCode);
		for (int i = 0; i < tf.Length; i++)
		{
			if (tf[i].isFocus)
			{
				tf[i].keyPressed(keyCode);
			}
		}
	}

	public override void updateKey()
	{
		if (GameCanvas.keyPressedz[2])
		{
			focus--;
			if (focus < 0)
			{
				focus = menuName.Length;
			}
			scroll.moveTo(focus * scroll.ITEM_SIZE);
		}
		else if (GameCanvas.keyPressedz[8])
		{
			focus++;
			if (focus > menuName.Length)
			{
				focus = 0;
			}
			scroll.moveTo(focus * scroll.ITEM_SIZE);
		}
		if (GameCanvas.keyPressedz[2] || GameCanvas.keyPressedz[8])
		{
			GameCanvas.clearKeyPressed();
			for (int i = 0; i < tf.Length; i++)
			{
				tf[i].isFocus = false;
			}
			if (focus < tf.Length)
			{
				tf[focus].isFocus = true;
			}
			scroll.moveTo(focus * scroll.ITEM_SIZE);
		}
		if (GameCanvas.isPointerHoldIn(xPanel, yPanel, wPanel, hPanel) && GameCanvas.isPointerJustRelease)
		{
			for (int j = 0; j < tf.Length; j++)
			{
				if (GameCanvas.isPointerHoldIn(tf[j].x, tf[j].y, tf[j].width, tf[j].height))
				{
					focus = j;
				}
			}
		}
		base.updateKey();
		GameCanvas.clearKeyPressed();
	}

	public override void paint(mGraphics g)
	{
		g.setColor(0);
		g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintBGGameScr(g);
		GameCanvas.paintz.paintFrame(xPanel, yPanel, wPanel, hPanel, g);
		mFont.tahoma_7b_white.drawString(g, mResources.REGISTER, GameCanvas.hw, yPanel + 10, 2);
		scroll.setStyle(menuName.Length, 50, xPanel, yPanel + 25, wPanel, hPanel - 25, styleUPDOWN: true, 0);
		scroll.setClip(g, xPanel, yPanel + 25, wPanel, hPanel - 25);
		for (int i = 0; i < menuName.Length; i++)
		{
			if (i != menuName.Length - 1)
			{
				mFont.tahoma_7_yellow.drawString(g, menuName[i], GameCanvas.hw, (i + 1) * 50 - 13, 2);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, menuName[i], GameCanvas.hw, (i + 1) * 50 - 13, 2);
			}
		}
		for (int j = 0; j < tf.Length; j++)
		{
			tf[j].paint_NonSetClip(g);
		}
		base.paint(g);
	}

	public override void switchToMe()
	{
		base.switchToMe();
		scroll.clear();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			doRegister();
		}
	}

	private void doRegister()
	{
		Service.gI().info_Kiemduyet(tf[0].getText(), tf[1].getText(), tf[2].getText(), tf[3].getText(), tf[4].getText(), tf[5].getText(), tf[6].getText());
		GameCanvas.isKiemduyet_info = false;
		GameScr.gI().switchToMe();
	}
}
