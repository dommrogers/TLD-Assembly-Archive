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

	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	private void DoEnter(Animator animator, AnimatorStateInfo stateInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 4)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "ResetRemainingEventsForInstigator")]
	[Calls(Type = typeof(InterfaceManager), Member = "RestorePanelsAfterSubtitle")]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPrepareMovie")]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateUpdate")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateExit")]
	[Calls(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(Utils), Member = "UpdateSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	private void DoUpdate(AnimatorStateInfo stateInfo, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "TriggerCallback")]
	[Calls(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventHide")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "EnableHipAndShoulderOffsetLayerOverride")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventUpdateLayerWeight")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPrepareMovie")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStopMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlayMovie")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[Calls(Type = typeof(AnimationEvents), Member = "EventShow")]
	private void MaybeTriggerEvent(Animator animator, int index, float frame)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[Calls(Type = typeof(AnimationEventStack), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CalledBy(Type = typeof(AnimationEvents), Member = "OnStateEnter")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "ProcessEndFrameEvents")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AnimationEvents), Member = "GetCurrentValueFromList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResetEventStacks(Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "ResetEventStacks")]
	private AnimationEventValue GetCurrentValueFromList(List<Animator> list, Animator animator, int hash, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
		return default(AnimationEventValue);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void EventHide(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	private void EventShow(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventPlay")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool IsChildOfFP(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnPlay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	private void EventPlay(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[Calls(Type = typeof(AnimationEvents), Member = "IsChildOfFP")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	[Calls(Type = typeof(PlayEventMonitor), Member = "OnStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void EventStop(Animator animator, AnimationEventData eventAnimationData)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
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

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "EnableRenderers")]
	[Calls(Type = typeof(Utils), Member = "DisableRenderers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "TryGetFXObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[Calls(Type = typeof(Animator), Member = "Update")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "get_runtimeAnimatorController")]
	private void SetParameterValue(Animator animator, string name, AnimationEventValue value, RuntimeAnimatorController target, int targetCycleOffsetHash)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	private void PushAnimationEventValue(Animator animator, int index, AnimationEventValue value)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationEventData), Member = "Key")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationEvents), Member = "SetParameterValue")]
	private void PopAnimationEventValue(Animator animator, int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	public AnimationEvents()
	{
	}
}
