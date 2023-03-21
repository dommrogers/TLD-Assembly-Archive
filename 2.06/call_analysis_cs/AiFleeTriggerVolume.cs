using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiFleeTriggerVolume : MonoBehaviour
{
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void OnTriggerStay(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AiFleeTriggerVolume()
	{
	}
}
