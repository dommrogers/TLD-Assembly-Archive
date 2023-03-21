using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void DoRecharge(float deltaTODHours)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	public float GetNormalizedCharge()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 5)]
	public void Toggle()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Toggle")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	public void TurnOn()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	public void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	public void TurnOffImmediate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnCompleteCallback")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void ShowEquipItemPopup()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnFXCallback")]
	private void EnableLights(State state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayTurnOnAudio()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	private void PlayTurnOffAudio()
	{
	}

	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	private void DoThreeDaysOfNightBonus()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	public FlashlightItem()
	{
	}
}
