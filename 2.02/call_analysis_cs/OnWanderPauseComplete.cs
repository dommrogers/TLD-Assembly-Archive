using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseComplete : StateMachineBehaviour
{
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public OnWanderPauseComplete()
	{
	}
}
