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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
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

	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CalledBy(Type = typeof(EnergyBoostItem), Member = "ApplyBoost")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsUnknownMethods(Count = 7)]
	public void ApplyEnergyBoost(EnergyBoostItem energyBoostItem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingNormalized")]
	[CallerCount(Count = 3)]
	public float GetEnergyBoostTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeUpdateEnergyBoostEffects()
	{
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadache")]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CallerCount(Count = 1)]
	private void ApplyEnergyBoostExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public EnergyBoost()
	{
	}
}
