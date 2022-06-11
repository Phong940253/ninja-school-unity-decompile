public class EffectData
{
	public sbyte[] data;

	public long timeremove;

	public MyVector listFrame = new MyVector();

	public MyVector listAnima = new MyVector();

	public SmallImage[] smallImage;

	public sbyte[][] frameChar = new sbyte[4][];

	public sbyte[] sequence;

	public int fw;

	public int fh;

	public sbyte[] indexStartSkill;

	public bool isLoad;

	public EffectData()
	{
	}

	public EffectData(short id)
	{
	}

	public void setdata(sbyte[] data)
	{
		if (data != null)
		{
			this.data = data;
		}
	}
}
