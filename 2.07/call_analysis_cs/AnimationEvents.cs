using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationEvents : StateMachineBehaviour
{
	public float m_FrameRate;

	public List<AnimationEventData> m_Events;

	private bool[] m_EventsPushed;

	private bool[] m_EventsPopped;

	private Dictionary<string, AnimationEventStack> m_EventStacks;

	private float m_NumFrames;

	private float m_LastFrameId;

	private float m_SyncNormalizedTime;

	private Dictionary<int, bool> m_HasEntered;

	private Dictionary<int, bool> m_HasUpdated;

	private PlayEventMonitor m_PlayEventMonitor;

	private uint m_NumSubtitles;

	private static Utils.Subtitle[] s_Subtitles;

	private List<Animator> m_FilteredListForResetEventStacks;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 3)]
	private void DoEnter(Animator animator, AnimatorStateInfo stateInfo)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ResetRemainingEventsForInstigator")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventUpdateLayerWeight")]
	private void DoExit(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateUpdate")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	private void DoUpdate(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventUpdateLayerWeight")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	private void MaybeTriggerEvent(Animator animator, int index, float frame)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[Calls(Type = typeof(AnimationEventStack), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	private void MaybeRecreateEventArrays()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	private void ProcessEndFrameEvents(Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "ProcessEndFrameEvents")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AnimationEvents), Member = "GetCurrentValueFromList")]
	private void ResetEventStacks(Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[CallsUnknownMethods(Count = 8)]
	private AnimationEventValue GetCurrentValueFromList(List<Animator> list, Animator animator, int hash, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
		return default(AnimationEventValue);
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void EventHide(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	private void EventShow(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsChildOfFP(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void EventPlay(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void EventStop(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	private void EventPlayMovie(Animator animator, AnimationEventData eventAnimationData, float delay, float startTime)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	private void EventDisplaySubtitles(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	private void EventUpdateLayerWeight(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	private void EnableHipAndShoulderOffsetLayerOverride(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void EventPrepareMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallerCount(Count = 0)]
	private void EventEnableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	private void EventDisableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisableObject")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	private void DoEnableObject(Animator animator, AnimationEventData eventAnimationData, bool isEnabled)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "Stop")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	private void EventStopMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	private void SetParameterValue(Animator animator, string name, AnimationEventValue value, RuntimeAnimatorController target, int targetCycleOffsetHash)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	private void PushAnimationEventValue(Animator animator, int index, AnimationEventValue value)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	private void PopAnimationEventValue(Animator animator, int index)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public AnimationEvents()
	{
	}
}
