using Cpp2ILInjected.CallAnalysis;

public class Skill_CookingSaveData
{
	public int m_Points;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Skill_CookingSaveData()
	{
	}
}
