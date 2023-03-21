using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EnergyBoost : MonoBehaviour
{
	public string m_EnergyBoostPulseEvent;

	public string m_EnergyBoostStartAudio;

	private EnergyBoostParams m_EnergyBoostParams;

	private float m_LastBoostPulseTime;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	public bool GetEnergyBoostActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CalledBy(Type = typeof(EnergyBoostItem), Member = "ApplyBoost")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadacheExitEffects")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void ApplyEnergyBoost(EnergyBoostItem energyBoostItem)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingNormalized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	public float GetEnergyBoostTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	public float GetEnergyBoostTimeRemainingNormalized()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	public void Cancel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "BoostEffectPulse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(EnergyBoost), Member = "Update")]
	[CallerCount(Count = 1)]
	private void MaybeUpdateEnergyBoostEffects()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	private void ApplyEnergyBoostExitEffects()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EnergyBoost()
	{
	}
}
