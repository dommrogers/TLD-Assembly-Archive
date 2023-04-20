using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class BowItem : MonoBehaviour
{
	public string m_DrawAudio;

	public string m_HoldAudio;

	public string m_ReleaseAudio;

	public string m_ArrowNockAudio;

	public List<AssetReferenceT<GearItemData>> m_ArrowReferences;

	public float m_SwayValueZeroFatigue;

	public float m_SwayValueMaxFatigue;

	public float m_SwayIncreasePerSecond;

	public float m_SwayDecreasePerSecond;

	public float m_SwayEnergyBoostBonus;

	public float m_SwayEnergyStimBonus;

	public float m_AimingSwayDropThresholdPercent;

	private GearItem m_GearArrow;

	private GearItem m_GearBow;

	private BowState m_BowState;

	private uint m_HoldAudioInstance;

	private float m_SwayValue;

	private List<GearItem> m_ValidArrows;

	private int m_SelectedArrowIndex;

	private GearItem m_SelectedArrowPrefab;

	private static BowItemSaveDataProxy m_BowItemSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void Start()
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
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStamina")]
	[Calls(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill_Archery), Member = "CanFireBowWhileCrouched")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PressFire()
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "GetNextValidArrowIndex")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanSwitchArrow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "GetNextValidArrowIndex")]
	[Calls(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(BowItem), Member = "GetSelectedArrow")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 1)]
	public void PressSwitchArrow()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "CanSwitchArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "PressSwitchArrow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNextValidArrowIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	private void OnReadyToAimComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	public bool ShouldBeZooming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsSwitchingArrow()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(BowItem), Member = "PressSwitchArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetSelectedArrow()
	{
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[CallsUnknownMethods(Count = 3)]
	public int GetNumAllArrowsInInventory()
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public int GetNumSelectedArrowsInInventory()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(BowItem), Member = "PressSwitchArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "GetNextValidArrowIndex")]
	[CalledBy(Type = typeof(BowItem), Member = "GetNumAllArrowsInInventory")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumArrowsInInventory(GearItemData arrowData)
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
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateUnloaded")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private bool Equipped()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BowItem), Member = "Equipped")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBowStateUnloaded()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UpdateBowStateReadyToAim()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[CallsUnknownMethods(Count = 4)]
	public float GetSwayIncreasePerSecond()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateBowStamina()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(BowItem), Member = "StopHoldAudio")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateBowStateAim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(BowItem), Member = "NockArrow")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeHandleDroppedArrow()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(ArrowItem), Member = "Fire")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Fire")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void ShootArrow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetBowDamageModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BowItem), Member = "GetSelectedArrow")]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(BowItem), Member = "MakeArrowChildOfBow")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeSpawnArrow()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "PressSwitchArrow")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(BowItem), Member = "RemoveArrowChildFromBow")]
	[Calls(Type = typeof(ArrowItem), Member = "SetPlacementHelperEnabled")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void OnDequip()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "Update")]
	[CalledBy(Type = typeof(BowItem), Member = "PressSwitchArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowState")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateUnloaded")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeHandleDroppedArrow")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_BowAim_Cancel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Reload")]
	[Calls(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void MakeArrowChildOfBow(GearItem arrow)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveArrowChildFromBow(GearItem arrow)
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopHoldAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 1)]
	private void ZoomStart()
	{
	}

	[CalledBy(Type = typeof(BowItem), Member = "ExhaustedRelaxBow")]
	[CalledBy(Type = typeof(BowItem), Member = "ReleaseFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ForceReady")]
	[CalledBy(Type = typeof(BowItem), Member = "UpdateBowStateAim")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "NockArrow")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ToggleZoom")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CallsUnknownMethods(Count = 1)]
	private void ZoomEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BowItem()
	{
	}
}
