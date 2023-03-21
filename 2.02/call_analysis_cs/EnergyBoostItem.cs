using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnergyBoostItem : MonoBehaviour
{
	public float m_FatigueInitialDecrease;

	public float m_StaminaInitialIncrease;

	public float m_FatigueEndingIncrease;

	public float m_StaminaEndingDecrease;

	public float m_BoostDurationHours;

	public float m_PulseFrequencyStart;

	public float m_PulseFrequencyEnd;

	public float m_HeadacheDurationHours;

	public float m_HeadachePulseFrequencyStart;

	public float m_HeadachePulseFrequencyEnd;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyBoost()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EnergyBoostItem()
	{
	}
}
