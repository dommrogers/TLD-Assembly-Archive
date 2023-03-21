using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 44)]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CinematicAssets), Member = "ReParentProp")]
		[Calls(Type = typeof(CinematicAssets), Member = "LoadProps")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(CinematicTrack), Member = "RetrieveLoadedAnimators")]
		[Calls(Type = typeof(CinematicAssets), Member = "UseLoadedControllerAndResumeState")]
		[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
		[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
		[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
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

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "CreateNPCCinematicTrack")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "CreateFPCinematicTrack")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private CinematicTrack(string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[CallsUnknownMethods(Count = 9)]
	public static CinematicTrack CreateFPCinematicTrack(FPAnimationState fpAnimationState, string audioStart, TextAsset subtitleAsset, string npcID, GameObject audioEmitterNode, OnEnterPlaying onEnterPlaying)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterNPC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = ".ctor")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ShouldLockPlayer()
	{
		return default(bool);
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsLoading()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartMasterTrack")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	public void Play()
	{
	}

	[Calls(Type = typeof(CinematicTrack), Member = "LoadAnimations")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Play")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicTrack), Member = "SaveOriginalControllers")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(AnimationUtils), Member = "FindAnimatorByMissionId")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void LoadCinematicAsync(string assetBundleFilemame, string prefabPath, TextAsset subtitleAsset)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CinematicManager), Member = "Update")]
	[Calls(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[Calls(Type = typeof(CinematicTrack), Member = "StartMasterAnimation")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[Calls(Type = typeof(CinematicAssets), Member = "RestoreOriginalControllerAndResumeState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	[Calls(Type = typeof(CinematicTrack), Member = "UnloadCinematic")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CinematicTrack), Member = "SwapNPCController")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsReady()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool IsWaitingForIdle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsNPCStatePlaying(int hashState, int layer)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsFPStatePlaying(int hashState, int layer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(CinematicAssets), Member = "UnloadProps")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AssetBundleManager), Member = "UnloadBundle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void UnloadCinematic()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[Calls(Type = typeof(CinematicTrack), Member = "StartMasterAnimation")]
	[Calls(Type = typeof(CinematicTrack), Member = "PlayAudio")]
	[CallsUnknownMethods(Count = 2)]
	private void EnterPlaying()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CinematicManager), Member = "StartLoading")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IEnumerator LoadAnimations(string assetBundleFilename, string prefabPath)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	private void RetrieveLoadedAnimators(string errorPath)
	{
	}

	[CalledBy(Type = typeof(_003CLoadAnimations_003Ed__66), Member = "MoveNext")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CinematicManager), Member = "SwitchControllerAndResumeState")]
	private void SwapNPCController(RuntimeAnimatorController controller)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallsUnknownMethods(Count = 4)]
	private void SaveOriginalControllers()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool AreAssetsReady()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AbortLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	private float GetOnGoingStateDuration(MasterAnimatorType masterAnimatorType)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetCinematicDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 3)]
	private static void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	private void PlayAudio(string audioEventStart)
	{
	}

	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateUpdate")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicManager), Member = "LateUpdate")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void LateSynchronizeAnimatorsNPC(float currentTime, int stateHash)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LateUpdate")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CinematicManager), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(CinematicAssets), Member = "LateSynchronizeAnimators")]
	private void LateSynchronizeAnimatorsFP(float currentTime, int stateHash)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnCurrentNPCAnimatorStoppedPlaying()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnCurrentFPHAnimatorStoppedPlaying()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateAudioAndMaybeAnimationTime()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[Calls(Type = typeof(CinematicAssets), Member = "SetTriggerOnLoadedPermanentProps")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	private void ReturnToIdleAnimation()
	{
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(DialogueStatesTable), Member = "GetListEntryFromStateKey")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StartMasterAnimation()
	{
	}

	[Calls(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(CinematicTrack), Member = "LateSynchronizeAnimatorsFP")]
	[Calls(Type = typeof(CinematicManager), Member = "GetAdjustedSkipTimeAndTryToSeekAudio")]
	[Calls(Type = typeof(Utils), Member = "GetNextSkipTime")]
	[Calls(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CinematicManager), Member = "MaybeSeekMovie")]
	private void UpdatePlaying()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CinematicTrack), Member = "ReturnToIdleAnimation")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	private void OnCinematicDone()
	{
	}

	[CallerCount(Count = 0)]
	public void SetUseMotionFromRef(bool useMotionFromRef)
	{
	}
}
