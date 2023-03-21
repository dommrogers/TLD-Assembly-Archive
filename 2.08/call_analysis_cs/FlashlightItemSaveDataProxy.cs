using Cpp2ILInjected.CallAnalysis;

public class FlashlightItemSaveDataProxy
{
	public bool m_IsOn;

	public bool m_IsHigh;

	public float m_CurrentBatteryCharge;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FlashlightItemSaveDataProxy()
	{
	}
}
