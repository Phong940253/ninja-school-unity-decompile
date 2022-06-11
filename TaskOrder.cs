public class TaskOrder
{
	public const sbyte TASK_DAY = 0;

	public const sbyte TASK_BOSS = 1;

	public const sbyte TASK_GIOITHIEU = 2;

	public const sbyte TASK_SUKIEN1 = 3;

	public const sbyte TASK_SUKIEN2 = 4;

	public const sbyte TASK_SUKIEN3 = 5;

	public const sbyte TASK_SUKIEN4 = 6;

	public int taskId;

	public int count;

	public int maxCount;

	public string name;

	public string description;

	public int killId;

	public int mapId;

	public TaskOrder(sbyte taskId, int count, int maxCount, string name, string description, int killId, int mapId)
	{
		this.count = count;
		this.maxCount = maxCount;
		this.taskId = taskId;
		this.name = name;
		this.description = description;
		this.killId = killId;
		this.mapId = mapId;
	}
}
