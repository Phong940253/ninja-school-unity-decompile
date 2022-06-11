public class ServerEffect : Effect2
{
	public EffectCharPaint eff;

	private int i0;

	private int x;

	private int y;

	private int dir = 1;

	private Char c;

	private short loopCount;

	private long endTime;

	public static void addServerEffect(int id, int cx, int cy, int loopCount)
	{
		ServerEffect serverEffect = new ServerEffect();
		serverEffect.eff = GameScr.efs[id];
		serverEffect.x = cx;
		serverEffect.y = cy;
		serverEffect.loopCount = (short)loopCount;
		Effect2.vEffect2.addElement(serverEffect);
	}

	public static void addServerEffect(int id, int cx, int cy, int loopCount, sbyte dir)
	{
		ServerEffect serverEffect = new ServerEffect();
		serverEffect.eff = GameScr.efs[id];
		serverEffect.x = cx;
		serverEffect.y = cy;
		serverEffect.loopCount = (short)loopCount;
		serverEffect.dir = dir;
		Effect2.vEffect2.addElement(serverEffect);
	}

	public static void addServerEffect(int id, Char c, int loopCount)
	{
		ServerEffect serverEffect = new ServerEffect();
		serverEffect.eff = GameScr.efs[id];
		serverEffect.c = c;
		serverEffect.loopCount = (short)loopCount;
		Effect2.vEffect2.addElement(serverEffect);
	}

	public static void addServerEffectWithTime(int id, int cx, int cy, long timeLengthInSecond)
	{
		ServerEffect serverEffect = new ServerEffect();
		serverEffect.eff = GameScr.efs[id];
		serverEffect.x = cx;
		serverEffect.y = cy;
		serverEffect.endTime = mSystem.getCurrentTimeMillis() + timeLengthInSecond * 1000;
		Effect2.vEffect2.addElement(serverEffect);
	}

	public static void addServerEffectWithTime(int id, Char c, long timeLengthInSecond)
	{
		ServerEffect serverEffect = new ServerEffect();
		serverEffect.eff = GameScr.efs[id];
		serverEffect.c = c;
		serverEffect.endTime = mSystem.getCurrentTimeMillis() + timeLengthInSecond * 1000;
		Effect2.vEffect2.addElement(serverEffect);
	}

	public override void paint(mGraphics g)
	{
		if (c != null)
		{
			x = c.cx;
			y = c.cy;
		}
		int num = x + eff.arrEfInfo[i0].dx * dir;
		int num2 = y + eff.arrEfInfo[i0].dy;
		if (GameCanvas.isPaint(num, num2))
		{
			SmallImage.drawSmallImage(g, eff.arrEfInfo[i0].idImg, num, num2, (dir != 1) ? 2 : 0, mGraphics.VCENTER | mGraphics.HCENTER);
		}
	}

	public override void update()
	{
		if (endTime != 0)
		{
			i0++;
			if (i0 >= eff.arrEfInfo.Length)
			{
				i0 = 0;
			}
			if (mSystem.getCurrentTimeMillis() - endTime > 0)
			{
				if (eff.idEf == 120)
				{
					GameCanvas.isBallEffect = false;
				}
				Effect2.vEffect2.removeElement(this);
			}
		}
		else
		{
			i0++;
			if (i0 >= eff.arrEfInfo.Length)
			{
				loopCount--;
				if (loopCount <= 0)
				{
					if (eff.idEf == 120)
					{
						GameCanvas.isBallEffect = false;
					}
					Effect2.vEffect2.removeElement(this);
				}
				else
				{
					i0 = 0;
				}
			}
		}
		if (GameCanvas.gameTick % 11 == 0 && c != null && c != Char.getMyChar() && !GameScr.vCharInMap.contains(c))
		{
			Effect2.vEffect2.removeElement(this);
		}
	}
}
