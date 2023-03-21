using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayback : MonoBehaviour
{
	public class TimelineCallbacks
	{
		public Action m_OnPlaying;

		public Action m_OnComplete;

		public Action m_OnInterrupted;

		[CallerCount(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		public PlayerCameraControlRotationSettings()
		{
		}
	}

	[Serializable]
	public class TimelineInfo
	{
		public TimelineRef m_TimelineAsset;

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
		[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CalledBy(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void PlayTimelineOnPlayer(TimelineInfo timeline, TimelineCallbacks callbacks, bool shouldStowItemInHands, PlayerControlMode controlMode = PlayerControlMode.Normal)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Start")]
	[CalledBy(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void PlayTimelineOnSelf(TimelineInfo timeline, TimelineCallbacks callbacks)
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Update")]
	[Calls(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StartPlayerSyncingToSyncBone")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(Elevator), Member = "LoadTimeline")]
	[CallerCount(Count = 9)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	public void LoadTimelineOnSelf(TimelineInfo timelineInfo)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(CellToilet), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimelineRef), Member = "Load")]
	public void LoadTimeline(TimelineInfo timelineInfo, TLD_TimelineDirector targetDirector = null)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(TimelinePlayback), Member = "OnTimelineComplete")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetTimelineSpeed")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSpeed(float speed)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public double GetCurrentTimelineDuration()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 3)]
	public double GetCurrentTimelineTimeRemaining()
	{
		return default(double);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "ShouldRollForDrop")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	public double GetCurrentTimelineNormalizedProgress()
	{
		return default(double);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static StowResult AttemptToStowPlayerItemInHand(bool unequipImmediate, PlayerAnimation.OnAnimationEvent onStowComplete)
	{
		return default(StowResult);
	}

	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void StartPlayerSyncingToSyncBone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void StartPlayerTransitionOut()
	{
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	private void EnablePlayerFreeCameraMovement()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	private void DisablePlayerFreeCameraMovement()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CallerCount(Count = 2)]
	private void SetupSyncNodeBinding()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetupTrackBinding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	private void SetupBinding()
	{
	}

	[CallerCount(Count = 0)]
	private void OnItemStowComplete()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	private void Update()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	private void UpdateSyncPlayerToSyncBone()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTransitionOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnTimelineLoadingFailed()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallAnalysisFailed]
	private void OnTimelineComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void Finish()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Awake")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnDisable")]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	private void Cleanup()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	public TimelinePlayback()
	{
	}
}
