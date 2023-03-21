using Cpp2ILInjected.CallAnalysis;

public class Feat_ColdFusionSaveData
{
	public float m_ElapsedDays;

	public float m_HoursAccumulator;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public Feat_ColdFusionSaveData()
	{
	}
}
