using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ParticleSpawnTrigger : MonoBehaviour
{
	private ParticleSystem m_SpawnedParticleSystem;

	private bool m_ShouldSpawnOnEnter;

	private bool m_ShouldSpawnOnExit;

	private LayerMask m_LayerMask;

	private bool m_AllowRetriggerFromSameObject;

	private int m_PooledParticleCount;

	private int m_CurrentPoolIndex;

	private List<ParticleSystem> m_ParticleSystemPool;

	private HashSet<Collider> m_TriggeredColliders;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "IsAllowedToTrigger")]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "SpawnParticlesAtPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "IsAllowedToTrigger")]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "SpawnParticlesAtPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider collider)
	{
	}

	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsAllowedToTrigger(Collider collider)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool IsValidLayer(int layer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	private ParticleSystem GetNextParticleSystemFromPool()
	{
		return null;
	}

	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void SpawnParticlesAtPosition(Vector3 worldPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ParticleSpawnTrigger()
	{
	}
}
