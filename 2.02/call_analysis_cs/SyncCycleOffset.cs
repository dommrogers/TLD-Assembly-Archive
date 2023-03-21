using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncCycleOffset : StateMachineBehaviour
{
	public string m_ParameterName;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SyncCycleOffset()
	{
	}
}
