using Cpp2ILInjected.CallAnalysis;

public class Skill_IceFishingSaveData
{
	public int m_Points;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Skill_IceFishingSaveData()
	{
	}
}
