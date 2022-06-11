public class LanguageScr : mScreen, IActionListener
{
	private int popupW;

	private int popupH;

	private int popupX;

	private int popupY;

	private static LanguageScr gi;

	private int indexRow = -1;

	public static bool isFromLogin;

	public override void switchToMe()
	{
		GameScr.gH = GameCanvas.h;
		if (GameCanvas.typeBg == 2)
		{
			GameCanvas.loadBG(0);
		}
		else
		{
			GameCanvas.loadBG(TileMap.bgID);
		}
		base.switchToMe();
		if (GameScr.instance != null)
		{
			GameScr.instance = null;
		}
		TileMap.bgID = (sbyte)(mSystem.getCurrentTimeMillis() % 9);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.loadCamera(fullScreen: true);
		GameScr.cmx = 100;
		popupW = 170;
		popupH = 175;
		popupX = GameCanvas.w / 2 - popupW / 2;
		popupY = GameCanvas.h / 2 - popupH / 2;
		if (GameCanvas.h <= 250)
		{
			popupY -= 10;
		}
		center = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 1000, null);
		right = new Command(mResources.EXIT, GameCanvas.instance, 8885, null);
		indexRow = -1;
		if (!GameCanvas.isTouch)
		{
			indexRow = 0;
		}
		if (GameCanvas.isTouch && GameCanvas.w >= 320)
		{
			center.x = GameCanvas.w / 2 - 35;
			right.x = GameCanvas.w / 2 + 88;
			center.y = (right.y = GameCanvas.h - 26);
		}
	}

	public override void paint(mGraphics g)
	{
		g.setColor(0);
		g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintBGGameScr(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		g.setColor(Paint.COLORDARK);
		g.fillRoundRect(GameCanvas.hw - mFont.tahoma_8b.getWidth(mResources.LANGUAGE) / 2 - 12, popupY + 7, mFont.tahoma_8b.getWidth(mResources.LANGUAGE) + 22, 24, 6, 6);
		g.setColor(Paint.COLORLIGHT);
		g.drawRoundRect(GameCanvas.hw - mFont.tahoma_8b.getWidth(mResources.LANGUAGE) / 2 - 12, popupY + 7, mFont.tahoma_8b.getWidth(mResources.LANGUAGE) + 22, 24, 6, 6);
		mFont.tahoma_8b.drawString(g, mResources.LANGUAGE, GameCanvas.hw, popupY + 10, 2);
		int num = popupY + 50;
		string[] lANGUAGES = mResources.LANGUAGES;
		for (int i = 0; i < lANGUAGES.Length; i++)
		{
			g.setColor(Paint.COLORDARK);
			g.fillRect(popupX + 10, num + i * 35, popupW - 20, 28);
			g.setColor(5720393);
			g.drawRect(popupX + 10, num + i * 35, popupW - 20, 28);
			if (i == indexRow)
			{
				g.setColor(Paint.COLORLIGHT);
				g.fillRect(popupX + 10, num + i * 35, popupW - 20, 28);
				g.setColor(11053224);
				g.drawRect(popupX + 10, num + i * 35, popupW - 20, 28);
			}
			mFont.tahoma_7b_white.drawString(g, lANGUAGES[i], popupX + popupW / 2, num + i * 35 + 5, 2);
		}
		base.paint(g);
		GameCanvas.paintz.paintCmdBar(g, left, center, right);
	}

	public static void saveLanguageID(int languageID)
	{
		RMS.saveRMSInt("indLanguage", languageID);
	}

	public static int loadLanguageID()
	{
		int num = 0;
		return RMS.loadRMSInt("indLanguage");
	}

	public override void update()
	{
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		base.update();
	}

	public override void updateKey()
	{
		if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(popupX + 10, popupY + 45, popupW - 10, 70))
		{
			if (GameCanvas.isPointerClick)
			{
				indexRow = (GameCanvas.py - (popupY + 45)) / 35;
			}
			if (indexRow >= 0)
			{
				perform(1000, null);
			}
		}
		if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[24] || GameCanvas.keyPressedz[25])
		{
			bool[] keyPressedz = GameCanvas.keyPressedz;
			int nUM = Key.NUM2;
			bool[] keyPressedz2 = GameCanvas.keyPressedz;
			int nUM2 = Key.NUM8;
			bool flag;
			GameCanvas.keyPressedz[24] = (flag = (GameCanvas.keyPressedz[25] = false));
			keyPressedz2[nUM2] = (flag = flag);
			keyPressedz[nUM] = flag;
			indexRow = ((indexRow == 0) ? 1 : 0);
		}
		base.updateKey();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			GameCanvas.currentDialog = null;
			RMS.clearRMS();
			GameMidlet.isWorldver = ((indexRow != 0) ? true : false);
			GameCanvas.instance.initGameCanvas();
			SelectServerScr.loadInfoIp(GameMidlet.GetWorldIndex());
			GameCanvas.selectsvScr.switchToMe();
		}
	}
}
