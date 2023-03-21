using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public interface IHoldInteraction : IInteraction
{
	bool IsActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	bool CanCancel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	float NormalizedProgress
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool PerformHold();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void CancelHold();
}
