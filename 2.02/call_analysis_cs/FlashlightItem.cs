using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlashlightItem : MonoBehaviour
{
	private enum State
	{
		Off,
		Low,
		High,
		Paused
	}

	public Color m_Color;

	private AuroraField m_AuroraField;

	private GameObject m_FxObjectLow;

	private GameObject m_FxObjectHigh;

	private Light m_LightIndoor;

	private Light m_LightOutdoor;

	private Light m_LightIndoorHigh;

	private Light m_LightOutdoorHigh;

	private string m_TurnOnAudio;

	private string m_TurnOffAudio;

	private float m_LowBeamDuration;

	private float m_HighBeamDuration;

	private float m_RechargeTime;

	private float m_HighBeamCooldownSeconds;

	private float m_AuroraFieldForwardOffset;

	private float m_AuroraFieldVerticalOffset;

	private GearItem m_GearItem;

	private State m_State;

	private State m_PreviousState;

	private uint m_TurnOnAudioId;

	private uint m_TurnOffAudioId;

	private float m_CurrentBatteryCharge;

	private float m_HighBeamCooldownEndTime;

	private static FlashlightItemSaveDataProxy m_FlashlightItemSaveDataProxy;

	private uint m_IntensityAudioID;

	private bool m_FlareIsPaused;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsUnknownMethods(Count = 8)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(FlashlightItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 2)]
	public void DoRecharge(float deltaTODHours)
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	public float GetNormalizedCharge()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	public bool IsLit()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsLow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsOn()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Toggle()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	public void TurnOn()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	public void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	public void TurnOffImmediate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTurnOnFXCallback()
	{
	}

	[Calls(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	[CallerCount(Count = 0)]
	private void OnTurnOnCompleteCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
	private void OnTurnOffCompleteCallback()
	{
	}

	[CallerCount(Count = 0)]
	public void PauseLight()
	{
	}

	[CallerCount(Count = 0)]
	public void ResumeLight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnCompleteCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	private void ShowEquipItemPopup()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnFXCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Deserialize")]
	private void EnableLights(State state)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void PlayTurnOnAudio()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void PlayTurnOffAudio()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	private void DoThreeDaysOfNightBonus()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public FlashlightItem()
	{
	}
}
