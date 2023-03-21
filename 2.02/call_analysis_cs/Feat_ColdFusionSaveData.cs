using Cpp2ILInjected.CallAnalysis;

public class Feat_ColdFusionSaveData
{
	public float m_ElapsedDays;

	public float m_HoursAccumulator;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Feat_ColdFusionSaveData()
	{
	}
}
