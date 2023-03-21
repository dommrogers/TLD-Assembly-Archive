using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_CameraAnimationTrack : AnimationTrack, TLD_ITrack, TLD_IDynamicBindableTrack, TLD_IFPAnchoredTrack
{
	public float m_FieldOfView;

	public bool m_OverrideClipPlanes;

	public float m_NearClipPlane;

	public float m_FarClipPlane;

	public bool m_HoldLastFPFrame;

	public bool m_ReplaceDialogueExit;

	public float m_InTransitionDurationSeconds;

	public float m_OutTransitionDurationSeconds;

	public bool m_HoldPlayerOverrideForNextTimeline;

	public bool m_SuppressBreathFX;

	public bool m_UseRelativeCameraAnimation;

	public bool m_AllowFreeCameraMovement;

	private CameraGlobalRT m_GlobalCamera;

	private PlayerControlMode m_RestorePlayerControlMode;

	private static Camera s_AnimatedCamera;

	private static GameObject s_AnimatedCameraAnimatorObject;

	private static GameObject s_AnimatedCameraRootObject;

	private static GameObject s_AnimatedCameraHeadObject;

	private static GameObject s_AnimatedCameraFeetObject;

	private static int s_CountPlaying;

	private bool m_IsPlaying;

	private Transform m_FPAnchor;

	private bool m_HasStartedOverride;

	private Vector3 m_OriginalFPPosition;

	private Quaternion m_OriginalFPRotation;

	private Quaternion m_OriginalCameraLocalRotation;

	private bool m_HasUpdatedForAnchor;

	private float m_AppliedNearClipPlane;

	private float m_AppliedFarClipPlane;

	private bool m_FPSCameraDisabled;

	private bool m_TimelineHasFPAnchor;

	private bool m_HasInitializedExitValues;

	private Quaternion m_ExitStartCameraRootOriginalRotation;

	private TLD_TimelineDirector m_Director;

	private Vector3 m_OriginalPosition;

	private Vector3 m_OriginalLocalPosition;

	private Quaternion m_OriginalRotation;

	private float m_OriginalFieldOfView;

	private float m_OriginalNearClipPlane;

	private float m_OriginalFarClipPlane;

	private static bool s_IsHoldingCameraDisabledForNextTimeline;

	private static bool s_IsHoldingFovForNextTimeline;

	private static float s_OriginalFovForNextTimeline;

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	private void StartCameraOverride()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "IsControllingHands")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSupressBreathFX()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	public float GetNextEndTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdatePlay()
	{
	}

	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCameraExit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "StartCameraOverride")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void LateUpdatePlay()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetCamera")]
	[CallsUnknownMethods(Count = 5)]
	public static void ResetAllTransforms(Transform t)
	{
	}

	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ResetCamera()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[Calls(Type = typeof(TrackAsset), Member = "get_timelineAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsUnknownMethods(Count = 9)]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public Transform GetFeetTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private GameObject GetCamera()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void CreateAnimatedCamera()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CallsUnknownMethods(Count = 27)]
	private void UpdateCamera(float progress, Vector3 desiredPosition, Quaternion desiredRotation)
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void UpdateCameraExit(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_CameraAnimationTrack()
	{
	}
}
