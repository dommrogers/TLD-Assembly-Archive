using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseStartBear : StateMachineBehaviour
{
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OnWanderPauseStartBear()
	{
	}
}
