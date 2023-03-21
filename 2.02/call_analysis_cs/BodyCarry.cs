using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class BodyCarry : MonoBehaviour
{
	private enum HoistDirection
	{
		Pickup,
		Putdown
	}

	public enum DisplayError
	{
		InteractionBlocked,
		LeavingNPCBehind,
		IncorrectRescueOrder,
		NPCCannotLeave,
		CrouchCannotInteract
	}

	public string m_PickupAudioLow;

	public string m_PickupAudioMedium;

	public string m_PickupAudioHigh;

	public string m_PutdownAudioLow;

	public string m_PutdownAudioMedium;

	public string m_PutdownAudioHigh;

	private CarryableBody _003Cm_Body_003Ek__BackingField;

	[NonSerialized]
	public bool m_AllowBodyTransferBetweenZones;

	private GearItem m_BodyGearItem;

	private Animator m_BodyAnimator;

	private string m_BodyDropAnimationState;

	private GameObject m_BodyGameObject;

	private bool m_DropIsPending;

	private bool m_IsPlacingBodyPending;

	private bool m_BodyCarryIdleAnimationRequested;

	private bool m_CarryRequested;

	private static int s_BodyIdleAnimationStateHash;

	private bool m_HandsReady;

	public CarryableBody m_Body
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "IsAnimationPlayingOnAnyLayer")]
	[Calls(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool ReadyToCarry()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void CancelPlacement()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BodyCarry), Member = "CarryCallback")]
	[Calls(Type = typeof(NPC), Member = "HandlePickUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void Carry(CarryableBody body)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	private void MaybeDoCarry()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeStowItemInHand()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	private void CarryInternal()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[Calls(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDropImmediate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool Drop(BodyDropOptions opts)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[CallsUnknownMethods(Count = 11)]
	public void ReadyForPlacementDropAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsPlacingBodyPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsDropPending()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void OnDropPlaceMeshAnimationComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[CalledBy(Type = typeof(Condition_HasBodyCarry), Member = "OnCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAlternateColor")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	public bool HasBody()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public NPC GetCarriedNpc()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "GetPosition")]
	[CalledBy(Type = typeof(NPCDisableConditionUpdateEnforcer), Member = "Update")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CalledBy(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public bool IsCarryingBody(CarryableBody body)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyDrop")]
	public bool MaybeDrop()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool MaybeDropImmediate()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyPlacement")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public bool MaybePlace()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlaceableManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PrepareForSceneTransition()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 59)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsActive")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public bool ProcessInteraction(CarryableBody body)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool CanInteractWithObject(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ShowError(DisplayError error)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	private void CarryCallback()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void DiagnoseCallback()
	{
	}

	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Restore(CarryableBody body)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[CalledBy(Type = typeof(BodyCarry), Member = "CarryInternal")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 4)]
	private void PlayHoistEffortAudio(HoistDirection direction)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SearchCallback()
	{
	}

	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Restore")]
	[CalledBy(Type = typeof(BodyCarry), Member = "CarryInternal")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void SetupCarryState(bool restored)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void AttachFPMesh()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "OnDropPlaceMeshAnimationComplete")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DetachFPMesh()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 10)]
	private bool StickBodyToGroundAtPlayersFeet()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "IsAnimationPlayingOnAnyLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	private bool IsPlayingCarryIdleAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 3)]
	private void PlayCarryIdleAnimation()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BodyCarry()
	{
	}
}
