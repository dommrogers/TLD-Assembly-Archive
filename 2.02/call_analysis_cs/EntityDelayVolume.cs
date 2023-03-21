using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EntityDelayVolume : MonoBehaviour
{
	public float m_EntityDelayFactor;

	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetMovementSpeedScalar")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetMovementSpeedScalar")]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerExit(Collider other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public EntityDelayVolume()
	{
	}
}
