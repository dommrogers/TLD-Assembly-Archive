using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Interactions;

public interface IInteraction
{
	string HoverText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	bool IsEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	bool CanInteract
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void InitializeInteraction();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	void UpdateInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	bool PerformInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void HideInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	GameObject GetInteractiveObject();
}
