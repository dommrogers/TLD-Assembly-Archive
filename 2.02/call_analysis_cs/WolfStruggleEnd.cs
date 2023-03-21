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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void EndStruggle(Animator animator)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public WolfStruggleEnd()
	{
	}
}
