using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private FPSItem m_BodyFPSItem;

	private AK.Wwise.Event m_PickupAudioLowEvent;

	private AK.Wwise.Event m_PickupAudioMediumEvent;

	private AK.Wwise.Event m_PickupAudioHighEvent;

	private AK.Wwise.Event m_PutdownAudioLowEvent;

	private AK.Wwise.Event m_PutdownAudioMediumEvent;

	private AK.Wwise.Event m_PutdownAudioHighEvent;

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

	private readonly List<ActionPickerItemData> m_ItemData;

	private ActionPickerItemData m_CarryPickerData;

	private ActionPickerItemData m_DiagnosePickerData;

	private ActionPickerItemData m_SearchPickerData;

	public CarryableBody m_Body
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 31)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[Calls(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[Calls(Type = typeof(BodyCarry), Member = "IsPlayingCarryIdleAnimation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool ReadyToCarry()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void CancelPlacement()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BodyCarry), Member = "CarryCallback")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[Calls(Type = typeof(Bed), Member = "RemoveBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "HandlePickUp")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Carry(CarryableBody body)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	private void MaybeDoCarry()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void MaybeStowItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	private void CarryInternal()
	{
	}

	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDrop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDropImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool Drop(BodyDropOptions opts)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	public void ReadyForPlacementDropAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPlacingBodyPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsDropPending()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(BodyCarry), Member = "DetachFPMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDropPlaceMeshAnimationComplete()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	public bool HasBody()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NPC GetCarriedNpc()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(NPC), Member = "IsBeingCarried")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAll")]
	[CalledBy(Type = typeof(NPCDisableConditionUpdateEnforcer), Member = "Update")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "GetPosition")]
	public bool IsCarryingBody(CarryableBody body)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyDrop")]
	public bool MaybeDrop()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[CallerCount(Count = 0)]
	public bool MaybeDropImmediate()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoBodyPlacement")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallsUnknownMethods(Count = 5)]
	public bool MaybePlace()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlaceableManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PrepareForSceneTransition()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AreAllAfflictionTreated")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarryableBody), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Bed), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BodyCarry), Member = "Carry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NPC), Member = "IsActive")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallerCount(Count = 3)]
	public bool ProcessInteraction(CarryableBody body)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool CanInteractWithObject(IInteraction interaction)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnExamine")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnBeginCrafting")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(NPC), Member = "GetFromGuid")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static void ShowError(DisplayError error)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "Carry")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void CarryCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DiagnoseCallback()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(PlaceableManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Restore(CarryableBody body)
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "CarryInternal")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void PlayHoistEffortAudio(HoistDirection direction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "ShowContainerContents")]
	[CallsUnknownMethods(Count = 1)]
	private void SearchCallback()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "AttachFPMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BodyCarry), Member = "CarryInternal")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(NPC), Member = "ResetNextAmbientAudioTimer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeDoCarry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void SetupCarryState(bool restored)
	{
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "CopyChildObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MoveToTempParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void AttachFPMesh()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "OnDropPlaceMeshAnimationComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "RestoreChildObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[CallerCount(Count = 2)]
	private void DetachFPMesh()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 7)]
	private bool StickBodyToGroundAtPlayersFeet()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[Calls(Type = typeof(AnimationUtils), Member = "IsStatePlayingOnAnyLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsPlayingCarryIdleAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayAnimation")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	private void PlayCarryIdleAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public BodyCarry()
	{
	}
}
