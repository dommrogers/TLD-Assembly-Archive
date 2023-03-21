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

	[Calls(Type = typeof(ShowHands), Member = "DoAction")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ShowHands), Member = "DoAction")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ShowHands), Member = "OnStateMachineEnter")]
	[CalledBy(Type = typeof(ShowHands), Member = "OnStateEnter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "HideHands")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowHands")]
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
