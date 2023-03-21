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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ResetRemainingEventsForInstigator")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventUpdateLayerWeight")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void DoExit(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void DoUpdate(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventUpdateLayerWeight")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeTriggerEvent(Animator animator, int index, float frame)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[Calls(Type = typeof(AnimationEventStack), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeRecreateEventArrays()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	private void ProcessEndFrameEvents(Animator animator)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "ProcessEndFrameEvents")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AnimationEvents), Member = "GetCurrentValueFromList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void ResetEventStacks(Animator animator)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private AnimationEventValue GetCurrentValueFromList(List<Animator> list, Animator animator, int hash, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
		return default(AnimationEventValue);
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EventHide(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EventShow(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsChildOfFP(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EventPlay(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnStop")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EventStop(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(MoviePlayer), Member = "Seek")]
	[CallsUnknownMethods(Count = 1)]
	private void EventPlayMovie(Animator animator, AnimationEventData eventAnimationData, float delay, float startTime)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(InterfaceManager), Member = "HidePanelsForSubtitle")]
	[CallsUnknownMethods(Count = 1)]
	private void EventDisplaySubtitles(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EventUpdateLayerWeight(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void EnableHipAndShoulderOffsetLayerOverride(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void EventPrepareMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	private void EventEnableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	private void EventDisableObject(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisableObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DoEnableObject(Animator animator, AnimationEventData eventAnimationData, bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "Stop")]
	private void EventStopMovie(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	private void SetParameterValue(Animator animator, string name, AnimationEventValue value, RuntimeAnimatorController target, int targetCycleOffsetHash)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void PushAnimationEventValue(Animator animator, int index, AnimationEventValue value)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void PopAnimationEventValue(Animator animator, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public AnimationEvents()
	{
	}
}
