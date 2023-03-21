using Cpp2ILInjected.CallAnalysis;

public class ResearchItemSaveData
{
	public float m_ElapsedHours;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ResearchItemSaveData()
	{
	}
}
