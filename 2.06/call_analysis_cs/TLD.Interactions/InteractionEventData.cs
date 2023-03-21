using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Interactions;

public class InteractionEventData
{
	public IInteraction interaction;

	public GameObject interactionObject;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public InteractionEventData()
	{
	}
}
