public class FrameImage
{
	public int frameWidth;

	public int frameHeight;

	public int nFrame;

	public Image imgFrame;

	private int[] pos;

	private int totalHeight;

	private Image[] imgList;

	private bool isRotate;

	public FrameImage(Image img, int width, int height)
	{
		imgFrame = img;
		frameWidth = width;
		frameHeight = height;
		totalHeight = Image.getImageHeight(img);
		nFrame = totalHeight / height;
		pos = new int[nFrame];
		for (int i = 0; i < nFrame; i++)
		{
			pos[i] = i * height;
		}
	}

	public FrameImage(Image img, int n)
	{
		imgFrame = img;
		frameWidth = img.getWidth();
		frameHeight = img.getHeight();
		nFrame = n;
		imgList = new Image[nFrame];
		isRotate = true;
		int num = 360 / n;
		for (int i = 1; i < nFrame; i++)
		{
			int num2 = i * num;
			int num3 = num2;
		}
	}

	public void drawRegionFrame(int idx, int x, int y, int trans, int anchor, mGraphics g, int bulletID, int n)
	{
		g.drawRegion(imgFrame, 0, (bulletID * n + idx) * imgFrame.getWidth(), imgFrame.getWidth(), imgFrame.getWidth(), trans, x, y, anchor);
	}

	public void drawFrame(int idx, int x, int y, int trans, int anchor, mGraphics g)
	{
		if (!isRotate)
		{
			if (idx >= 0 && idx < nFrame)
			{
				g.drawRegion(imgFrame, 0, pos[idx], frameWidth, frameHeight, trans, x, y, anchor);
			}
		}
		else if (idx >= 0 && idx < nFrame)
		{
			switch (idx * (360 / nFrame))
			{
			case 0:
				g.drawImage(imgFrame, x, y, 3);
				break;
			case 90:
				g.drawRegion(imgFrame, 0, 0, frameWidth, frameHeight, 5, x, y, anchor);
				break;
			case 270:
				g.drawRegion(imgFrame, 0, 0, frameWidth, frameHeight, 6, x, y, anchor);
				break;
			case 180:
				g.drawRegion(imgFrame, 0, 0, frameWidth, frameHeight, 3, x, y, anchor);
				break;
			default:
				g.drawRegion(imgList[idx], 0, 0, frameWidth, frameHeight, trans, x, y, anchor);
				break;
			}
		}
	}

	public void unload()
	{
		imgFrame = null;
		pos = null;
	}
}
