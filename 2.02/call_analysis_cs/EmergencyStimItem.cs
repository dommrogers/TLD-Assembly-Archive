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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Use()
	{
	}

	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 17)]
	public void OnInject()
	{
	}

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	private void OnInjectComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EmergencyStimItem()
	{
	}
}
