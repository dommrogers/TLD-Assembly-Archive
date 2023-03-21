using Cpp2ILInjected.CallAnalysis;

public class Skill_ToolRepairSaveData
{
	public int m_Points;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Skill_ToolRepairSaveData()
	{
	}
}
