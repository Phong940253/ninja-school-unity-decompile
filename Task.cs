public class Task
{
	public int index;

	public int max;

	public short[] counts;

	public short taskId;

	public string[] names;

	public string[] details;

	public string[] subNames;

	public short count;

	public Task(short taskId, sbyte index, string name, string detail, string[] subNames, short[] counts, short count)
	{
		this.taskId = taskId;
		this.index = index;
		names = mFont.tahoma_7b_white.splitFontArray(name, 155);
		details = mFont.tahoma_7.splitFontArray(detail, 155);
		this.subNames = subNames;
		this.counts = counts;
		this.count = count;
	}
}
