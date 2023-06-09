using Cpp2ILInjected.CallAnalysis;

public class FreezingSaveDataProxy
{
	public float m_CurrentFreezingProxy;

	public float m_NumSecondsSinceLastVoiceOver;

	public bool m_FreezingInLog;

	public FreezingLevel m_FreezingLevelForPreviousVoiceOver;

	public float m_TemperatureBonusFromRunning;

	public bool m_SuppressVoiceOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FreezingSaveDataProxy()
	{
	}
}
