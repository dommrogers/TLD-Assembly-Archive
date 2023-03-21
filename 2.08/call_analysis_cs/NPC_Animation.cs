using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class NPC_Animation : MonoBehaviour
{
	[Serializable]
	public class PermanentPropInfo
	{
		public CinematicAssets.PermanentPropId m_PermanentPropId;

		public Animator m_Animator;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PermanentPropInfo()
		{
		}
	}

	public enum VO_State
	{
		None,
		RequestRandomVO,
		VOPlaying
	}

	private PanelReference<Panel_Subtitles> m_Subtitles;

	public List<PermanentPropInfo> m_PermanentProps;

	public List<string> m_LocIdList;

	public int m_IdlesVariationCount;

	public GameObject m_AudioEmitterNode;

	public float m_MinDelayUntilNextVOSeconds;

	public float m_MaxDelayUntilNextVOSeconds;

	public float m_MinDelayUntilNextIdleSeconds;

	public float m_MaxDelayUntilNextIdleSeconds;

	private VO_State m_VO_State;

	private Animator m_Animator;

	private int m_OnGoingAnimationState;

	private uint m_AudioID;

	private float m_VODuration;

	private float m_AudioDurationRealtimeSeconds;

	private float m_OnGoingAnimationDuration;

	private int m_NPCBaseLayerIndex;

	private int m_NPCHeadLayerIndex;

	private int m_NPCFaceLayerIndex;

	private float m_VOElapsedTime;

	private string m_OnGoingAnimationTrigger;

	private string m_OnGoingFaceAnimationTrigger;

	private PlayEventMonitor m_PlayEventMonitor;

	private float m_NextVOElapsedTime;

	private float m_DelayUntilNextVOSeconds;

	private float m_NextIdleVariationElapsedTime;

	private float m_DelayUntilNextIdleVariationSeconds;

	private int m_CurrentRandomLocIndex;

	private int m_CurrentVariationIdleIndex;

	private int m_AnimParameter_IdleVariationIndex;

	private const string TRIGGER_PREFIX = "Trigger_";

	private const string TRIGGER_FACE_PREFIX = "Trigger_Face_";

	private const string TRIGGER_IDLE = "Trigger_Idle";

	private const string TRIGGER_IDLE_FACE = "Trigger_Idle_Face";

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void RollDelayNextVO()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void RollDelayNextIdle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_Animation), Member = "RequestVO")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsNotSpeaking()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[CallerCount(Count = 0)]
	public void RestoreIdleIndex()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update_None()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private string RollLocId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[CallsUnknownMethods(Count = 1)]
	private void RollCurrentIdleVariation()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_RequestRandomVO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RequestVO(string requestedLocId)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void Update_RequestRandomVO()
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[Calls(Type = typeof(NPC_Animation), Member = "ReturnToIdleAnimation")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	private void Update_VOPlaying()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 2)]
	private void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 3)]
	private float GetOnGoingStateDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	private void ReturnToIdleAnimation()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "RestoreIdleIndex")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "MaybeChangeVariationIdle")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RollCurrentIdleVariation")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	private void SetAnimationParameter_IdleVariationIndex(int idleVariationIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeChangeVariationIdle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NPC_Animation()
	{
	}
}
