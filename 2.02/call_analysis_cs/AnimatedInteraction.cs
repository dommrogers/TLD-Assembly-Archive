using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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

	public PlayerAnimation.AnimationLayerFlags m_AnimationLayersDisabled;

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

	public TimelineRef m_TimelineRef;

	public bool m_UseSyncNodeAsTimelineFPAnchor;

	public List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	public LocalizedString m_LocID_SprainedWristMessage;

	public LocalizedString m_LocID_SprainedAnkleMessage;

	public bool m_UseLegacyCameraOffset;

	public bool m_RadialSync;

	public float m_RadialSyncRadius;

	public bool m_UseAutoEquip;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "AddSyncNodeTimelineOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CheckCompletionActionPossible()
	{
		return false;
	}

	[CalledBy(Type = typeof(Lock), Member = "StartInteract")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "EndDiagnosing")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(LoadScene), Member = "StartInteract")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "DoWork")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool StartAnimatedInteraction(Action onAnimationCompleted, bool forceInteraction, bool shouldStowItemInHands, Action onAnimationInterrupted = null)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void DoInteraction(bool shouldStowItemInHands)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeResumeFov")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDequipping()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateStowItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	private bool MaybeStowItemInHand()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnItemInHandStowed()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateDequipping")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateStowItemInHand")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Condition), Member = "ResetLowHealthPitchAndRoll")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeMoveSyncBoneToRadius")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnPlayInteractAnimation()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeMoveSyncBoneToRadius()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeOverrideNearPlane()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeResetNearPlane()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	private void MaybePopToSync()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTransitionOut()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetCameraFov()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeResumeFov()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Slerp")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeBlendToSyncBone()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void MaybeSpawnProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void OnTimelineLoaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTimelineLoadingFailed()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Interrupt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[CallsUnknownMethods(Count = 1)]
	private void StopTimeline()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	private void MaybeTriggerAnimation()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnterPlaying(bool success)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "GetAnimator")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void DoTriggerAnimation()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Animator GetAnimator(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void MaybeAddSpawnedPropToInventory()
	{
	}

	[CallerCount(Count = 0)]
	private float GetFovTransitionDuration()
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnTimelineLoadingFailed")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StopTimeline")]
	[CallerCount(Count = 3)]
	private void OnInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybePerformCompletionAction")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	private void DoOnInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public bool RespectContrainsts()
	{
		return false;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool CanInteract()
	{
		return false;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybePerformCompletionAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DoBodyHarvest()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void AddSyncNodeTimelineOverride()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsFovControlled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StartResumingFov()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBedInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool InProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPlayingNonInterruptableAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool InterruptAnyInProgressAnimations()
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AnimatedInteraction()
	{
	}
}
