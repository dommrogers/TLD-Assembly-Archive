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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 13)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void DoRecharge(float deltaTODHours)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CallerCount(Count = 3)]
	public float GetNormalizedCharge()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallerCount(Count = 4)]
	public bool IsLit()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsLow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsOn()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Toggle()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Toggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTurnOnFXCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlashlightItem), Member = "ShowEquipItemPopup")]
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
		return false;
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnCompleteCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowEquipItemPopup()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnFXCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	private void EnableLights(State state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PlayTurnOnAudio()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void PlayTurnOffAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void DoThreeDaysOfNightBonus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	public FlashlightItem()
	{
	}
}
