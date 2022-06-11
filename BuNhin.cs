public class BuNhin
{
	public short x;

	public short y;

	public string name;

	public bool isInjure;

	public BuNhin(string name, short x, short y)
	{
		this.x = x;
		this.y = y;
		this.name = name;
	}

	public void doInjure()
	{
		isInjure = true;
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
		return true;
	}

	public void paint(mGraphics g)
	{
		if (isPaint())
		{
			mFont.tahoma_7_yellow.drawString(g, name, x, y - 32, 2, mFont.tahoma_7_grey);
			SmallImage.drawSmallImage(g, 1180, x, y, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
			if (isInjure)
			{
				SmallImage.drawSmallImage(g, 288, x, y, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				isInjure = false;
			}
		}
	}
}
