using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class OnWanderPauseComplete : StateMachineBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public OnWanderPauseComplete()
	{
	}
}
