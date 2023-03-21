using Cpp2ILInjected.CallAnalysis;

public class Feat_ColdFusionSaveData
{
	public float m_ElapsedDays;

	public float m_HoursAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Feat_ColdFusionSaveData()
	{
	}
}
