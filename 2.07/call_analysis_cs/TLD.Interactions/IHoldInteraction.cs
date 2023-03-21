using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public interface IHoldInteraction : IInteraction
{
	bool IsActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	bool CanCancel
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	float NormalizedProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool PerformHold();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void CancelHold();
}
