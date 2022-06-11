public class Layer
{
	public ActionUpdate acUpdate;

	public ActionPaint acPaint;

	public void update()
	{
		if (acUpdate != null)
		{
			acUpdate();
		}
	}

	public void paint(mGraphics g, int x, int y)
	{
		if (acPaint != null)
		{
			acPaint(g, x, y);
		}
	}

	public void keyPress(int keyCode)
	{
	}
}
