using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EmergencyStim : MonoBehaviour
{
	private EmergencyStimParams m_EmergencyStimParams;

	private float m_LastStimPulseTime;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[Calls(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetEmergencyStimActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallerCount(Count = 0)]
	public bool CanUseEmergencyStim()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	public void ApplyEmergencyStim(EmergencyStimItem emergencyStim)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float GetTimeRemainingNormalized()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetActiveHoursRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "StimPulse")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUpdateEmergencyStimEffects()
	{
	}

	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	private void ApplyEmergencyStimExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EmergencyStim()
	{
	}
}
