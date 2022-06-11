public class PartFrame
{
	public short idSmallImg;

	public short dx;

	public short dy;

	public sbyte flip;

	public sbyte onTop;

	public PartFrame(int dx, int dy, int idSmall)
	{
		idSmallImg = (short)idSmall;
		this.dx = (short)dx;
		this.dy = (short)dy;
	}
}
