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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 16)]
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
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallsUnknownMethods(Count = 7)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSupressBreathFX()
	{
		return false;
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsUnknownMethods(Count = 11)]
	public float GetNextEndTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdatePlay()
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "SetFPAnchor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "StartCameraOverride")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCamera")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "UpdateCameraExit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void LateUpdatePlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Physics), Member = "get_autoSyncTransforms")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 38)]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetCamera")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void ResetAllTransforms(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ResetCamera()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[Calls(Type = typeof(TrackAsset), Member = "get_timelineAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public Transform GetFeetTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "DoDynamicBinding")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 27)]
	private GameObject GetCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "CreateOrFindGameObjectFromPath")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CreateAnimatedCamera()
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 27)]
	private void UpdateCamera(float progress, Vector3 desiredPosition, Quaternion desiredRotation)
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "LateUpdatePlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateCameraExit(float progress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_CameraAnimationTrack()
	{
	}
}
