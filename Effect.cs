public class Effect
{
	public static EffectTemplate[] effTemplates;

	public const sbyte EFF_ME = 0;

	public const sbyte EFF_FRIEND = 1;

	public int timeStart;

	public int timeLenght;

	public short param;

	public EffectTemplate template;

	public Effect(sbyte templateId, int timeStart, int timeLenght, short param)
	{
		template = effTemplates[templateId];
		this.timeStart = timeStart;
		this.timeLenght = timeLenght / 1000;
		this.param = param;
	}
}
