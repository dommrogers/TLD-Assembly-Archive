using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public interface IHoldInteraction : IInteraction
{
	bool IsActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	bool CanCancel
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	float NormalizedProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool PerformHold();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void CancelHold();
}
