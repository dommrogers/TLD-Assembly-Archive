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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "AddSyncNodeTimelineOverride")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_StartAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "OnValveActivateInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "StartInteract")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "EndDiagnosing")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhonePickup")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteract")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "StartDiagnosing")]
	public bool StartAnimatedInteraction(Action onAnimationCompleted, bool forceInteraction, bool shouldStowItemInHands, Action onAnimationInterrupted = null)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	private void DoInteraction(bool shouldStowItemInHands)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CanEnable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeResumeFov")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeBlendToSyncBone")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateDequipping()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateStowItemInHand()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 18)]
	private bool MaybeStowItemInHand()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnItemInHandStowed()
	{
	}

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateStowItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateDequipping")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Condition), Member = "ResetLowHealthPitchAndRoll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeMoveSyncBoneToRadius")]
	private void OnPlayInteractAnimation()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	private void MaybeMoveSyncBoneToRadius()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeOverrideNearPlane()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeResetNearPlane()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybePopToSync()
	{
	}

	[Calls(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeSetCameraFov")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void UpdateTransitionOut()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetCameraFov()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void MaybeResumeFov()
	{
	}

	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Slerp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeBlendToSyncBone()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnProp()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTimelineLoaded()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	private void OnTimelineLoadingFailed()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "OnInteractionComplete")]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnPlayInteractAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Update")]
	[Calls(Type = typeof(TimelineRef), Member = "LoadForPlayerDirector")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void MaybeTriggerAnimation()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnterPlaying(bool success)
	{
	}

	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeTriggerAnimation")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "GetAnimator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "GetAnimator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void DoTriggerAnimation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoTriggerAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public Animator GetAnimator(GameObject parent)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
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
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnTimelineLoadingFailed")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	private void OnInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "MaybePerformCompletionAction")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void DoOnInteractionComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public bool RespectContrainsts()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public bool CanInteract()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybePerformCompletionAction()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void DoBodyHarvest()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Awake")]
	[CallsUnknownMethods(Count = 10)]
	private void AddSyncNodeTimelineOverride()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsFovControlled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void StartResumingFov()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBedInteraction")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[CalledBy(Type = typeof(CameraStatusEffects), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	public static bool InProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPlayingNonInterruptableAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "Interrupt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static bool InterruptAnyInProgressAnimations()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 9)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AnimatedInteraction()
	{
	}
}
