using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerCollisionExit : AkTriggerBase
{
	public GameObject triggerObject;

	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	private void OnCollisionExit(Collision in_other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerCollisionExit()
	{
	}
}
