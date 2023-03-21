using Cpp2ILInjected.CallAnalysis;

public class HeatSourceSaveDataProxy
{
	public bool m_IsEnabledProxy;

	public float m_MaxTempIncreaseProxy;

	public float m_MaxTempIncreaseInnerRadiusProxy;

	public float m_MaxTempIncreaseOuterRadiusProxy;

	public float m_TimeToReachMaxTempMinutesProxy;

	public float m_TempIncreaseProxy;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public HeatSourceSaveDataProxy()
	{
	}
}
