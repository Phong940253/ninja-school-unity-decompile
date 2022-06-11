public class EffAtutoTemp
{
	public short idEffAuto;

	public ImageInfo[] imginfo;

	public Frame[] frameEffAuto;

	public short[] frameRunning;

	public long timerequest;

	public long timeUse = mSystem.currentTimeMillis();

	public ImageInfo getImgInfo(sbyte frame)
	{
		return imginfo[frame];
	}
}
