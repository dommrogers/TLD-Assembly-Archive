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

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void StartCameraOverride()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HasFPAnchor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "IsControllingHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallsUnknownMethods(Count = 7)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSupressBreathFX()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CallsUnknownMethods(Count = 11)]
	public float GetNextEndTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdatePlay()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCameraExit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "StartCameraOverride")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void LateUpdatePlay()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	public static void ResetAllTransforms(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CallsUnknownMethods(Count = 2)]
	public static void ResetCamera()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TrackAsset), Member = "get_timelineAsset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public Transform GetFeetTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 3)]
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
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
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
