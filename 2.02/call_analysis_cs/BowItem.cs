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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public void PressFire()
	{
	}

	[CallerCount(Count = 0)]
	private void OnReadyToAimComplete()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public void ExhaustedRelaxBow()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsBowAllowedToFire")]
	[Calls(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void ReleaseFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnFireComplete()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void CancelItemInHandsAction()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanEquipWithArrow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ShouldBeZooming()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumArrowsInInventory()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public bool IsArrowNocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBowState()
	{
	}

	[CallerCount(Count = 0)]
	private void SetState(BowState state)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool Equipped()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBowStateReady()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void UpdateBowStateReadyToAim()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public float GetSwayIncreasePerSecond()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public float GetSwayDecreasePerSecond()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStaminaPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStaminaDropThresholdPercent()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(BowItem), Member = "GetSwayDecreasePerSecond")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateBowStamina()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateBowStateAim()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeHandleDroppedArrow()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "Fire")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 47)]
	private void ShootArrow()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(BowItem), Member = "MakeArrowChildOfBow")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeSpawnArrow()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(BowItem), Member = "RemoveArrowChildFromBow")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void OnDequip()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateReady")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void NockArrow()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnReloadComplete()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void MakeArrowChildOfBow(GearItem arrow)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void RemoveArrowChildFromBow(GearItem arrow)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopHoldAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ZoomStart()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ZoomEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BowItem()
	{
	}
}
