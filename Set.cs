public class Set
{
	public int sum;

	public int time;

	public int dir;

	public int indexMob;

	public int indexChar;

	public int xMob;

	public int yMob;

	public int xChar;

	public int yChar;

	public int[] x1;

	public int[] y1;

	public int[] x2;

	public int[] y2;

	public bool[] isTua1;

	public bool[] isTua2;

	public int bientam = 10;

	public Set(int x, int y, int xTo, int yTo, int time, int indexMob, int indexChar)
	{
		this.time = time;
		this.indexMob = indexMob;
		this.indexChar = indexChar;
		dir = ((xTo - x > 0) ? 1 : (-1));
		sum = Res.random(5, 10);
		x1 = new int[sum + 1];
		y1 = new int[sum + 1];
		x2 = new int[sum + 1];
		y2 = new int[sum + 1];
		isTua1 = new bool[sum + 1];
		isTua2 = new bool[sum + 1];
		setFirstLast(x, y, xTo, yTo, sum);
		for (sbyte b = 1; b < sum; b = (sbyte)(b + 1))
		{
			x1[b] = x1[b - 1] + Res.random(5, 11) * dir;
			y1[b] = y1[b - 1] + Res.random(-10, 11);
			x2[b] = x1[b] + Res.random(2, 5) * dir;
			y2[b] = y1[b] + Res.random(-4, 5);
		}
	}

	public void update()
	{
		time++;
		if (time == 5)
		{
			time = 0;
			GameScr.vSet.removeElement(this);
		}
		Mob mob = Mob.get_Mob(indexMob);
		xMob = mob.x;
		yMob = mob.y - mob.h / 2;
		if (indexChar == 100)
		{
			xChar = Char.getMyChar().cx;
			yChar = Char.getMyChar().cy - Char.getMyChar().chh;
		}
		else
		{
			xChar = ((Char)GameScr.vCharInMap.elementAt(indexChar)).cx;
			yChar = ((Char)GameScr.vCharInMap.elementAt(indexChar)).cy - Char.getMyChar().chh;
		}
		if (Res.abs(x1[0] - xMob) > 5 || Res.abs(y1[0] - yMob) > 5)
		{
			x1[0] = xMob;
			y1[0] = yMob;
		}
		if (Res.abs(x1[sum] - xChar) > 5 || Res.abs(y1[sum] - yChar) > 5)
		{
			x1[sum] = xChar;
			y1[sum] = yChar;
		}
	}

	public void paint(mGraphics g)
	{
		for (int i = 0; i < sum; i++)
		{
			if (time % 2 == 0)
			{
				g.setColor(41471);
				g.drawLine(x1[i], y1[i], x1[i + 1], y1[i + 1]);
				g.setColor(16155894);
				g.drawLine(x2[i], y2[i], x2[i + 1], y2[i + 1]);
			}
			g.setColor(16117229);
			g.drawLine(x1[i], y1[i], x1[i] + Res.random(-5, 6), y1[i] + Res.random(-5, 6));
			g.drawLine(x2[i], y2[i], x2[i] + Res.random(-5, 6), y2[i] + Res.random(-5, 6));
		}
	}

	public void setFirstLast(int x, int y, int xTo, int yTo, int indexLast)
	{
		x1[0] = x;
		y1[0] = y;
		x1[indexLast] = xTo;
		y1[indexLast] = yTo;
		x2[0] = x;
		y2[0] = y;
		x2[indexLast] = xTo;
		y2[indexLast] = yTo;
	}
}
