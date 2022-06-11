public class MapScr : mScreen, IActionListener
{
	private static MapScr instance;

	private bool modeCurrentMap;

	public static Image imgMap = null;

	public static Image imgX;

	public static Image imgPointer;

	public static int mapW;

	public static int mapH;

	public static int mfx;

	public static int mfy;

	public static int mpoint;

	public static int tick3;

	public static int mcmtoX;

	public static int mcmtoY;

	public static int mcmvx;

	public static int mcmvy;

	public static int mcmdx;

	public static int mcmdy;

	public static int mcmx;

	public static int mcmy;

	public static int mcmxLim;

	public static int mcmyLim;

	public static int taskmapId;

	private static int dx = 0;

	private static int dy = 0;

	public static int[] x = new int[193]
	{
		1, 156, 140, 174, 196, 195, 125, 148, 156, 173,
		199, 203, 222, 264, 283, 277, 298, 307, 311, 315,
		116, 90, 59, 31, 252, 55, 81, 111, 148, 187,
		219, 253, 278, 304, 311, 310, 284, 309, 294, 62,
		92, 117, 99, 134, 154, 175, 34, 52, 40, 78,
		59, 82, 114, 179, 158, 142, 1, 215, 291, 242,
		147, 301, 71, 23, 116, 126, 305, 286, 264, 20,
		46, 70, 78, 2, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1
	};

	public static int[] y = new int[193]
	{
		1, 68, 75, 88, 80, 107, 87, 114, 136, 160,
		168, 196, 216, 219, 248, 265, 276, 260, 232, 204,
		111, 82, 79, 59, 168, 33, 28, 34, 45, 20,
		54, 44, 19, 40, 60, 100, 175, 165, 134, 181,
		199, 208, 221, 220, 219, 221, 195, 217, 246, 244,
		250, 263, 262, 241, 252, 244, 2, 240, 197, 139,
		16, 18, 208, 223, 239, 186, 120, 119, 135, 107,
		125, 126, 148, 3, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1
	};

	private int maxPX;

	private int maxPY;

	private int xM;

	private int yM;

	private bool trans;

	private int lastX;

	private int lastY;

	public static int lastpoint;

	public MapScr()
	{
		right = new Command(mResources.CLOSE, this, 1000, null);
		center = new Command(mResources.CHANGE, this, 1001, null);
		left = new Command(string.Empty, this, 14004, null);
	}

	protected void resetCMLim()
	{
		int imageWidth = mGraphics.getImageWidth(TileMap.imgMiniMap);
		xM = (GameCanvas.w - imageWidth) / 2;
		yM = (GameCanvas.h - 20 - mGraphics.getImageHeight(TileMap.imgMiniMap)) / 2;
		if (xM < 0)
		{
			xM = 0;
		}
		if (yM < 0)
		{
			yM = 0;
		}
		if (modeCurrentMap)
		{
			mcmxLim = imageWidth + 20 - GameCanvas.w;
			mcmyLim = mGraphics.getImageHeight(TileMap.imgMiniMap) + 40 - GameCanvas.h;
			maxPX = imageWidth + 20;
			maxPY = imageWidth + 40;
			if (maxPY < GameCanvas.h - 26)
			{
				maxPY = GameCanvas.h - 26;
			}
			if (maxPX < GameCanvas.w)
			{
				maxPX = GameCanvas.w;
			}
			mfx = xM + Char.getMyChar().cx / 12;
			mfy = yM + Char.getMyChar().cy / 12;
		}
		else
		{
			mcmxLim = 340 - GameCanvas.w;
			mcmyLim = 340 - GameCanvas.h;
			mfx = x[TileMap.mapID] + dx;
			mfy = y[TileMap.mapID] + dy;
			maxPX = 330 + dx;
			maxPY = 310 + dy;
		}
		maxPX -= 10;
		maxPY -= 10;
		if (mcmxLim < 0)
		{
			mcmxLim = 0;
		}
		if (mcmyLim < 0)
		{
			mcmyLim = 0;
		}
		mcmx = (mcmy = 0);
		mcmtoX = (mcmtoY = 0);
		mcmtoX = mfx - GameCanvas.hw;
		mcmtoY = mfy - GameCanvas.hh;
	}

	public static MapScr gI()
	{
		if (instance == null)
		{
			instance = new MapScr();
		}
		return instance;
	}

	public override void switchToMe()
	{
		base.switchToMe();
		right = new Command(mResources.CLOSE, this, 1000, null);
		center = new Command(mResources.CHANGE, this, 1001, null);
		left = new Command(string.Empty, this, 14004, null);
		if (imgMap == null)
		{
			imgMap = GameCanvas.loadImage("/wm");
			imgX = GameCanvas.loadImage("/u/x");
			imgPointer = GameCanvas.loadImage("/u/wpt1");
			mapW = mGraphics.getImageHeight(imgMap);
			mapH = mGraphics.getImageHeight(imgMap);
		}
		if (GameCanvas.w > mapW)
		{
			dx = GameCanvas.hw - mapW / 2 - 12;
		}
		if (GameCanvas.h > mapH)
		{
			dy = GameCanvas.hh - mapH / 2;
		}
		resetCMLim();
		findMapNearestPoint();
		TileMap.oldMapID = TileMap.mapID;
	}

	public override void unLoad()
	{
		base.unLoad();
	}

	public override void paint(mGraphics g)
	{
		bool flag = false;
		g.setColor(0);
		g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
		g.translate(10, 10);
		g.translate(-mcmx, -mcmy);
		if (modeCurrentMap)
		{
			g.drawImage(TileMap.imgMiniMap, xM, yM, 0);
			int num;
			int num2;
			for (int i = 0; i < GameScr.vMob.size(); i++)
			{
				Mob mob = (Mob)GameScr.vMob.elementAt(i);
				num = mob.x / 12;
				num2 = mob.y / 12;
				if (mob.level < Char.getMyChar().clevel - 2)
				{
					g.setColor(11184810);
				}
				else if (mob.level > Char.getMyChar().clevel + 2)
				{
					g.setColor(16711680);
				}
				else
				{
					g.setColor(16776960);
				}
				g.fillRect(xM + num - 1, yM + num2 - 1, 3, 3);
			}
			for (int j = 0; j < GameScr.vParty.size(); j++)
			{
				Party party = (Party)GameScr.vParty.elementAt(j);
				if (party.c != null && party.c != Char.getMyChar())
				{
					num = party.c.cx / 12;
					num2 = party.c.cy / 12;
					if (GameCanvas.gameTick % 10 < 8)
					{
						g.setColor(16777215);
						g.fillRect(xM + num - 2, yM + num2 - 2, 5, 5);
						g.setColor(65280);
						g.fillRect(xM + num - 1, yM + num2 - 1, 3, 3);
					}
				}
			}
			int taskNpcId = GameScr.gI().getTaskNpcId();
			for (int k = 0; k < GameScr.vNpc.size(); k++)
			{
				Npc npc = (Npc)GameScr.vNpc.elementAt(k);
				num = npc.cx / 12;
				num2 = npc.cy / 12;
				g.setColor(16777215);
				g.fillRect(xM + num - 2, yM + num2 - 2, 5, 5);
				g.setColor(65280);
				g.fillRect(xM + num - 1, yM + num2 - 1, 3, 3);
				g.drawImage(imgX, xM + num, yM + num2, mGraphics.VCENTER | mGraphics.HCENTER);
				flag = true;
			}
			for (sbyte b = 0; b < TileMap.vGo.size(); b = (sbyte)(b + 1))
			{
				Waypoint waypoint = (Waypoint)TileMap.vGo.elementAt(b);
				num = (waypoint.minX + waypoint.maxX) / 2 / 12;
				num2 = (waypoint.minY + waypoint.maxY) / 2 / 12;
				if (GameCanvas.gameTick % 10 < 8)
				{
					g.setColor(0);
					g.fillRect(xM + num - 2, yM + num2 - 2, 5, 5);
					g.setColor(16777215);
					g.fillRect(xM + num - 1, yM + num2 - 1, 3, 3);
				}
			}
			num = Char.getMyChar().cx / 12;
			num2 = Char.getMyChar().cy / 12;
			g.setColor(16777215);
			g.fillRect(xM + num - 2, yM + num2 - 2, 5, 5);
			if (GameCanvas.gameTick % 10 > 5)
			{
				g.setColor(255);
				g.fillRect(xM + num - 1, yM + num2 - 1, 3, 3);
			}
			g.drawImage(imgPointer, mfx - 2, mfy, 0);
			base.paint(g);
			if (!flag)
			{
				mFont.tahoma_7_white.drawString(g, TileMap.mapName, 10, GameCanvas.h - 17, 0);
			}
		}
		else
		{
			if (GameCanvas.w > mapW && GameCanvas.h > mapH)
			{
				g.drawImage(imgMap, GameCanvas.hw, GameCanvas.hh, StaticObj.VCENTER_HCENTER);
			}
			else if (GameCanvas.w > mapW)
			{
				g.drawImage(imgMap, GameCanvas.hw, 0, StaticObj.TOP_CENTER);
			}
			else if (GameCanvas.h > mapH)
			{
				g.drawImage(imgMap, 0, GameCanvas.hh, StaticObj.VCENTER_LEFT);
			}
			else
			{
				g.drawImage(imgMap, 0, 0, 0);
			}
			if (TileMap.mapID < TileMap.mapNames.Length && TileMap.mapID >= 0)
			{
				int align = 0;
				if (x[TileMap.mapID] != 1 || y[TileMap.mapID] != 1)
				{
					align = ((x[TileMap.mapID] >= 100) ? ((x[TileMap.mapID] > 200) ? 1 : 2) : 0);
					GameCanvas.paintShukiren(x[TileMap.mapID] + dx, y[TileMap.mapID] + dy, g, noRotate: false);
				}
				int num3 = 0;
				int num4 = 0;
				if (taskmapId >= 0)
				{
					align = ((x[taskmapId] >= 100) ? ((x[taskmapId] > 200) ? 1 : 2) : 0);
					mFont.tahoma_7_white.drawString(g, TileMap.mapNames[taskmapId], x[taskmapId] + dx, y[taskmapId] + dy - 20, align, mFont.tahoma_7_grey);
					g.drawImage(imgX, x[taskmapId] + dx, y[taskmapId] + dy, 3);
					flag = true;
					num3 = x[taskmapId];
					num4 = y[taskmapId] - 20;
				}
				else if (x[TileMap.mapID] != 1 || y[TileMap.mapID] != 1)
				{
					num3 = x[TileMap.mapID];
					num4 = y[TileMap.mapID] - 20;
					mFont.tahoma_7_yellow.drawString(g, TileMap.mapNames[TileMap.mapID], x[TileMap.mapID] + dx, y[TileMap.mapID] + dy - 20, align, mFont.tahoma_7_grey);
				}
				for (int l = 0; l < Char.getMyChar().taskOrders.size(); l++)
				{
					TaskOrder taskOrder = (TaskOrder)Char.getMyChar().taskOrders.elementAt(l);
					if (taskOrder.mapId >= 0 && taskOrder.mapId < x.Length)
					{
						g.drawImage(imgX, x[taskOrder.mapId] + dx, y[taskOrder.mapId] + dy, 3);
					}
				}
				if (mpoint >= 0 && ((taskmapId < 0 && TileMap.mapID != mpoint) || (taskmapId >= 0 && mpoint != taskmapId)))
				{
					align = ((x[mpoint] >= 100) ? ((x[mpoint] > 200) ? 1 : 2) : 0);
					int num5 = x[mpoint];
					int num6 = y[mpoint] - 20;
					if (num6 > num4 && num6 - num4 < 30)
					{
						num6 += 40;
					}
					if (num6 < num4 && num4 - num6 < 20)
					{
						num6 -= 5;
					}
					mFont.tahoma_7_yellow.drawString(g, TileMap.mapNames[mpoint], num5 + dx, num6 + dy, align, mFont.tahoma_7_grey);
				}
			}
			g.drawImage(imgPointer, mfx - 2, mfy, 0);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			base.paint(g);
		}
		if (flag)
		{
			g.drawImage(imgX, 10, GameCanvas.h - 12, mGraphics.VCENTER | mGraphics.HCENTER);
			mFont.tahoma_7_white.drawString(g, mResources.ME_TASK, 20, GameCanvas.h - 17, 0);
		}
	}

	public override void updateKey()
	{
		base.updateKey();
		tick3++;
		if (tick3 > 10000)
		{
			tick3 = 0;
		}
		if (mcmx != mcmtoX || mcmy != mcmtoY)
		{
			mcmvx = mcmtoX - mcmx << 1;
			mcmvy = mcmtoY - mcmy << 1;
			mcmdx += mcmvx;
			mcmx += mcmdx >> 4;
			mcmdx &= 15;
			mcmdy += mcmvy;
			mcmy += mcmdy >> 4;
			mcmdy &= 15;
			if (mcmx < 0)
			{
				mcmx = 0;
			}
			if (mcmx > mcmxLim)
			{
				mcmx = mcmxLim;
			}
			if (mcmy < 0)
			{
				mcmy = 0;
			}
			if (mcmy > mcmyLim)
			{
				mcmy = mcmyLim;
			}
		}
		bool flag = false;
		if (GameCanvas.keyHold[Key.NUM2])
		{
			mfy -= 4;
			if (mfy < dy - 10)
			{
				mfy = dy - 10;
			}
			flag = true;
		}
		if (GameCanvas.keyHold[Key.NUM8])
		{
			mfy += 4;
			if (mfy > maxPY)
			{
				mfy = maxPY;
			}
			flag = true;
		}
		if (GameCanvas.keyHold[Key.NUM4])
		{
			mfx -= 4;
			if (mfx < dx - 10)
			{
				mfx = dx - 10;
			}
			flag = true;
		}
		if (GameCanvas.keyHold[Key.NUM6])
		{
			mfx += 4;
			if (mfx > maxPX)
			{
				mfx = maxPX;
			}
			flag = true;
		}
		if (flag)
		{
			mcmtoX = mfx - GameCanvas.hw;
			mcmtoY = mfy - GameCanvas.hh;
			findMapNearestPoint();
		}
		taskmapId = GameScr.gI().getTaskMapId();
		if (GameCanvas.isPointerClick && GameCanvas.py < GameCanvas.h - mScreen.cmdH)
		{
			GameCanvas.isPointerClick = false;
			trans = true;
			lastX = GameCanvas.px;
			lastY = GameCanvas.py;
		}
		else if (GameCanvas.isPointerDown && trans)
		{
			mcmtoX -= GameCanvas.px - lastX;
			mcmtoY -= GameCanvas.py - lastY;
			if (mcmtoX < 0)
			{
				mcmtoX = 0;
			}
			if (mcmtoY < 0)
			{
				mcmtoY = 0;
			}
			if (mcmtoX > mcmxLim)
			{
				mcmtoX = mcmxLim;
			}
			if (mcmtoY > mcmyLim)
			{
				mcmtoY = mcmyLim;
			}
			mcmx = mcmtoX;
			mcmy = mcmtoY;
			lastX = GameCanvas.px;
			lastY = GameCanvas.py;
		}
		if (GameCanvas.isPointerJustRelease)
		{
			int num = GameCanvas.pxLast - GameCanvas.px;
			int num2 = GameCanvas.pyLast - GameCanvas.py;
			if (num < 10 && num2 < 10)
			{
				mfx = mcmx + GameCanvas.pxLast - 8;
				mfy = mcmy + GameCanvas.pyLast - 8;
				findMapNearestPoint();
			}
			trans = false;
			GameCanvas.isPointerJustRelease = false;
		}
		if (GameCanvas.isTouch && GameCanvas.w >= 320)
		{
			left.x = GameCanvas.w / 2 - 160;
			center.x = GameCanvas.w / 2 - 35;
			right.x = GameCanvas.w / 2 + 88;
			left.y = (center.y = (right.y = GameCanvas.h - 26));
		}
	}

	private static void findMapNearestPoint()
	{
		lastpoint = mpoint;
		mpoint = -1;
		for (int i = 0; i < x.Length; i++)
		{
			if (Res.abs(mfx - (x[i] + dx)) < 10 && Res.abs(mfy - (y[i] + dy)) < 10)
			{
				mpoint = i;
				if (lastpoint != -1 && lastpoint == mpoint)
				{
					Service.gI().adminMove(mpoint);
					lastpoint = -1;
					mpoint = -1;
				}
				break;
			}
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1000:
			if (Char.getMyChar().cHP <= 0 || Char.getMyChar().statusMe == 14)
			{
				center = GameScr.gI().cmdDead;
				Char.getMyChar().cHP = 0;
			}
			GameScr.gI().switchToMe();
			break;
		case 1001:
			modeCurrentMap = !modeCurrentMap;
			resetCMLim();
			break;
		case 14004:
			Service.gI().adminMove(mpoint);
			break;
		}
	}
}
