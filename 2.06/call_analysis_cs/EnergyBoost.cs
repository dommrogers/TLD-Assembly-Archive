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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	public bool GetEnergyBoostActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(EnergyBoostItem), Member = "ApplyBoost")]
	[CalledBy(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void ApplyEnergyBoost(EnergyBoostItem energyBoostItem)
	{
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingNormalized")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public float GetEnergyBoostTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[CallsUnknownMethods(Count = 1)]
	public float GetEnergyBoostTimeRemainingNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	public void Cancel()
	{
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateEnergyBoostEffects()
	{
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyEnergyBoostExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public EnergyBoost()
	{
	}
}
