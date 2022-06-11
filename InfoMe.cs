public class InfoMe
{
	public static MyVector infoWaitToShow = new MyVector();

	public static InfoItem info;

	public static int p1 = 5;

	public static int p2;

	public static int p3;

	public static int x;

	public static int strWidth;

	public static int limLeft = 2;

	public static int hI = 20;

	public static void paint(mGraphics g)
	{
		g.setClip(0, -200, GameCanvas.w, 200 + GameCanvas.h);
		int num = limLeft;
		int num2 = GameCanvas.h - 23;
		int num3 = GameCanvas.w;
		if (GameCanvas.isTouch)
		{
			if (GameCanvas.w >= 450)
			{
				num = 130;
				num3 = GameCanvas.w - 2 * num;
			}
			else
			{
				num = 80;
				num3 = GameCanvas.w - 2 * num - 10;
			}
			num2 = GameCanvas.h - 60;
			limLeft = num + 2;
		}
		if (info != null && (GameCanvas.currentDialog == null || GameCanvas.currentDialog.center == null))
		{
			g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
			g.setColor(0, 0.4f);
			g.fillRect(num - 2, num2, num3 + 2, hI);
			g.setClip(num, num2, num3, hI);
			info.f.drawString(g, info.s, x, num2 + 2, 0);
		}
	}

	public static void update()
	{
		if (p1 == 0)
		{
			x += (limLeft - x) / 3;
			if (x - limLeft < 3)
			{
				x = limLeft + 2;
				p1 = 2;
				p2 = 0;
			}
		}
		else if (p1 == 2)
		{
			p2++;
			if (p2 > info.speed)
			{
				p1 = 3;
				p2 = 0;
			}
		}
		else if (p1 == 3)
		{
			if (x + strWidth < limLeft + GameCanvas.w - 20)
			{
				x -= 6;
			}
			else
			{
				x -= 2;
			}
			if (x + strWidth < limLeft)
			{
				p1 = 4;
				p2 = 0;
			}
		}
		else if (p1 == 4)
		{
			p2++;
			if (p2 > 10)
			{
				p1 = 5;
				p2 = 0;
			}
		}
		else
		{
			if (p1 != 5)
			{
				return;
			}
			if (infoWaitToShow.size() > 0)
			{
				InfoItem infoItem = (InfoItem)infoWaitToShow.firstElement();
				infoWaitToShow.removeElementAt(0);
				if (info == null || !infoItem.s.Equals(info.s))
				{
					info = infoItem;
					strWidth = info.f.getWidth(info.s);
					p1 = (p2 = 0);
					x = GameCanvas.w;
				}
			}
			else
			{
				info = null;
			}
		}
	}

	public static void addInfo(string s)
	{
		if (!canMergeString(s))
		{
			if (GameCanvas.w == 128)
			{
				limLeft = 1;
			}
			if (infoWaitToShow.size() > 10)
			{
				infoWaitToShow.removeElementAt(0);
			}
			infoWaitToShow.addElement(new InfoItem(s));
		}
	}

	private static bool canMergeString(string s)
	{
		if (info != null && info.s != null && s.Equals(info.s))
		{
			return true;
		}
		if (infoWaitToShow.size() > 0 && s.Equals(((InfoItem)infoWaitToShow.lastElement()).s))
		{
			return true;
		}
		if (s.Length < 8)
		{
			return false;
		}
		if (info != null && info.s != null && p1 < 3 && info.s.Length >= 8)
		{
			string text = s.Substring(0, 8);
			string value = info.s.Substring(0, 8);
			if (text.Equals(value))
			{
				int i;
				for (i = 7; i < s.Length && i < info.s.Length && (s[i] < '0' || s[i] > '9') && s[i] == info.s[i]; i++)
				{
				}
				string text2 = s.Substring(i);
				InfoItem infoItem = info;
				infoItem.s = infoItem.s + ", " + text2;
				p1 = 2;
				p2 = 0;
				return true;
			}
		}
		if (infoWaitToShow.size() > 0)
		{
			string s2 = ((InfoItem)infoWaitToShow.lastElement()).s;
			if (s2.Length >= 8)
			{
				string text3 = s.Substring(0, 8);
				string value2 = s2.Substring(0, 8);
				if (text3.Equals(value2))
				{
					int j;
					for (j = 7; j < s.Length && j < s2.Length && (s[j] < '0' || s[j] > '9') && s[j] == s2[j]; j++)
					{
					}
					string text4 = s.Substring(j, s.Length);
					s2 = s2 + ", " + text4;
					return true;
				}
			}
		}
		return false;
	}

	public static void addInfo(string s, int speed, mFont f)
	{
		if (GameCanvas.msgdlg != null && GameCanvas.msgdlg.isIpad)
		{
			GameCanvas.endDlg();
		}
		if (!canMergeString(s))
		{
			if (GameCanvas.w == 128)
			{
				limLeft = 1;
			}
			if (infoWaitToShow.size() > 10)
			{
				infoWaitToShow.removeElementAt(0);
			}
			infoWaitToShow.addElement(new InfoItem(s, f, speed));
		}
	}

	public static bool isEmpty()
	{
		return p1 == 5 && infoWaitToShow.size() == 0;
	}
}
