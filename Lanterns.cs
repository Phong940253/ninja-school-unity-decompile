public class Lanterns
{
	public int x;

	public int y;

	public int dy = 3;

	public int yStart;

	public bool isEnd;

	public Lanterns(int x, int y)
	{
		this.x = x;
		this.y = (yStart = y);
		isEnd = false;
	}

	public void update()
	{
		y -= dy;
		if (yStart - y > 150)
		{
			isEnd = true;
		}
	}

	public void paint(mGraphics g)
	{
		if (GameCanvas.gameTick % 10 < 8)
		{
			SmallImage.drawSmallImage(g, 1292, x, y, 0, mGraphics.VCENTER | mGraphics.HCENTER);
		}
		else
		{
			SmallImage.drawSmallImage(g, 1291, x, y, 0, mGraphics.VCENTER | mGraphics.HCENTER);
		}
	}
}
