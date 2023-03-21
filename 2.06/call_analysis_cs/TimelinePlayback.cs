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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[CalledBy(Type = typeof(Elevator), Member = ".ctor")]
		[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = ".ctor")]
		[CalledBy(Type = typeof(TimelinePlayback), Member = ".ctor")]
		[CalledBy(Type = typeof(SteamPipeValve), Member = ".ctor")]
		[CalledBy(Type = typeof(Action_PlayTimeline), Member = ".ctor")]
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
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SteamPipeValve), Member = "OnOpenValveInteraction")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnPlayer), Member = "ExecuteTimelineAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void PlayTimelineOnPlayer(TimelineInfo timeline, TimelineCallbacks callbacks, bool shouldStowItemInHands, PlayerControlMode controlMode = PlayerControlMode.Normal)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Start")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "ExecuteTimelineAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StartPlayerSyncingToSyncBone")]
	[Calls(Type = typeof(TimelinePlayback), Member = "EnablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "DisablePlayerFreeCameraMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void PlayTimeline(TimelineInfo timeline, TLD_TimelineDirector targetDirector, TimelineCallbacks callbacks)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadTimeline")]
	[CalledBy(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[CallerCount(Count = 17)]
	public void LoadTimelineOnSelf(TimelineInfo timelineInfo)
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "LoadTimeline")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Elevator), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimelinePlayback), Member = "OnTimelineComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void SetSpeed(float speed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	public double GetCurrentTimelineDuration()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 1)]
	public double GetCurrentTimelineTimeRemaining()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	public double GetCurrentTimelineNormalizedProgress()
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static StowResult AttemptToStowPlayerItemInHand(bool unequipImmediate, PlayerAnimation.OnAnimationEvent onStowComplete)
	{
		return default(StowResult);
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void StartPlayerSyncingToSyncBone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartPlayerTransitionOut()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void EnablePlayerFreeCameraMovement()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UnlockRotationLimit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateFreeCameraLook")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void DisablePlayerFreeCameraMovement()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetFPAnchorBindingInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void SetupSyncNodeBinding()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void SetupTrackBinding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetupTrackBinding")]
	private void SetupBinding()
	{
	}

	[CalledBy(TypeFullName = "System.Xml.Serialization.TypeTranslator", Member = ".cctor")]
	[CallerCount(Count = 1)]
	private void OnItemStowComplete()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "Finish")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateTransitionOut")]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[Calls(Type = typeof(AssetReferenceTimeline), Member = "get_IsLoaded")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[Calls(Type = typeof(TimelinePlayback), Member = "UpdateSyncPlayerToSyncBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateSyncPlayerToSyncBone()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateTransitionOut()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnTimelineLoaded")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallerCount(Count = 2)]
	private void OnTimelineComplete()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(TimelinePlayback), Member = "Cleanup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Finish()
	{
	}

	[CalledBy(Type = typeof(TimelinePlayback), Member = "Awake")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "OnDisable")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "Finish")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public TimelinePlayback()
	{
	}
}
