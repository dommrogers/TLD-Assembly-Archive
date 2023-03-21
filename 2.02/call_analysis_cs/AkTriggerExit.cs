using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerExit : AkTriggerBase
{
	public GameObject triggerObject;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	private void OnTriggerExit(Collider in_other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerExit()
	{
	}
}
