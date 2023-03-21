using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CinematicTrack
{
	public enum MasterAnimatorType
	{
		NPC,
		FP
	}

	public delegate void OnEnterPlaying(bool success);

	private enum State
	{
		None,
		Loading,
		Playing,
		Complete
	}

	private sealed class _003CLoadAnimations_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CinematicTrack _003C_003E4__this;

		public string assetBundleFilename;

		public string prefabPath;

		private AssetBundleRefRequest _003Crequest_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CLoadAnimations_003Ed__66(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
		[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
		[Calls(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
		[Calls(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(CinematicTrack), Member = "RetrieveLoadedAnimators")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(CinematicAssets), Member = "LoadProps")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 44)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private MasterAnimatorType m_MasterAnimatorType;

	private OnEnterPlaying m_OnEnterPlaying;

	private string m_NPCID;

	private TextAsset m_SubtitlesAsset;

	private string m_LoadedAssetBundleFilename;

	private string m_LoadedPrefabPath;

	private AssetBundleRef m_AssetBundle;

	private CinematicAssets m_CinematicAssets;

	private bool m_AnimationsLoadingComplete;

	private GameObject m_AnimationsAsset;

	private Animator m_CurrentFPHAnimator;

	private Animator m_CurrentNPCAnimator;

	private RuntimeAnimatorController m_OriginalFPHRuntimeAnimatorController;

	private RuntimeAnimatorController m_OriginalNPCRuntimeAnimatorController;

	private State m_State;

	private string m_AudioEventStart;

	private float m_CurrentAnimationTime;

	private string m_StateName;

	private string m_OnGoingAnimationStateKey;

	private Utils.Subtitle[] m_Subtitles;

	private uint m_NumSubtitles;

	private int m_OnGoingAnimationState;

	private int m_FPBaseLayerIndex;

	private int m_NPCBaseLayerIndex;

	private float m_OnGoingAnimationDuration;

	private static float s_AudioDurationRealtimeSeconds;

	private uint m_AudioID;

	private GameObject m_AudioEmitterNode;

	private List<CinematicAssets.PermanentPropInfo> m_PermanentProps;

	private Animator m_LoadedNPCAnimator;

	private Animator m_LoadedFPHAnimator;

	private PlayEventMonitor m_FPPlayEventMonitor;

	private PlayEventMonitor m_NPCPlayEventMonitor;

	private bool m_CurrentNPCAnimatorPlaying;

	private bool m_CurrentFPHAnimatorPlaying;

	private int m_PendingIdleHash;

	private int m_PendingIdleLayer;

	private bool m_IsIdlePending;

	private bool m_ShouldLockPlayer;

	private bool m_RestoreControllers;

	private bool m_FadedOutOnExit;

	private Vector3 m_WorldSpaceViewPositionAtStart;

	private Quaternion m_WorldSpaceViewRotationAtStart;

	private bool m_UseMotionFromRef;

	[CalledBy(Type = typeof(CinematicTrack), Member = "CreateFPCinematicTrack")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "CreateNPCCinematicTrack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private CinematicTrack(string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static CinematicTrack CreateFPCinematicTrack(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, OnEnterPlaying onEnterPlaying)
	{
		return null;
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static CinematicTrack CreateNPCCinematicTrack(DialogueAnimationState npcAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsNPC")]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsUnused()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ShouldLockPlayer()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetShouldLockPLayer(bool shouldLockPLayer)
	{
	}

	[CallerCount(Count = 0)]
	public void SetFadedOutOnExit(bool fadedOutOnExit)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsPlaying()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsLoading()
	{
		return false;
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void Play()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(AnimationUtils), Member = "FindAnimatorByMissionId")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(CinematicTrack), Member = "SaveOriginalControllers")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = "LoadAnimations")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void LoadCinematicAsync(string assetBundleFilemame, string prefabPath, TextAsset subtitleAsset)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[Calls(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(CinematicTrack), Member = "StartMasterAnimation")]
	[Calls(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsReady()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsWaitingForIdle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsFPStatePlaying(int hashState, int layer)
	{
		return false;
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UnloadCinematic()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(CinematicTrack), Member = "StartMasterAnimation")]
	[Calls(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void EnterPlaying()
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "StartLoading")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator LoadAnimations(string assetBundleFilename, string prefabPath)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SwapNPCController(RuntimeAnimatorController controller)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SaveOriginalControllers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool AreAssetsReady()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void AbortLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	private float GetOnGoingStateDuration(MasterAnimatorType masterAnimatorType)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetCinematicDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private void PlayAudio(string audioEventStart)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void LateSynchronizeAnimatorsNPC(float currentTime, int stateHash)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateUpdate")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void LateSynchronizeAnimatorsFP(float currentTime, int stateHash)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnCurrentNPCAnimatorStoppedPlaying()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnCurrentFPHAnimatorStoppedPlaying()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateAudioAndMaybeAnimationTime()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "SetTriggerOnLoadedPermanentProps")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void ReturnToIdleAnimation()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void StartMasterAnimation()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Utils), Member = "GetNextSkipTime")]
	[Calls(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[Calls(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	private void UpdatePlaying()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(CinematicTrack), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnCinematicDone()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUseMotionFromRef(bool useMotionFromRef)
	{
	}
}
