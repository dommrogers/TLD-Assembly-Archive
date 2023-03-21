using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseStartBear : StateMachineBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimatorStateInfo), Member = "IsName")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
