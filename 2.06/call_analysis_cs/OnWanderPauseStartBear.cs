using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseStartBear : StateMachineBehaviour
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public OnWanderPauseStartBear()
	{
	}
}
