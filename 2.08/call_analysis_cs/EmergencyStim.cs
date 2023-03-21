using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class EmergencyStim : MonoBehaviour
{
	private PanelReference<Panel_HUD> m_HUD;

	private EmergencyStimParams m_EmergencyStimParams;

	private float m_LastStimPulseTime;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[Calls(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
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

	[CallerCount(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	public bool GetEmergencyStimActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	public bool CanUseEmergencyStim()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffNotification")]
	[Calls(Type = typeof(EnergyBoost), Member = "Cancel")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public void ApplyEmergencyStim(EmergencyStimItem emergencyStim)
	{
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public float GetTimeRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public float GetActiveHoursRemaining()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(CameraEffects), Member = "StimPulse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStimExitEffects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void MaybeUpdateEmergencyStimEffects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EmergencyStim), Member = "MaybeUpdateEmergencyStimEffects")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	private void ApplyEmergencyStimExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public EmergencyStim()
	{
	}
}
