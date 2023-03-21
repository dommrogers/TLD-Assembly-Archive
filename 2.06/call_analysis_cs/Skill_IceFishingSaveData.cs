using Cpp2ILInjected.CallAnalysis;

public class Skill_IceFishingSaveData
{
	public int m_Points;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Skill_IceFishingSaveData()
	{
	}
}
