using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WolfStruggleEnd : StateMachineBehaviour
{
	public float m_StruggleEndSeconds;

	private float m_StruggleEndTime;

	private bool m_Update;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void EndStruggle(Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public WolfStruggleEnd()
	{
	}
}
