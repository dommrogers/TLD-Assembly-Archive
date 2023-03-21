using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTriggerEnable : AkTriggerBase
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AkTriggerEnable()
	{
	}
}
