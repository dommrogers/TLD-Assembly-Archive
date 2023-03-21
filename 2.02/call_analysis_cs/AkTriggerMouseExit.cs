using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerMouseExit : AkTriggerBase
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseExit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerMouseExit()
	{
	}
}
