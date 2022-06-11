public class MotherCanvas
{
	public static MotherCanvas instance;

	public GameCanvas tCanvas;

	public int zoomLevel = 1;

	public Image imgCache;

	public static int w;

	public static int h;

	private int newWidth;

	private int newHeight;

	private int OUTPUTSIZE = 20;

	public static int addR;

	public static int addL;

	public MotherCanvas()
	{
		mSystem.setScale();
		w = getWidth();
		h = getHeight();
		if (Main.isPC)
		{
			if (w * h < 480000)
			{
				mGraphics.zoomLevel = (zoomLevel = 1);
				newWidth = w / zoomLevel + 2;
				newHeight = h / zoomLevel + 2;
			}
			else
			{
				mGraphics.zoomLevel = (zoomLevel = 2);
				newWidth = w / zoomLevel + 2;
				newHeight = h / zoomLevel + 2;
			}
			Main.main.doClearRMS();
		}
		else if (w * h >= 1228800)
		{
			mGraphics.zoomLevel = (zoomLevel = 4);
			newWidth = w / zoomLevel + 2;
			newHeight = h / zoomLevel + 2;
		}
		else if (w * h >= 691200)
		{
			mGraphics.zoomLevel = (zoomLevel = 3);
			newWidth = w / zoomLevel + 2;
			newHeight = h / zoomLevel + 2;
		}
		else if (w * h >= 240000)
		{
			mGraphics.zoomLevel = (zoomLevel = 2);
			newWidth = w / zoomLevel + 2;
			newHeight = h / zoomLevel + 2;
		}
		else
		{
			mGraphics.zoomLevel = (zoomLevel = 1);
		}
		if (mGraphics.zoomLevel == 3)
		{
			addR = 1;
			addL = 1;
		}
		else if (mGraphics.zoomLevel == 2)
		{
			addR = 0;
			addL = 1;
		}
	}

	public int getWidth()
	{
		return (int)ScaleGUI.WIDTH;
	}

	public int getHeight()
	{
		return (int)ScaleGUI.HEIGHT;
	}

	public void setChildCanvas(GameCanvas tCanvas)
	{
		this.tCanvas = tCanvas;
	}

	protected void paint(mGraphics g)
	{
		tCanvas.paint(g);
	}

	protected void keyPressed(int keyCode)
	{
		tCanvas.keyPressed(keyCode);
	}

	protected void keyReleased(int keyCode)
	{
		tCanvas.keyReleased(keyCode);
	}

	protected void pointerDragged(int x, int y)
	{
		x /= zoomLevel;
		y /= zoomLevel;
		tCanvas.pointerDragged(x, y);
	}

	protected void pointerPressed(int x, int y)
	{
		x /= zoomLevel;
		y /= zoomLevel;
		tCanvas.pointerPressed(x, y);
	}

	protected void pointerReleased(int x, int y)
	{
		x /= zoomLevel;
		y /= zoomLevel;
		tCanvas.pointerReleased(x, y);
	}

	public int getHeight_new()
	{
		if (zoomLevel == 1)
		{
			return getHeight();
		}
		return newHeight;
	}

	public int getWidth_new()
	{
		if (zoomLevel == 1)
		{
			return getWidth();
		}
		return newWidth;
	}
}
