using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EmergencyStimItem : MonoBehaviour
{
	public float m_HPIncrease;

	public float m_FatigueInitialDecrease;

	public float m_FatigueEndingIncrease;

	public float m_StaminaEndingDecrease;

	public float m_HoursStimulatedWhenInjected;

	public float m_MinHoursBetweenUsage;

	public float m_PulseFrequencyStart;

	public float m_PulseFrequencyEnd;

	private GearItem m_GearItem;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void Use()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CallsUnknownMethods(Count = 2)]
	public void OnInject()
	{
	}

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	private void OnInjectComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EmergencyStimItem()
	{
	}
}
