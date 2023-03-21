using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiFleeTriggerVolume : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerStay(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AiFleeTriggerVolume()
	{
	}
}
