public class InfoItem
{
	public string s;

	public mFont f;

	public int speed;

	public InfoItem(string s)
	{
		f = mFont.tahoma_7_white;
		this.s = s;
		speed = 20;
	}

	public InfoItem(string s, mFont f, int speed)
	{
		this.f = f;
		this.s = s;
		this.speed = speed;
	}
}
