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

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	private void RollDelayNextVO()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void RollDelayNextIdle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NPC_Animation), Member = "RequestVO")]
	public void Update()
	{
	}

	[Calls(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsNotSpeaking()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	public void RestoreIdleIndex()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RollCurrentIdleVariation()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_RequestRandomVO")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RequestVO(string requestedLocId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void Update_RequestRandomVO()
	{
	}

	[Calls(Type = typeof(NPC_Animation), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void ReturnToIdleAnimation()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "MaybeChangeVariationIdle")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RollCurrentIdleVariation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RestoreIdleIndex")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	private void SetAnimationParameter_IdleVariationIndex(int idleVariationIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeChangeVariationIdle()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NPC_Animation()
	{
	}
}
