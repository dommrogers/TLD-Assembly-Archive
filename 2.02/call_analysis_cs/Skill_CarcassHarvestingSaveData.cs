using Cpp2ILInjected.CallAnalysis;

public class Skill_CarcassHarvestingSaveData
{
	public int m_Points;

	public float m_NumHoursToConvertToSkillPoints;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Skill_CarcassHarvestingSaveData()
	{
	}
}
