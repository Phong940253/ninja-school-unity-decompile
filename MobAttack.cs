public class MobAttack
{
	public int x;

	public int y;

	public int vx;

	public int vy;

	public int indexM;

	public int dam;

	public int dirInjure;

	public int indexChar;

	public int cx;

	public int cy;

	public int type;

	public int xTo;

	public int yTo;

	public int d;

	public int statusM;

	public static int[] w = new int[3] { 10, 5, 11 };

	public static int[] h = new int[3] { 10, 5, 11 };

	public static int[] maxIndex = new int[3] { 4, 1, 4 };

	public MobAttack(int type, int x, int y, int xTo, int yTo, int indexChar, int state)
	{
		this.x = x;
		this.y = y;
		this.type = type;
		this.xTo = xTo;
		this.yTo = yTo;
		statusM = state;
		dirInjure = ((this.xTo > this.x) ? 1 : (-1));
		this.indexChar = indexChar;
		d = 10;
		indexM = -1;
		if (state == 0)
		{
			vx = Res.xetVX(Res.angle(xTo - x, yTo - y), d);
			vy = Res.xetVY(Res.angle(xTo - x, yTo - y), d);
		}
		else
		{
			vy = -12;
			if (state == 2)
			{
				vx = 0;
				vy = -14;
			}
			if (state == 1)
			{
				vx = -5;
			}
			if (state == 3)
			{
				vx = 5;
			}
		}
		if (state == 2)
		{
			GameScr.vMobAttack.addElement(new MobAttack(type, x, y, xTo, yTo, indexChar, 1));
			GameScr.vMobAttack.addElement(new MobAttack(type, x, y, xTo, yTo, indexChar, 3));
		}
	}

	public void update()
	{
		if (statusM > 0 && statusM < 4)
		{
			x += vx;
			y += vy;
			vy += 2;
			if (vx < -2)
			{
				vx++;
			}
			if (vx > 2)
			{
				vx--;
			}
			if (vy == 6)
			{
				if (statusM == 2)
				{
					statusM = 0;
				}
				else
				{
					statusM = 4;
				}
				d = 11;
				vx = Res.xetVX(Res.angle(xTo - x, yTo - y), d);
				vy = Res.xetVY(Res.angle(xTo - x, yTo - y), d);
			}
		}
		else
		{
			Char @char = null;
			@char = ((indexChar != 100) ? ((Char)GameScr.vCharInMap.elementAt(indexChar)) : Char.getMyChar());
			xTo = @char.cx;
			yTo = @char.cy - @char.chh;
			x += vx;
			y += vy;
			d++;
			vx = Res.xetVX(Res.angle(xTo - x, yTo - y), d);
			vy = Res.xetVY(Res.angle(xTo - x, yTo - y), d);
			indexM++;
			if (indexM == maxIndex[type])
			{
				indexM = 0;
			}
			if (x < xTo + @char.chw && x > xTo - @char.chw && y < yTo + @char.chh && y > yTo - @char.chh)
			{
				GameScr.vMobAttack.removeElement(this);
			}
		}
	}

	public void paint(mGraphics g)
	{
	}

	public static int getType(int mobID)
	{
		return 0;
	}
}
