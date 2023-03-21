using Cpp2ILInjected.CallAnalysis;

public class PhoneSaveDataInfo
{
	public string m_MissionId;

	public bool m_HasStartedRinging;

	public int m_RingCycleCount;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PhoneSaveDataInfo()
	{
	}
}
