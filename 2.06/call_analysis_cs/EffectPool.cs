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

		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public ParticleSystemInfo(EffectHandle effectHandle, bool hasParticleSystem, float duration, bool isLooping, ParticleSystem[] particleSystems)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
		[CallsUnknownMethods(Count = 4)]
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
		[CallerCount(Count = 1)]
		public T GetEffectType()
		{
			return (T)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
		public int GetInstancesCount()
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
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
	[CallerCount(Count = 101224)]
	protected abstract SerializableSpawnGroupGeneric[] GetSerializedGroups();

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void LoadEffects()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void UnLoadEffects()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[DeduplicatedMethod]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateWatchedEmitters()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 6)]
	private EffectHandle ActivateInstance(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private EffectHandle GetEffectHandleFromGroupAndInstanceIndex(int indexGroup, int indexInstance, int poolHashCode, T effectType)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 11)]
	private InstanceInfo CreateInstanceInfo(EffectHandle instanceHandle, SerializableSpawnGroupGeneric serializableSpawnGroup)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void DeleteInstanceInfo(InstanceInfo instanceInfo)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private InstanceInfo GetInstanceInfo(EffectHandle effectHandle, List<SpawnGroup> groups)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private InstanceInfo FindAvailableInstanceInfo(SpawnGroup spawnGroup, T effectType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private ParticleSystemInfo ComputeParticleSystemInfo(InstanceInfo instanceInfo)
	{
		return default(ParticleSystemInfo);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	private SpawnGroup CreateSpawnGroup(SerializableSpawnGroupGeneric serializableSpawnGroup, int poolHashCode, int groupIndex)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteSpawnGroup(SpawnGroup spawnGroup)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private SpawnGroup GetSpawnGroup(T effectType, List<SpawnGroup> groups)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	protected EffectPool()
	{
	}
}
