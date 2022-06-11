public class Skills
{
	public static mHashtable skills = new mHashtable();

	public static void add(Skill skill)
	{
		skills.put(skill.skillId, skill);
	}

	public static Skill get(short skillId)
	{
		return (Skill)skills.get(skillId);
	}
}
