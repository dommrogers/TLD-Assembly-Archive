using Cpp2ILInjected.CallAnalysis;

public class Skill_ArcherySaveData
{
	public int m_Points;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Skill_ArcherySaveData()
	{
	}
}
