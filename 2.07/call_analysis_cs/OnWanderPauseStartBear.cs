using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseStartBear : StateMachineBehaviour
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public OnWanderPauseStartBear()
	{
	}
}
