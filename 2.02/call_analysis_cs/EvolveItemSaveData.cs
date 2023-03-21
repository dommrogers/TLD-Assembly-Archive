using Cpp2ILInjected.CallAnalysis;

public class EvolveItemSaveData
{
	public float m_HoursPlayed;

	public float m_TimeSpentEvolvingGameHours;

	public bool m_ForceNoAutoEvolve;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public EvolveItemSaveData()
	{
	}
}
