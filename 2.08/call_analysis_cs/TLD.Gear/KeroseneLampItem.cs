using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gear;

public class KeroseneLampItem : MonoBehaviour
{
	public float m_MaxFuelLiters;

	public float m_FuelBurnLitersPerHour;

	public float m_TurnOnEffectsDelay;

	public float m_TurnOffDelay;

	public AK.Wwise.Event m_TurnOnEvent;

	public AK.Wwise.Event m_ExtinguishStartEvent;

	public AK.Wwise.Event m_TurnOffEvent;

	public AK.Wwise.Event m_LoopWithDelayEvent;

	public AK.Wwise.Event m_LoopEvent;

	public AK.Wwise.Event m_RefuelEvent;

	public float m_RefuelTimeSeconds;

	public float m_TurnOnEffectsTimer;

	public float m_CurrentFuelLiters;

	public static bool m_InfiniteLampOn;

	public KeroseneLampIntensity m_IntensityComponent;

	private PanelReference<Panel_HUD> m_HUD;

	public Color m_Color;

	private uint m_TurnOnAudioID;

	private uint m_ExtinguishStartAudioID;

	private uint m_LoopAudioID;

	private bool m_On;

	private bool m_TurnOnComplete;

	private GameObject m_FXGameObject;

	private Light m_LightIndoor;

	private Light m_LightIndoorCore;

	private Light m_LightOutdoor;

	private float m_TurnOffTimer;

	private bool m_TurningOff;

	private HeatSource m_HeatSource;

	private float m_TimeToBreak;

	private GearItem m_GearItem;

	private bool m_FlareIsPaused;

	private static KeroseneLampItemSaveDataProxy m_KeroseneLampItemSaveDataProxy;

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "ReduceFuel")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "ReduceFuel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOn()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	private void TurnOnAfterDelay()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOnAfterDelay")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "PlaySparkParticles")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	private void TurnOn(bool supressStartAudio)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnExtinguishCompleteCallback")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopSparkParticles")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	public void TurnOff(bool playAudio = true)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	public void TurnOffDelayed()
	{
	}

	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallerCount(Count = 0)]
	private void OnExtinguishCompleteCallback()
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
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Toggle()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 1)]
	public void CancelAction()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	public float AddFuel(float fuelLiters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetMaxFuelToAdd()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetPercentFuelRemaining()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void DestroyHeatSource()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallsUnknownMethods(Count = 2)]
	public void HideEffects(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	public float GetModifiedFuelBurnLitersPerHour()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	public void OnDroppedInWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	public void StopLoopingAudio()
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	private void ReduceFuel(float hoursBurned)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLoopingAudioPosition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateEffects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnIgniteComplete()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsIgniting()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsIgnitingOrExtinguishing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlaySparkParticles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SetChildOnOff), Member = "StartOnOffCycle")]
	[Calls(Type = typeof(Utils), Member = "ForceGetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SetChildOnOff), Member = "StartOnOffCycle")]
	private void PlayerSparkParticlesOnSpecific(GameObject turningOnFX)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void PlaySparkParticles()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SetChildOnOff), Member = "CancelOnOffCycle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StopSparkParticles()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public KeroseneLampItem()
	{
	}
}
