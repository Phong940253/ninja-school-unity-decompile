public class EggMonters
{
	public int x;

	public int y;

	public int frame;

	public sbyte status;

	public const sbyte EGG_NOTACTIVE = 2;

	public const sbyte EGG_FLY = 0;

	public const sbyte EGG_BREAK = 1;

	public int vy;

	public static Mob ownerEgg;

	public EggMonters(int x, int y)
	{
		status = 0;
		this.x = x;
		this.y = y;
		for (int i = 0; i < GameScr.vMob.size(); i++)
		{
			Mob mob = (Mob)GameScr.vMob.elementAt(i);
			if (mob.templateId == 202)
			{
				ownerEgg = mob;
			}
		}
	}

	public bool isPaint()
	{
		if (x < GameScr.cmx)
		{
			return false;
		}
		if (x > GameScr.cmx + GameScr.gW)
		{
			return false;
		}
		if (y < GameScr.cmy)
		{
			return false;
		}
		if (y > GameScr.cmy + GameScr.gH + 30)
		{
			return false;
		}
		if (ownerEgg != null && ownerEgg.status == 8)
		{
			return false;
		}
		return true;
	}

	public void update()
	{
		if (!isPaint())
		{
			return;
		}
		if (status == 0)
		{
			vy++;
			y += vy;
			frame++;
			if (frame > 3)
			{
				frame = 0;
			}
			if ((TileMap.tileTypeAtPixel(x, y) & TileMap.T_TOP) == TileMap.T_TOP)
			{
				status = 1;
				vy = 0;
			}
		}
		else if (status == 1)
		{
			frame++;
			if (frame > 6)
			{
				frame = 6;
				ownerEgg.status = 5;
			}
		}
	}

	public void paint(mGraphics g)
	{
		if (isPaint())
		{
			g.drawRegion(GameScr.imgEggMonters, 0, frame * 32, 32, 32, 0, x, y, mGraphics.HCENTER | mGraphics.BOTTOM);
		}
	}
}
