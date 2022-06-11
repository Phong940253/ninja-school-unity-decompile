public class Clan_ThanThu
{
	public string name = string.Empty;

	public sbyte stars;

	public short idIconItem;

	public short idThanThu;

	public int time_aptrung = -1;

	public string str_trungno = string.Empty;

	public MyVector vecInfo = new MyVector();

	public int curExp = -1;

	public int maxExp = -1;

	public long timeStartThanThu;

	public Clan_ThanThu(string name, sbyte stars, short idIconItem, short idThanThu, int time_aptrung, string str_trungno, MyVector vecInfo, int curExp, int maxExp)
	{
		this.name = name;
		this.idIconItem = idIconItem;
		this.idThanThu = idThanThu;
		this.time_aptrung = time_aptrung;
		this.str_trungno = str_trungno;
		this.vecInfo = vecInfo;
		this.curExp = curExp;
		this.maxExp = maxExp;
		timeStartThanThu = mSystem.currentTimeMillis();
		this.stars = stars;
	}
}
