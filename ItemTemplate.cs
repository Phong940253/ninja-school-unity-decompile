public class ItemTemplate
{
	public short id;

	public sbyte type;

	public sbyte gender;

	public string name;

	public string description;

	public sbyte level;

	public short iconID;

	public short part;

	public bool isUpToUp;

	public int w;

	public int h;

	public ItemTemplate(short templateID, sbyte type, sbyte gender, string name, string description, sbyte level, short iconID, short part, bool isUpToUp)
	{
		id = templateID;
		this.type = type;
		this.gender = gender;
		this.name = name;
		this.description = description;
		this.level = level;
		this.iconID = iconID;
		this.part = part;
		this.isUpToUp = isUpToUp;
	}
}
