using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Condition_AnimatorInState : TLD_Condition
{
	public BBParameter<int> layer;

	public BBParameter<string> state;

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[Calls(Type = typeof(TLD_Condition), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Condition_AnimatorInState()
	{
	}
}
