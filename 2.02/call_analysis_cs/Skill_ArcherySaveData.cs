using Cpp2ILInjected.CallAnalysis;

public class Skill_ArcherySaveData
{
	public int m_Points;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Skill_ArcherySaveData()
	{
	}
}
