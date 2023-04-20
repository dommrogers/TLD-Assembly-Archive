using Cpp2ILInjected.CallAnalysis;

public class ConditionSaveDataProxy
{
	public float m_CurrentHPProxy;

	public float m_NumSecondsSinceLastVoiceOver;

	public bool m_NeverDieProxy;

	public bool m_Invulnerable;

	public bool m_HideDamageEvents;

	public bool m_FoceUncrouched;

	public bool m_CanPlayNearDeathMusic;

	public ConditionLevel m_ConditionLevelForPreviousVoiceOver;

	public bool m_SuppressVoiceOver;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ConditionSaveDataProxy()
	{
	}
}
