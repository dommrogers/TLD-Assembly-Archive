using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPC_Animation : MonoBehaviour
{
	[Serializable]
	public class PermanentPropInfo
	{
		public CinematicAssets.PermanentPropId m_PermanentPropId;

		public Animator m_Animator;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[Calls(Type = typeof(NPC_Animation), Member = "Update_RequestRandomVO")]
	[Calls(Type = typeof(NPC_Animation), Member = "MaybeChangeVariationIdle")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[Calls(Type = typeof(NPC_Animation), Member = "LateSynchronizeAnimators")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_RequestRandomVO")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "DisplaySubtitleText")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultAudioStartForDialogueLineFromLocId")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetDefaultStateNameForDialogueLineFromLocId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayVoiceWithPositionTracking")]
	private void RequestVO(string requestedLocId)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NPC_Animation), Member = "RequestVO")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 1)]
	private void Update_RequestRandomVO()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(CinematicManager), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(NPC_Animation), Member = "ReturnToIdleAnimation")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void Update_VOPlaying()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 2)]
	private float ComputeSubtitleDurationInSeconds(string text)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "Update_VOPlaying")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void ReturnToIdleAnimation()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "LateUpdate")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	private void LateSynchronizeAnimators(float currentTime, int stateHash)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "TryGetPlayingStateId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[CalledBy(Type = typeof(NPC_Animation), Member = "RestoreIdleIndex")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPC_Animation), Member = "MaybeChangeVariationIdle")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "RollCurrentIdleVariation")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateEnd")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	private void SetAnimationParameter_IdleVariationIndex(int idleVariationIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_Animation), Member = "SetAnimationParameter_IdleVariationIndex")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(NPC_Animation), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeChangeVariationIdle()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public NPC_Animation()
	{
	}
}
