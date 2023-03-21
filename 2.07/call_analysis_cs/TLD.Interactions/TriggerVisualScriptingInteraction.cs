using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;
using UnityEngine;

namespace TLD.Interactions;

public class TriggerVisualScriptingInteraction : MonoBehaviour
{
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EventHook), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PerformInteraction(BaseInteraction baseInteraction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TriggerVisualScriptingInteraction()
	{
	}
}
