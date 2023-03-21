using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class EnergyBoost : MonoBehaviour
{
	public string m_EnergyBoostPulseEvent;

	public string m_EnergyBoostStartAudio;

	private EnergyBoostParams m_EnergyBoostParams;

	private float m_LastBoostPulseTime;

	[Calls(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	public bool GetEnergyBoostActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(EnergyBoostItem), Member = "ApplyBoost")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	public void ApplyEnergyBoost(EnergyBoostItem energyBoostItem)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingNormalized")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public float GetEnergyBoostTimeRemainingHours()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	public float GetEnergyBoostTimeRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsUnknownMethods(Count = 1)]
	public void Cancel()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeUpdateEnergyBoostEffects()
	{
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadache")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	private void ApplyEnergyBoostExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public EnergyBoost()
	{
	}
}
