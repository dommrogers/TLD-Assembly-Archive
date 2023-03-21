using Cpp2ILInjected.CallAnalysis;

public class WillpowerSaveDataProxy
{
	public float m_TimeRemainingSecondsProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public WillpowerSaveDataProxy()
	{
	}
}
