using Cpp2ILInjected.CallAnalysis;

public class Skill_RevolverSaveData
{
	public int m_Points;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Skill_RevolverSaveData()
	{
	}
}
