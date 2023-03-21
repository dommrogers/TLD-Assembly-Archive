using Cpp2ILInjected.CallAnalysis;

public class EmergencyStimParams
{
	public float m_HoursStimulatedWhenInjected;

	public float m_MinHoursBetweenUsage;

	public float m_StimPulseFrequencyStart;

	public float m_StimPulseFrequencyEnd;

	public float m_LastUsageTimeInGameHours;

	public float m_FatigueIncreaseWhenComplete;

	public float m_StaminaDecreaseWhenComplete;

	public float m_PlayCatchBreathSecondsAfterBegin;

	public uint m_AudioIDEmergencyStim;

	[CallerCount(Count = 0)]
	public EmergencyStimParams()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public EmergencyStimParams(EmergencyStimParams rhs)
	{
	}
}
