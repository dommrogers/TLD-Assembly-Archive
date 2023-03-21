using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Interactions;

public interface IInteraction
{
	string HoverText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	bool IsEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	bool CanInteract
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	void InitializeInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void UpdateInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	bool PerformInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	void HideInteraction();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	GameObject GetInteractiveObject();
}
