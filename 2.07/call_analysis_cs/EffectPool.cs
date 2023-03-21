using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class EffectPool<T> : MonoBehaviour
{
	public struct EffectHandle
	{
		private readonly int m_Value;

		public readonly int m_PoolHashCode;

		public readonly T m_EffectType;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public EffectHandle(int id, int poolHashCode, T effectType)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool Equals(EffectHandle other)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public static bool operator ==(EffectHandle a, EffectHandle b)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static bool operator !=(EffectHandle a, EffectHandle b)
		{
			return default(bool);
		}
	}

	private class InstanceInfo
	{
		public readonly EffectHandle m_InstanceHandle;

		public GameObject m_Instance;

		public bool m_IsActive;

		public ParticleSystemInfo m_ParticleSystemInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public InstanceInfo(EffectHandle instanceHandle)
		{
		}
	}

	private struct ParticleSystemInfo
	{
		public readonly EffectHandle m_EffectHandle;

		public readonly bool m_IsLooping;

		public readonly float m_Duration;

		public readonly bool m_HasParticleSystem;

		private readonly ParticleSystem[] m_ParticleSystems;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public ParticleSystemInfo(EffectHandle effectHandle, bool hasParticleSystem, float duration, bool isLooping, ParticleSystem[] particleSystems)
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 2)]
		public bool IsAlive()
		{
			return default(bool);
		}
	}

	public class SerializableSpawnGroupGeneric
	{
		public int m_InstancesCount;

		public GameObject m_PrefabObject;

		public T m_EffectType;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public T GetEffectType()
		{
			return (T)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		public int GetInstancesCount()
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		public GameObject GetPrefabObject()
		{
			return null;
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public SerializableSpawnGroupGeneric()
		{
		}
	}

	private class SpawnGroup
	{
		public List<InstanceInfo> m_Instances;

		public int m_InstancesCount;

		public readonly T m_EffectType;

		public readonly int m_PoolHashCode;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public SpawnGroup(T effectType, int poolHashCode)
		{
		}
	}

	private const int MAX_INSTANCES_PER_SPAWNGROUP = 1000;

	private const int INVALID_ID = -1;

	private static readonly EffectHandle INVALID_HANDLE;

	private List<SpawnGroup> m_EffectGroups;

	private List<ParticleSystemInfo> m_WatchedEmitters;

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract SerializableSpawnGroupGeneric[] GetSerializedGroups();

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void LoadEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public void UnLoadEffects()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public bool SpawnUntilParticlesDone(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EffectHandle Spawn(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void DeSpawn(EffectHandle effectHandle)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected virtual void InternalUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateWatchedEmitters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void RemoveWatchedEmitter(EffectHandle effectHandle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNonLoopingParticleEffect(T effectType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private EffectHandle ActivateInstance(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	private void ReleaseInstance(EffectHandle effectHandle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int GetGroupIndexFromEffectHandle(EffectHandle id)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private int GetInstanceIndexFromEffectHandle(EffectHandle effectHandle)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private EffectHandle GetEffectHandleFromGroupAndInstanceIndex(int indexGroup, int indexInstance, int poolHashCode, T effectType)
	{
		return default(EffectHandle);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 9)]
	private InstanceInfo CreateInstanceInfo(EffectHandle instanceHandle, SerializableSpawnGroupGeneric serializableSpawnGroup)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteInstanceInfo(InstanceInfo instanceInfo)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private InstanceInfo GetInstanceInfo(EffectHandle effectHandle, List<SpawnGroup> groups)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private InstanceInfo FindAvailableInstanceInfo(SpawnGroup spawnGroup, T effectType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private ParticleSystemInfo ComputeParticleSystemInfo(InstanceInfo instanceInfo)
	{
		return default(ParticleSystemInfo);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private SpawnGroup CreateSpawnGroup(SerializableSpawnGroupGeneric serializableSpawnGroup, int poolHashCode, int groupIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void DeleteSpawnGroup(SpawnGroup spawnGroup)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	private SpawnGroup GetSpawnGroup(T effectType, List<SpawnGroup> groups)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	protected EffectPool()
	{
	}
}
