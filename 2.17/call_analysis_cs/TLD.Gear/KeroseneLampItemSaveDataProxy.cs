using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gear;

public class KeroseneLampItemSaveDataProxy
{
	public float m_HoursPlayed;

	public float m_CurrentFuelLitersProxy;

	public bool m_OnProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public KeroseneLampItemSaveDataProxy()
	{
	}
}
