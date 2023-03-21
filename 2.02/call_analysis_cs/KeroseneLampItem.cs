using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KeroseneLampItem : MonoBehaviour
{
	public float m_MaxFuelLiters;

	public float m_FuelBurnLitersPerHour;

	public float m_TurnOnEffectsDelay;

	public float m_TurnOffDelay;

	public string m_TurnOnAudio;

	public string m_ExtinguishStartAudio;

	public string m_TurnOffAudio;

	public string m_LoopAudioWithDelay;

	public string m_LoopAudio;

	public float m_RefuelTimeSeconds;

	public string m_RefuelAudio;

	public float m_TurnOnEffectsTimer;

	public float m_CurrentFuelLiters;

	public static bool m_InfiniteLampOn;

	public KeroseneLampIntensity m_IntensityComponent;

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

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "ReduceFuel")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "UpdateEffects")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallerCount(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "ReduceFuel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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
	public void TurnOnAfterDelay()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOnAfterDelay")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "PlaySparkParticles")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void TurnOn(bool supressStartAudio)
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnExtinguishComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnExtinguishCompleteCallback")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopSparkParticles")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	public void TurnOff(bool playAudio = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Extinguish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 14)]
	public void TurnOffDelayed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	private void OnExtinguishCompleteCallback()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Toggle()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void CancelAction()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	public float AddFuel(float fuelLiters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetMaxFuelToAdd()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public float GetPercentFuelRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "OnDisable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	[CallsUnknownMethods(Count = 2)]
	public void StopLoopingAudio()
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ReduceFuel(float hoursBurned)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateLoopingAudioPosition()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Confirm")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	private void UpdateEffects()
	{
	}

	[CallsUnknownMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlaySparkParticles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SetChildOnOff), Member = "StartOnOffCycle")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "ForceGetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "ForceGetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "ForceGetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetChildOnOff), Member = "StartOnOffCycle")]
	private void PlayerSparkParticlesOnSpecific(GameObject turningOnFX)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlaySparkParticles()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(SetChildOnOff), Member = "CancelOnOffCycle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StopSparkParticles()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopLoopingAudio")]
	[DeduplicatedMethod]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopLoopingAudio")]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public KeroseneLampItem()
	{
	}
}
