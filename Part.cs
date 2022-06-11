public class Part
{
	public int type;

	public PartImage[] pi;

	public Part(int type)
	{
		this.type = type;
		if (type == 0)
		{
			pi = new PartImage[8];
		}
		if (type == 1)
		{
			pi = new PartImage[18];
		}
		if (type == 2)
		{
			pi = new PartImage[10];
		}
		if (type == 3)
		{
			pi = new PartImage[2];
		}
	}
}
