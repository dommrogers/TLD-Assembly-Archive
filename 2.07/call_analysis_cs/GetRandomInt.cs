using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GetRandomInt : StateMachineBehaviour
{
	public int m_RangeMax;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GetRandomInt()
	{
	}
}
