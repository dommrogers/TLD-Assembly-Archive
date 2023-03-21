using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Interactions;

public interface IInteraction
{
	string HoverText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	bool IsEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	bool CanInteract
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void InitializeInteraction();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	void UpdateInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	bool PerformInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void HideInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	GameObject GetInteractiveObject();
}
