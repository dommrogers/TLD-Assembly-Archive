using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public class SimpleInteraction : BaseInteraction
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public SimpleInteraction()
	{
	}
}
