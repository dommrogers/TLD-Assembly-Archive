using Cpp2ILInjected.CallAnalysis;

public class KeroseneLampItemSaveDataProxy
{
	public float m_HoursPlayed;

	public float m_CurrentFuelLitersProxy;

	public bool m_OnProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public KeroseneLampItemSaveDataProxy()
	{
	}
}
