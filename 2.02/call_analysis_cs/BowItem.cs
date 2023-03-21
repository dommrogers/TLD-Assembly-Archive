using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	public void PressFire()
	{
	}

	[CallerCount(Count = 0)]
	private void OnReadyToAimComplete()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	public void ExhaustedRelaxBow()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	public void ReleaseFire()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnFireComplete()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void CancelItemInHandsAction()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanEquipWithArrow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ShouldBeZooming()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
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
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateBowState()
	{
	}

	[CallerCount(Count = 0)]
	private void SetState(BowState state)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private bool Equipped()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	private void UpdateBowStateReady()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void UpdateBowStateReadyToAim()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallsUnknownMethods(Count = 12)]
	public float GetSwayIncreasePerSecond()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateBowStamina()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void UpdateBowStateAim()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeHandleDroppedArrow()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[Calls(Type = typeof(ArrowItem), Member = "Fire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void ShootArrow()
	{
	}

	[Calls(Type = typeof(BowItem), Member = "MakeArrowChildOfBow")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeSpawnArrow()
	{
	}

	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(BowItem), Member = "RemoveArrowChildFromBow")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	public void OnDequip()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	private void NockArrow()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnReloadComplete()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private void MakeArrowChildOfBow(GearItem arrow)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void RemoveArrowChildFromBow(GearItem arrow)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CallsUnknownMethods(Count = 2)]
	private void StopHoldAudio()
	{
	}

	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	private void ZoomStart()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	private void ZoomEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BowItem()
	{
	}
}
