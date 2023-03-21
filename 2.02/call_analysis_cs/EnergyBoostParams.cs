using Cpp2ILInjected.CallAnalysis;

public class EnergyBoostParams
{
	public float m_BoostDurationHours;

	public float m_BoostPulseFrequencyStart;

	public float m_BoostPulseFrequencyEnd;

	public float m_LastUsageTimeInGameHours;

	public float m_FatigueIncreaseWhenComplete;

	public float m_StaminaDecreaseWhenComplete;

	public float m_HeadacheDurationHours;

	public float m_HeadachePulseFrequencyStart;

	public float m_HeadachePulseFrequencyEnd;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EnergyBoostParams()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public EnergyBoostParams(EnergyBoostParams rhs)
	{
	}
}
