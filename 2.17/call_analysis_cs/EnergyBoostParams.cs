using Cpp2ILInjected.CallAnalysis;

public class EnergyBoostParams
{
	public float m_BoostDurationHours;

	public float m_BoostPulseFrequencyStart;

	public float m_BoostPulseFrequencyEnd;

	public float m_LastUsageTimeInGameHours;

	public float m_FatigueIncreaseWhenComplete;

	public float m_StaminaDecreaseWhenComplete;

	[CallerCount(Count = 0)]
	public EnergyBoostParams()
	{
	}
}
