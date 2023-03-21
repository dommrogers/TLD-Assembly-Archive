using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerCollisionExit : AkTriggerBase
{
	public GameObject triggerObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Collision), Member = "get_gameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
