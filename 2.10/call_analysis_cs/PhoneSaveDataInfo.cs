using Cpp2ILInjected.CallAnalysis;

public class PhoneSaveDataInfo
{
	public string m_MissionId;

	public bool m_HasStartedRinging;

	public int m_RingCycleCount;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PhoneSaveDataInfo()
	{
	}
}
