public class Skill
{
	public const sbyte ATT_STAND = 0;

	public const sbyte ATT_FLY = 1;

	public const sbyte SKILL_AUTO_USE = 0;

	public const sbyte SKILL_CLICK_USE_ATTACK = 1;

	public const sbyte SKILL_CLICK_USE_BUFF = 2;

	public const sbyte SKILL_CLICK_NPC = 3;

	public const sbyte SKILL_CLICK_LIVE = 4;

	public SkillTemplate template;

	public short skillId;

	public int point;

	public int level;

	public int coolDown;

	public long lastTimeUseThisSkill;

	public int dx;

	public int dy;

	public int maxFight;

	public int manaUse;

	public SkillOption[] options;

	public bool paintCanNotUseSkill;

	public static Skill me;

	public static Skill gI()
	{
		return (me != null) ? me : (me = new Skill());
	}

	public string strTimeReplay()
	{
		if (coolDown % 1000 == 0)
		{
			return coolDown / 1000 + string.Empty;
		}
		int num = coolDown % 1000;
		return coolDown / 1000 + "." + ((num % 100 != 0) ? (num / 10) : (num / 100));
	}

	public void paint(int x, int y, mGraphics g)
	{
		SmallImage.drawSmallImage(g, template.iconId, x, y, 0, StaticObj.VCENTER_HCENTER);
		long currentTimeMillis = mSystem.getCurrentTimeMillis();
		long num = currentTimeMillis - lastTimeUseThisSkill;
		if (num < coolDown)
		{
			g.setColor(0, 0.5f);
			if (paintCanNotUseSkill)
			{
				g.setColor(0, 0.5f);
			}
			int num2 = (int)(num * 18 / coolDown);
			g.fillRect(x - 9, y - 9 + num2, 18, 18 - num2);
		}
		else
		{
			paintCanNotUseSkill = false;
		}
	}

	public bool isCooldown()
	{
		long currentTimeMillis = mSystem.getCurrentTimeMillis();
		long num = currentTimeMillis - lastTimeUseThisSkill;
		if (num < coolDown)
		{
			return true;
		}
		return false;
	}
}
