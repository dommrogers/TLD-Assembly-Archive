using Cpp2ILInjected.CallAnalysis;

public class FatigueSaveDataProxy
{
	public float m_CurrentFatigueProxy;

	public float m_NumSecondsSinceLastVoiceOver;

	public bool m_ExhaustedInLog;

	public FatigueLevel m_FatigueLevelForPreviousVoiceOver;

	public bool m_SuppressVoiceOver;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public FatigueSaveDataProxy()
	{
	}
}
