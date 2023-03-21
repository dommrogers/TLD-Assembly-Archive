using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class BowItem : MonoBehaviour
{
	public string m_DrawAudio;

	public string m_HoldAudio;

	public string m_ReleaseAudio;

	public string m_ArrowNockAudio;

	public string m_GearArrowPrefabName;

	public float m_SwayValueZeroFatigue;

	public float m_SwayValueMaxFatigue;

	public float m_SwayIncreasePerSecond;

	public float m_SwayDecreasePerSecond;

	public float m_SwayEnergyBoostBonus;

	public float m_SwayEnergyStimBonus;

	private GearItem m_GearArrow;

	private GearItem m_GearBow;

	private BowState m_BowState;

	private uint m_HoldAudioInstance;

	private float m_SwayValue;

	public float m_AimingSwayDropThresholdPercent;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void Update()
	{
	}

	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	public void PressFire()
	{
	}

	[CallerCount(Count = 0)]
	private void OnReadyToAimComplete()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	public void ExhaustedRelaxBow()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	public void ReleaseFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 1)]
	private void OnFireComplete()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void CancelItemInHandsAction()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void ForceReady()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnAimToReadyComplete()
	{
	}

	[CallerCount(Count = 0)]
	public bool InReadyState()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	public bool CanEquipWithArrow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ShouldBeZooming()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumArrowsInInventory()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public bool IsArrowNocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	private void UpdateBowState()
	{
	}

	[CallerCount(Count = 0)]
	private void SetState(BowState state)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	private bool Equipped()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBowStateReady()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void UpdateBowStateReadyToAim()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	public float GetSwayIncreasePerSecond()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 3)]
	public float GetSwayDecreasePerSecond()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStaminaPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetStaminaDropThresholdPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	private void UpdateBowStamina()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[Calls(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void UpdateBowStateAim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeHandleDroppedArrow()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(ArrowItem), Member = "Fire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void ShootArrow()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(BowItem), Member = "MakeArrowChildOfBow")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeSpawnArrow()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(BowItem), Member = "RemoveArrowChildFromBow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnDequip()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	private void NockArrow()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnReloadComplete()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MakeArrowChildOfBow(GearItem arrow)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void RemoveArrowChildFromBow(GearItem arrow)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	private void StopHoldAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	private void ZoomStart()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	private void ZoomEnd()
	{
	}

	[CallerCount(Count = 0)]
	public BowItem()
	{
	}
}
