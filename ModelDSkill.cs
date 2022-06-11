public class ModelDSkill
{
	public int dSkillID;

	public int point;

	public int level;

	public int timeReplay;

	public int spaceFight;

	public int maxFight;

	public int manaUse;

	public int buffHp;

	public int buffHpFriend;

	public int buffPercentHp;

	public int buffPercentHpFriend;

	public int buffAutoHpHalf;

	public int buffAutoHpHalfFriend;

	public int buffMp;

	public int buffMpFriend;

	public int buffPercentMp;

	public int buffPercentMpFriend;

	public int buffMiss;

	public int buffMissFriend;

	public int buffExactly;

	public int buffExactlyFriend;

	public int buffDame;

	public int buffDameFriend;

	public int buffPercentDame;

	public int buffPercentDameFriend;

	public int buffFatal;

	public int buffFatalFriend;

	public int buffPercentFatal;

	public int buffPercentFatalFriend;

	public int buffReactDame;

	public int buffReactDameFriend;

	public int buffSpeed;

	public int buffResistAll;

	public int buffResistAllFriend;

	public ModelDSkill(int dSkillID, int point, int level, int timeReplay, int spaceFight, int maxFight, int manaUse)
	{
		this.dSkillID = dSkillID;
		this.point = point;
		this.level = level;
		this.timeReplay = timeReplay;
		this.spaceFight = spaceFight;
		this.maxFight = maxFight;
		this.manaUse = manaUse;
	}
}
