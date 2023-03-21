using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncCycleOffset : StateMachineBehaviour
{
	public string m_ParameterName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SyncCycleOffset()
	{
	}
}
