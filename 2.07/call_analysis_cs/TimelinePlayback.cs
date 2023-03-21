using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

public class TimelinePlayback : MonoBehaviour
{
	public class TimelineCallbacks
	{
		public Action m_OnPlaying;

		public Action m_OnComplete;

		public Action m_OnInterrupted;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public TimelineCallbacks()
		{
		}
	}

	[Serializable]
	public class PlayerCameraControlRotationSettings
	{
		public bool m_AllowPlayerFreeCameraLook;

		public bool m_HoldPlayerFreeCameraLookForNextTimeline;

		public Vector2 m_PitchLimit;

		public Vector2 m_YawLimit;

		[CallerCount(Count = 0)]
		public PlayerCameraControlRotationSettings()
		{
		}
	}

	[Serializable]
	public class TimelineInfo
	{
		public AssetReferenceTimeline m_TimelineReference;

		public bool m_SkipDisableCrouch;

		public Animator m_BindingAnimator;

		public string m_BindingTrackName;

		public GameObject m_SyncBone;

		public DirectorWrapMode m_WrapMode;

		public float m_TimeToSyncPlayerToSyncBone;

		public float m_TimeToTransitionOut;

		public float m_DesiredFov;

		public bool m_UnloadAfterPlay;

		public PlayerCameraControlRotationSettings m_OptionalPlayerCameraRotation;

		public vp_FPSPlayer.UnCrouchOptions m_UnCrouchOptions;

		[CallerCount(Count = 20)]
		public TimelineInfo()
		{
		}
	}

	public enum StowResult
	{
		StowInProgress,
		DeEquipping,
		Done
	}

	private enum State
	{
		Inactive,
		WaitingForPlayerReady,
		Loading,
		Playing,
		TransitionOut
	}

	private Animator m_Animator;

	private TLD_TimelineDirector m_TimelineDirector;

	public List<TLD_TimelineDirector.BindingInfo> m_TimelineBindingOverrides;

	private TimelineInfo m_OptionalPlayTimelineOnStart;

	private State m_CurrentState;

	private TLD_TimelineDirector m_TimelineDirectorToPlayOn;

	private TimelineInfo m_TimelineToPlay;

	private TimelineCallbacks m_Callbacks;

	private PlayerControlMode m_PlayerControlMode;

	private PlayerControlMode m_PreviousPlayerControlMode;

	private bool m_TimelineBeingPlayedOnPlayer;

	private bool m_StowComplete;

	private Vector3 m_PlayerSyncStartPosition;

	private Quaternion m_PlayerSyncStartRotation;

	private float m_OriginalPlayerFov;

	private float m_FovBeforeTransition;

	private float m_TimeLeftToSyncPlayer;

	private float m_CurrentFov;

	private Quaternion m_OriginalCameraRotation;

	private Vector2 m_OriginalCameraPitchLimit;

	private Vector2 m_OriginalCameraYawLimit;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "StartPlayerSyncingToSyncBone")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_PlayTimelineOnPlayer), Member = "ExecuteTimelineAction")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void PlayTimelineOnPlayer(TimelineInfo timeline, TimelineCallbacks callbacks, bool shouldStowItemInHands, PlayerControlMode controlMode = PlayerControlMode.Normal)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "ExecuteTimelineAction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Start")]
	[CalledBy(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Format")]
	public void PlayTimelineOnSelf(TimelineInfo timeline, TimelineCallbacks callbacks)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StartPlayerSyncingToSyncBone")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	public void PlayTimeline(TimelineInfo timeline, TLD_TimelineDirector targetDirector, TimelineCallbacks callbacks)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CallerCount(Count = 17)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	public void LoadTimelineOnSelf(TimelineInfo timelineInfo)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 2)]
	public void LoadTimeline(TimelineInfo timelineInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[Calls(Type = typeof(TimelinePlayback), Member = "OnTimelineComplete")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTimelineLoaded(AssetReferenceTimeline timeline)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "OnDestroy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(TimelinePlayback), Member = "OnTimelineComplete")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	public bool StopCurrentTimeline()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetSpeed(float speed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	public double GetCurrentTimelineDuration()
	{
		return default(double);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public double GetCurrentTimelineTimeRemaining()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	public double GetCurrentTimelineNormalizedProgress()
	{
		return default(double);
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static StowResult AttemptToStowPlayerItemInHand(bool unequipImmediate, PlayerAnimation.OnAnimationEvent onStowComplete)
	{
		return default(StowResult);
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void StartPlayerSyncingToSyncBone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartPlayerTransitionOut()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void EnablePlayerFreeCameraMovement()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisablePlayerFreeCameraMovement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CallsUnknownMethods(Count = 2)]
	private void SetupSyncNodeBinding()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetupTrackBinding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	[CallsUnknownMethods(Count = 2)]
	private void SetupBinding()
	{
	}

	[CallerCount(Count = 0)]
	private void OnItemStowComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void UpdateSyncPlayerToSyncBone()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateTransitionOut()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnTimelineLoaded")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	private void OnTimelineComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void Finish()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Awake")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnDisable")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CallsUnknownMethods(Count = 3)]
	private void Cleanup()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimelineInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TimelinePlayback()
	{
	}
}
