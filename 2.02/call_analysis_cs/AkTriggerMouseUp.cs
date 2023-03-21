using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerMouseUp : AkTriggerBase
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMouseUp()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AkTriggerMouseUp()
	{
	}
}
