using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerMouseExit : AkTriggerBase
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
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
