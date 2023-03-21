using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ShowHands : StateMachineBehaviour
{
	public enum Action
	{
		Show,
		Hide,
		DoNothing
	}

	public Action m_ActionOnEnter;

	public Action m_ActionOnExit;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShowHands), Member = "DoAction")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShowHands), Member = "DoAction")]
	public override void OnStateMachineEnter(Animator animator, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void OnStateMachineExit(Animator animator, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CalledBy(Type = typeof(ShowHands), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(ShowHands), Member = "OnStateMachineEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void DoAction(Action action)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ShowHands()
	{
	}
}
