public class ImageIcon
{
	public Image img;

	public short id;

	public int timeRemove;

	public bool isLoad;

	public long timeGetBack;

	public void reset()
	{
		img = null;
	}

	public int getHeight()
	{
		if (img != null)
		{
			return img.getHeight();
		}
		return 0;
	}

	public int getWidth()
	{
		if (img != null)
		{
			return img.getWidth();
		}
		return 0;
	}
}
