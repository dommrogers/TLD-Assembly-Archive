using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EntityDelayVolume : MonoBehaviour
{
	public float m_EntityDelayFactor;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public EntityDelayVolume()
	{
	}
}
