using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GetRandomInt : StateMachineBehaviour
{
	public int m_RangeMax;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public GetRandomInt()
	{
	}
}
