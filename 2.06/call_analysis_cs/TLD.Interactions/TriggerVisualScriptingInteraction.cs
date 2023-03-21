using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;
using UnityEngine;

namespace TLD.Interactions;

public class TriggerVisualScriptingInteraction : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventHook), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public void PerformInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public TriggerVisualScriptingInteraction()
	{
	}
}
