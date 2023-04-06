using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Condition_AnimatorInState : TLD_Condition
{
	public BBParameter<int> layer;

	public BBParameter<string> state;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_Condition), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Condition_AnimatorInState()
	{
	}
}
