using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TriggerAnimationCallback : StateMachineBehaviour
{
	public string m_AnimationEventEnterString;

	public float m_NormalizedTime;

	public string m_AnimationEventNormalizedTimeString;

	public bool m_TriggerNormalizedTimeCallbackOnExit;

	public string m_AnimationEventExitString;

	private float m_LastFrameNormalizedTime;

	private bool m_HasTriggeredNormalizedTimeCallback;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[CallsUnknownMethods(Count = 4)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsUnknownMethods(Count = 8)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TriggerAnimationCallback()
	{
	}
}
