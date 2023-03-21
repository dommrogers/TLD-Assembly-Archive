using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
		[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayableDirector), Member = "add_stopped")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "PlayInternal")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	public bool HasFPAnchor()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsControllingHands()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableHandle), Member = "SetSpeed")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetSpeed")]
	[CallsUnknownMethods(Count = 3)]
	public void SetTimelineSpeed(float speed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public double GetDuration()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedProgress()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldUseRelativeCameraAnimation")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldSupressBreathFX")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackOutTransitionDurationSeconds")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	private TLD_CameraAnimationTrack GetCameraTrack()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[CallerCount(Count = 3)]
	public Transform GetCameraTrackFeetTransform()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	private void HandleGamePause()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	private void UpdateAudioDrivenTime()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	public void SetNewTime(float newTime)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	public float GetCurrentTimelineTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldUseRelativeCameraAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	public bool ShouldSupressBreathFX()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	public float GetCameraTrackNextEndTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCameraTrackOutTransitionDurationSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[Calls(Type = typeof(PlayableAssetSay), Member = "TryGetCurrentTimelineTimeFromAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	public bool TryGetTimeFromVoice(out float currentTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currentTime) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "UpdateAudioDrivenTime")]
	public bool TryGetTimeFromAudio(uint audioID, out float currAudioTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currAudioTime) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTimeChangePending()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "OnStop")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
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
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(TimelineRef), Member = "PlayTimeline")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CallsDeduplicatedMethods(Count = 11)]
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

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnPlay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	public static void DoDynamicBinding(TimelineAsset timelineAsset, PlayableDirector director)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetWaitUserInput), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSay), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetPlayAudio), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TimelineClip FindClip(PlayableDirector director, UnityEngine.Object clipAsset)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 16)]
	public static T FindTrack<T>(PlayableDirector director, SearchTrackCB<T> searchTrackCB) where T : TrackAsset
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	public static BindingInfo GetTrackBindingInfo(List<BindingInfo> list, string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "AddSyncNodeTimelineOverride")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[CallsUnknownMethods(Count = 3)]
	public static BindingInfo GetFPAnchorBindingInfo(List<BindingInfo> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public GameObject GetGameObjectOverride(string objectName, string currentMissionId)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallsUnknownMethods(Count = 3)]
	public bool TryGetFPAnchorTargetOverride(out GameObject overideTarget)
	{
		overideTarget = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Cleanup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnPause(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "DoDynamicBinding")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnPlay(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkCinematicAsViewed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void OnStop(PlayableDirector director)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public void RequestDeleteOnTimelineEnd(GearItem item)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public TLD_TimelineDirector()
	{
	}
}
