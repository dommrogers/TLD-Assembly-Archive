using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerExit : AkTriggerBase
{
	public GameObject triggerObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
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
