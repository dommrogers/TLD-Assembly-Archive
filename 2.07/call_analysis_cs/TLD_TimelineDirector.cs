using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Logging;
using TLD.SaveState;
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
		[CallerCount(Count = 6)]
		public BindingInfo()
		{
		}
	}

	public delegate bool SearchTrackCB<T>(T track);

	public static readonly LogFilter s_LogFilter;

	public static readonly List<BindingInfo> NO_BINDING_OVERRIDE;

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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(PlayableDirector), Member = "add_stopped")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 7)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "PlayInternal")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	public bool HasFPAnchor()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Play")]
	[CallsUnknownMethods(Count = 10)]
	public bool IsControllingHands()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public void SetTimelineSpeed(float speed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public double GetDuration()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTimeRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedProgress()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackOutTransitionDurationSeconds")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldSupressBreathFX")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "ShouldUseRelativeCameraAnimation")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackFeetTransform")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrackNextEndTime")]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(TLD_FPAnimationTrack), Member = "MaybeUpdateTransitionOut")]
	private TLD_CameraAnimationTrack GetCameraTrack()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetFeetTransform")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "UpdatePlay")]
	public Transform GetCameraTrackFeetTransform()
	{
		return null;
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	private void HandleGamePause()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[Calls(Type = typeof(PlayableDirector), Member = "set_time")]
	private void UpdateAudioDrivenTime()
	{
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public void SetNewTime(float newTime)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	public float GetCurrentTimelineTime()
	{
		return default(float);
	}

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[CallerCount(Count = 0)]
	public bool ShouldUseRelativeCameraAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldSupressBreathFX()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "GetNextEndTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	public float GetCameraTrackNextEndTime(float currentTimeSeconds)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetCameraTrack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCameraTrackOutTransitionDurationSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "HandleGamePause")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Update")]
	[Calls(Type = typeof(Math), Member = "Max")]
	[Calls(Type = typeof(PlayableAssetSay), Member = "TryGetCurrentTimelineTimeFromAudio")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	public bool TryGetTimeFromVoice(out float currentTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currentTime) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "OnStop")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableDirector), Member = "remove_stopped")]
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

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyPlayTimeline")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "OnTimelineLoaded")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTimeline")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetNewTime")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_play_timeline")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 11)]
	public void Play(TimelineAsset timelineAsset, Action onStop, List<BindingInfo> bindingOverrides, bool isPlayerTimeline, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnPlay")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DoDynamicBinding(TimelineAsset timelineAsset, PlayableDirector director)
	{
	}

	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CalledBy(Type = typeof(PlayableAssetPlayAudio), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSay), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetWaitUserInput), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 23)]
	public static TimelineClip FindClip(PlayableDirector director, UnityEngine.Object clipAsset)
	{
		return null;
	}

	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static T FindTrack<T>(PlayableDirector director, SearchTrackCB<T> searchTrackCB) where T : TrackAsset
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Phone), Member = "AssignBindingInfo")]
	[CallsUnknownMethods(Count = 4)]
	public static BindingInfo GetTrackBindingInfo(List<BindingInfo> list, string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupBinding")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "SetupSyncNodeBinding")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "AddSyncNodeTimelineOverride")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "Awake")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnPlayer")]
	public static BindingInfo GetFPAnchorBindingInfo(List<BindingInfo> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CalledBy(Type = typeof(TLD_ControlPlayableAsset), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	public GameObject GetGameObjectOverride(string objectName, string currentMissionId)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallsUnknownMethods(Count = 6)]
	public bool TryGetFPAnchorTargetOverride(out GameObject overideTarget)
	{
		overideTarget = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "Play")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TLD_CameraAnimationTrack), Member = "ResetAllTransforms")]
	public void Cleanup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnPause(PlayableDirector director)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "DoDynamicBinding")]
	[CallerCount(Count = 0)]
	private void OnPlay(PlayableDirector director)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfileState), Member = "AddViewedCinematic")]
	private void OnStop(PlayableDirector director)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public void RequestDeleteOnTimelineEnd(GearItem item)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLD_TimelineDirector()
	{
	}
}
