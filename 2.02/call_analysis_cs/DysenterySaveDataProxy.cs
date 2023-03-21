using Cpp2ILInjected.CallAnalysis;

public class DysenterySaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public bool m_AntibioticsTaken;

	public float m_ElapsedRest;

	public float m_CleanWaterConsumedLiters;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DysenterySaveDataProxy()
	{
	}
}
