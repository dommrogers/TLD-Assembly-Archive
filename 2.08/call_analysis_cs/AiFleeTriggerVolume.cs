using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiFleeTriggerVolume : MonoBehaviour
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnTriggerStay(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AiFleeTriggerVolume()
	{
	}
}
