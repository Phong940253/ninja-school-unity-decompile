public class InfoDlg
{
	public static bool isShow;

	private static string title;

	private static string subtitke;

	public static int delay;

	public static bool isLock;

	public static void show(string title, string subtitle, int delay)
	{
		if (title != null)
		{
			isShow = true;
			InfoDlg.title = title;
			subtitke = subtitle;
			InfoDlg.delay = delay;
		}
	}

	public static void showWait()
	{
		show(mResources.PLEASEWAIT, null, 5000);
		isLock = true;
	}

	public static void showWait(string str)
	{
		show(str, null, 5000);
		isLock = true;
	}

	public static void paint(mGraphics g)
	{
		string mapName = title;
		if (TileMap.mapName1 != null)
		{
			mapName = TileMap.mapName1;
		}
		if (isShow && (!isLock || delay <= 4990) && !GameScr.isPaintAlert)
		{
			int num = 10;
			GameCanvas.paintz.paintFrame(GameCanvas.hw - 64, num, 128, 40, g);
			if (isLock)
			{
				GameCanvas.paintShukiren(GameCanvas.hw - mFont.tahoma_8b.getWidth(mapName) / 2 - 10, num + 20, g, noRotate: false);
				mFont.tahoma_8b.drawString(g, mapName, GameCanvas.hw + 5, num + 13, 2);
			}
			else if (subtitke != null)
			{
				mFont.tahoma_8b.drawString(g, mapName, GameCanvas.hw, num + 8, 2);
				mFont.tahoma_7_white.drawString(g, subtitke, GameCanvas.hw, num + 22, 2);
			}
			else
			{
				mFont.tahoma_8b.drawString(g, mapName, GameCanvas.hw, num + 13, 2);
			}
		}
	}

	public static void update()
	{
		if (delay > 0)
		{
			delay--;
			if (delay == 0)
			{
				hide();
			}
		}
	}

	public static void hide()
	{
		title = string.Empty;
		subtitke = null;
		isLock = false;
		delay = 0;
		isShow = false;
	}
}
