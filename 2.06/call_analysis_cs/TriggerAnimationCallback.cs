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
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallsUnknownMethods(Count = 5)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(PlayerAnimation), Member = "TriggerCallback")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TriggerAnimationCallback()
	{
	}
}
