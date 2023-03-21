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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
		[Calls(Type = typeof(Vector2), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[CalledBy(Type = typeof(Elevator), Member = ".ctor")]
		[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = ".ctor")]
		[CalledBy(Type = typeof(TimelinePlayback), Member = ".ctor")]
		[CalledBy(Type = typeof(SteamPipeValve), Member = ".ctor")]
		[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = ".ctor")]
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

	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void PlayTimelineOnPlayer(TimelineInfo timeline, TimelineCallbacks callbacks, bool shouldStowItemInHands, PlayerControlMode controlMode = PlayerControlMode.Normal)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Start")]
	[CalledBy(Type = typeof(Action_PlayTimelineV2), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void PlayTimelineOnSelf(TimelineInfo timeline, TimelineCallbacks callbacks)
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimeline")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StartPlayerSyncingToSyncBone")]
	[Calls(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void PlayTimeline(TimelineInfo timeline, TLD_TimelineDirector targetDirector, TimelineCallbacks callbacks)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Elevator), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CallerCount(Count = 9)]
	public void LoadTimelineOnSelf(TimelineInfo timelineInfo)
	{
	}

	[CalledBy(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineRef), Member = "Load")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void LoadTimeline(TimelineInfo timelineInfo, TLD_TimelineDirector targetDirector = null)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "OnTimelineComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool StopCurrentTimeline()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetTimelineSpeed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSpeed(float speed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public double GetCurrentTimelineDuration()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public double GetCurrentTimelineTimeRemaining()
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(Elevator), Member = "ShouldRollForDrop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public double GetCurrentTimelineNormalizedProgress()
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static StowResult AttemptToStowPlayerItemInHand(bool unequipImmediate, PlayerAnimation.OnAnimationEvent onStowComplete)
	{
		return default(StowResult);
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void StartPlayerSyncingToSyncBone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void StartPlayerTransitionOut()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 23)]
	private void EnablePlayerFreeCameraMovement()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void DisablePlayerFreeCameraMovement()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void SetupSyncNodeBinding()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
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

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Finish")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(TimelineRef), Member = "IsLoaded")]
	[Calls(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 33)]
	private void UpdateSyncPlayerToSyncBone()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateTransitionOut()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnTimelineLoadingFailed()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallerCount(Count = 1)]
	private void OnTimelineComplete()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Finish()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "Awake")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnDisable")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelineRef), Member = "StopTimeline")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public TimelinePlayback()
	{
	}
}
