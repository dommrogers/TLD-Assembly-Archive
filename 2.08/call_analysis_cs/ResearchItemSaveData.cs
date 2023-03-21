using Cpp2ILInjected.CallAnalysis;

public class ResearchItemSaveData
{
	public float m_ElapsedHours;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ResearchItemSaveData()
	{
	}
}
