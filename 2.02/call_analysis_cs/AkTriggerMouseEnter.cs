using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerMouseEnter : AkTriggerBase
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseEnter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerMouseEnter()
	{
	}
}
