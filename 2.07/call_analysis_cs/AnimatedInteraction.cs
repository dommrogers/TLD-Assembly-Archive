using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class AnimatedInteraction : MonoBehaviour
{
	public enum CompletionAction
	{
		DoNothing,
		BodyHarvest
	}

	private enum State
	{
		Ready,
		StowItemInHand,
		LoadAnimation,
		PlayAnimation,
		AnimationRequested,
		TransitionOut,
		LoadTimeline,
		Dequipping
	}

	public struct SaveData
	{
		public string m_Guid;

		public int m_InteractionCount;
	}

	public PlayerControlMode m_ControlMode;

	public string m_Trigger;

	public float m_ApproachAngle;

	public float m_ApproachAngleAcceptableOffset;

	public GameObject m_SyncBone;

	public float m_Fov;

	public float m_SecondsToSync;

	public float m_FovSecondsToSync;

	public bool m_SyncPosition;

	public bool m_SyncOrientation;

	public bool m_SyncPitchFromSyncBone;

	public bool m_StartAnimationAfterSync;

	public bool m_ApplyRootOrientation;

	public bool m_InfiniteInteractions;

	public int m_MaxInteractionCount;

	public bool m_HandsInWeaponSpace;

	public bool m_PropInWeaponSpace;

	public GameObject m_SpawnedPropPrefab;

	public bool m_AddPropToInventoryOnComplete;

	public GameObject[] m_AnimatedProps;

	public LocalizedString m_LocID_Interactable;

	public LocalizedString m_LocID_NonInteractable;

	private PlayerAnimation.AnimationLayerFlags m_AnimationLayersDisabled;

	public float m_HipAndShoulderWeight;

	public bool m_UseHoverTextColor;

	public bool m_CanBeInterrupted;

	public bool m_OverrideNearPlane;

	public float m_NearPlane;

	public CompletionAction m_CompletionAction;

	public BodyHarvest m_BodyHarvest;

	public bool m_InteractionConstrained;

	public float m_InteractionConstrainedAngleDegrees;

	public bool m_UnequipImmediate;

	public bool m_LoadAnimation;

	public FPAnimationState m_FPAnimationState;

	public float m_FatigueCost;

	public LocalizedString m_LocID_LowFatigueMessage;

	public float m_StaminaCost;

	public LocalizedString m_LocID_LowStaminaMessage;

	public AssetReferenceTimeline m_TimelineRef;

	public bool m_UseSyncNodeAsTimelineFPAnchor;

	public List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	public LocalizedString m_LocID_SprainedWristMessage;

	public LocalizedString m_LocID_SprainedAnkleMessage;

	public bool m_UseLegacyCameraOffset;

	public bool m_RadialSync;

	public float m_RadialSyncRadius;

	public bool m_UseAutoEquip;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	private GameObject m_SpawnedProp;

	private int m_InteractionCount;

	private float m_SecondsLeftToSync;

	private float m_SecondsLeftToTransitionOut;

	private Vector3 m_StartPosition;

	private float m_OriginalFov;

	private Quaternion m_StartRotation;

	private Quaternion m_StartCamRotation;

	private Action m_OnAnimationCompleted;

	private Action m_OnAnimationInterrupted;

	private bool m_ItemStowed;

	private State m_State;

	private float m_DesiredFov;

	private bool m_HasStartedResumingFOV;

	private static bool s_ControlFOV;

	private static bool s_StartResumingFOVRequested;

	private static List<AnimatedInteraction> s_AnimatedInteractionList;

	private Vector3 m_SyncNodeOriginalPosition;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckCompletionActionPossible()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "EndDiagnosing")]
	public bool StartAnimatedInteraction(Action onAnimationCompleted, bool forceInteraction, bool shouldStowItemInHands, Action onAnimationInterrupted = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateInteraction")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanInteract()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private bool TryPerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "TryPerformInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	private void DoInteraction(bool shouldStowItemInHands)
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeResumeFov")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateDequipping()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateStowItemInHand()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool MaybeStowItemInHand()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateStowItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateDequipping")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeMoveSyncBoneToRadius")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Condition), Member = "ResetLowHealthPitchAndRoll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	private void OnPlayInteractAnimation()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	private void MaybeMoveSyncBoneToRadius()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeOverrideNearPlane()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeResetNearPlane()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybePopToSync()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	private void MaybeSetCameraFov()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeResumeFov()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeBlendToSyncBone()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void MaybeSpawnProp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private void OnTimelineLoaded(AssetReferenceTimeline result)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[CallsUnknownMethods(Count = 2)]
	private void Interrupt()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StopTimeline()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeTriggerAnimation()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnterPlaying(bool success)
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "GetAnimator")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "GetAnimator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DoTriggerAnimation()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Animator GetAnimator(GameObject parent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void MaybeAddSpawnedPropToInventory()
	{
	}

	[CallerCount(Count = 0)]
	private float GetFovTransitionDuration()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StopTimeline")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnTimelineLoaded")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	private void OnInteractionComplete()
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private void DoOnInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool RespectContrainsts()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePerformCompletionAction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DoBodyHarvest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CallsUnknownMethods(Count = 2)]
	private void AddSyncNodeTimelineOverride()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsFovControlled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void StartResumingFov()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[CalledBy(Type = typeof(Bed), Member = "ShouldPerformBedInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	public static bool InProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsPlayingNonInterruptableAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CallerCount(Count = 2)]
	public static bool InterruptAnyInProgressAnimations()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 8)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AnimatedInteraction()
	{
	}
}
