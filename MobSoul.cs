public class MobSoul
{
	public int x;

	public int y;

	public int xdest;

	public int ydest;

	public int status;

	public int timeFollow;

	public int type;

	public Char c;

	private int[] x0;

	private int[] y0;

	private int[] dir;

	public MobSoul(int x, int y, Char c)
	{
		this.x = x;
		this.y = y;
		xdest = x;
		ydest = y - (Res.rnd(40) + 20);
		status = 1;
		type = 1;
		this.c = c;
	}

	public MobSoul(int cx, int cy)
	{
		status = 1;
		type = 2;
		xdest = cx;
		ydest = cy;
		x0 = new int[5];
		y0 = new int[5];
		dir = new int[5];
		timeFollow = 300;
		for (int i = 0; i < x0.Length; i++)
		{
			x0[i] = Res.random(cx - 20, cx + 20);
			y0[i] = cy - 10;
			dir[i] = ((i % 2 == 0) ? 1 : (-1));
		}
	}

	public void update()
	{
		if (type == 1)
		{
			if (c == null)
			{
				GameScr.vMobSoul.removeElement(this);
				return;
			}
			if (status == 1)
			{
				if (y > ydest)
				{
					y -= 2;
					x += 1 - GameCanvas.gameTick % 3;
				}
				else
				{
					status = 2;
				}
				timeFollow = 100;
				return;
			}
			timeFollow--;
			if (Res.abs(c.cx - x) < 50 || Res.abs(c.cy - y) < 50)
			{
				x += (c.cx - x) / 4;
				y += (c.cy - y) / 4;
			}
			else
			{
				x += (c.cx - x) / 10;
				y += (c.cy - y) / 10;
			}
			if (timeFollow < 0)
			{
				x = c.cx;
				y = c.cy - c.ch / 2;
				if (timeFollow < -5)
				{
					GameScr.vMobSoul.removeElement(this);
				}
			}
			else if (Res.abs(c.cx - x) < 10 && Res.abs(c.cy - y) < 10)
			{
				GameScr.vMobSoul.removeElement(this);
			}
		}
		else
		{
			if (type != 2)
			{
				return;
			}
			for (int i = 0; i < x0.Length; i++)
			{
				y0[i] -= GameCanvas.gameTick % 5;
				if (dir[i] == -1)
				{
					x0[i]--;
				}
				else
				{
					x0[i]++;
				}
				if (x0[i] <= xdest - 20 || x0[i] >= xdest + 20)
				{
					dir[i] = -dir[i];
				}
				if (y0[i] < 0)
				{
					GameScr.vMobSoul.removeElement(this);
				}
			}
		}
	}

	public void paint(mGraphics g)
	{
		if (type == 1)
		{
			if (GameCanvas.gameTick % 5 > 2)
			{
				SmallImage.drawSmallImage(g, 1433, x, y, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else
			{
				SmallImage.drawSmallImage(g, 1434, x, y, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			return;
		}
		for (int i = 0; i < x0.Length; i++)
		{
			if (GameCanvas.gameTick % 5 > 2)
			{
				SmallImage.drawSmallImage(g, 1433, x0[i], y0[i], 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else
			{
				SmallImage.drawSmallImage(g, 1434, x0[i], y0[i], 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
		}
	}
}
