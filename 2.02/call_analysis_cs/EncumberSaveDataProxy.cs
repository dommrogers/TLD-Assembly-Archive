using Cpp2ILInjected.CallAnalysis;

public class EncumberSaveDataProxy
{
	public bool m_EncumberedInLog;

	public float m_NumSecondsSinceLastVoiceOver;

	public EncumberLevel m_EcumberLevelForPreviousVoiceOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public EncumberSaveDataProxy()
	{
	}
}
