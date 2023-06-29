using Cpp2ILInjected.CallAnalysis;

public class ThirstSaveDataProxy
{
	public float m_CurrentThirstProxy;

	public float m_NumSecondsSinceLastVoiceOver;

	public bool m_DehydratedInLog;

	public ThirstLevel m_ThirstLevelForPreviousVoiceOver;

	public bool m_SuppressVoiceOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ThirstSaveDataProxy()
	{
	}
}
