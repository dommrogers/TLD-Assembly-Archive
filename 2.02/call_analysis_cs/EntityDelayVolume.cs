using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EntityDelayVolume : MonoBehaviour
{
	public float m_EntityDelayFactor;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetMovementSpeedScalar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetMovementSpeedScalar")]
	[CallsDeduplicatedMethods(Count = 3)]
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
