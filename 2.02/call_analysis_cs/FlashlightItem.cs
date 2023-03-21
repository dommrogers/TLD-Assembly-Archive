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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AuroraField), Member = "SetDynamic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFire")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "UpdateAudio")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 27)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoRecharge(float deltaTODHours)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "AllowedToHideAmmoPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOn")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedCharge()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(FirstPersonFlashlight), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Toggle()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlashlightItem), Member = "GetNormalizedCharge")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void TurnOn()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
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
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ShowEquipItemPopup()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOnFXCallback")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "OnTurnOffCompleteCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 27)]
	private void EnableLights(State state)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void PlayTurnOffAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightDurationMultiplier")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetFlashlightEffectivenessMultiplier")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(SphereCollider), Member = "set_radius")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 20)]
	private void DoThreeDaysOfNightBonus()
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FlashlightItem()
	{
	}
}
