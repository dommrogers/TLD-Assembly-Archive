using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public class SimpleInteraction : BaseInteraction
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public SimpleInteraction()
	{
	}
}
