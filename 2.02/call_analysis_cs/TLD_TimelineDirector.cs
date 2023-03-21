using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_TimelineDirector : MonoBehaviour
{
	[Serializable]
	public class BindingInfo
	{
		public enum BindingInfoType
		{
			MissionObjectId,
			GameObject
		}

		public enum OverrideType
		{
			TrackBinding,
			FPAnchor
		}

		public OverrideType m_OverrideType;

		public string m_Name;

		public BindingInfoType m_BindingType;

		public string m_MissionObjectId;

		public GameObject m_GameObject;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public BindingInfo()
		{
		}
	}

	public delegate bool SearchTrackCB<T>(T track);

	public TimelineManifest m_Manifest;

	private PlayableDirector m_Director;

	private bool m_IsPlaying;

	private uint m_AudioId;

	private bool m_IsAudioDriven;

	private float m_AudioClipStartTime;

	private bool m_IsPaused;

	private bool m_TimeChangeRequested;

	private int m_TimeChangeRequestedFrameCount;

	private Action m_OnStopCallback;

	private List<BindingInfo> m_OverrideBindingInfoList;

	private bool m_HasGamePaused;

	private Vector3 m_FPPositionOnPlay;

	private Quaternion m_FPRotationOnPlay;

	private GearItem m_ItemToDeleteOnTimelineEnd;

	private Quaternion m_CameraLocalRotationOnPlay;

	private bool m_IsPlayerTimeline;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(PlayableDirector), Member = "add_stopped")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "PlayInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public bool HasFPAnchor()
	{
		return false;
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public bool IsControllingHands()
	{
		return false;
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetSpeed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableHandle), Member = "SetSpeed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetTimelineSpeed(float speed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public double GetDuration()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedProgress()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldUseRelativeCameraAnimation")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldSupressBreathFX")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackOutTransitionDurationSeconds")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private TLD_CameraAnimationTrack GetCameraTrack()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Transform GetCameraTrackFeetTransform()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleGamePause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAudioDrivenTime()
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetNewTime(float newTime)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCurrentTimelineTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldUseRelativeCameraAnimation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool ShouldSupressBreathFX()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCameraTrackNextEndTime(float currentTimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCameraTrackOutTransitionDurationSeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableAssetSay), Member = "TryGetCurrentTimelineTimeFromAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	public bool TryGetTimeFromVoice(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "UpdateAudioDrivenTime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool TryGetTimeFromAudio(uint audioID, out float currAudioTime)
	{
		currAudioTime = default(float);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTimeChangePending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "OnStop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public void AudioDrivenStart(uint audioId, float startTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void AudioDrivenStop()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAudioDriven(uint audioId)
	{
		return false;
	}

	[CalledBy(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	public void Play(TimelineAsset timelineAsset, Action onStop, List<BindingInfo> bindingOverrides, bool isPlayerTimeline, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 GetFPPositionOnPlay()
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Quaternion GetFPRotationOnPlay()
	{
		return default(Quaternion);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Quaternion GetCameraLocalRotationOnPlay()
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnPlay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static void DoDynamicBinding(TimelineAsset timelineAsset, PlayableDirector director)
	{
	}

	[CalledBy(Type = typeof(PlayableAssetPlayAudio), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSay), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetWaitUserInput), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public static TimelineClip FindClip(PlayableDirector director, UnityEngine.Object clipAsset)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PlayableAssetActivateSpawnedObject), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public static T FindTrack<T>(PlayableDirector director, SearchTrackCB<T> searchTrackCB) where T : TrackAsset
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static BindingInfo GetTrackBindingInfo(List<BindingInfo> list, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "AddSyncNodeTimelineOverride")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static BindingInfo GetFPAnchorBindingInfo(List<BindingInfo> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public GameObject GetGameObjectOverride(string objectName, string currentMissionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryGetFPAnchorTargetOverride(out GameObject overideTarget)
	{
		overideTarget = null;
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public void Cleanup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnPause(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void OnPlay(PlayableDirector director)
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkCinematicAsViewed")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void OnStop(PlayableDirector director)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public void RequestDeleteOnTimelineEnd(GearItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TLD_TimelineDirector()
	{
	}
}
