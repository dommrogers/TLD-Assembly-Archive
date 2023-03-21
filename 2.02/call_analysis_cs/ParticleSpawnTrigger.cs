using System;
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
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 19)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "IsAllowedToTrigger")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "SpawnParticlesAtPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "IsAllowedToTrigger")]
	[Calls(Type = typeof(ParticleSpawnTrigger), Member = "SpawnParticlesAtPosition")]
	private void OnTriggerExit(Collider collider)
	{
	}

	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsAllowedToTrigger(Collider collider)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool IsValidLayer(int layer)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private ParticleSystem GetNextParticleSystemFromPool()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(ParticleSpawnTrigger), Member = "OnTriggerExit")]
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
