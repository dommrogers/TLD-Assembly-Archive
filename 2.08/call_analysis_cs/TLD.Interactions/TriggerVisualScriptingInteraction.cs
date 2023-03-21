using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;
using UnityEngine;

namespace TLD.Interactions;

public class TriggerVisualScriptingInteraction : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventHook), Member = ".ctor")]
	[Calls(Type = typeof(EventBus), Member = "Trigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PerformInteraction(BaseInteraction baseInteraction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TriggerVisualScriptingInteraction()
	{
	}
}
