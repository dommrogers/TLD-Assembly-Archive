using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerEnter : AkTriggerBase
{
	public GameObject triggerObject;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void OnTriggerEnter(Collider in_other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerEnter()
	{
	}
}
