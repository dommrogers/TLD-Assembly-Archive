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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override int GetHashCode()
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(EffectHandle other)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
		[CallsUnknownMethods(Count = 5)]
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
		[CallerCount(Count = 7)]
		public int GetInstancesCount()
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		public GameObject GetPrefabObject()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetGroupIndexFromEffectHandle(EffectHandle id)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	private InstanceInfo CreateInstanceInfo(EffectHandle instanceHandle, SerializableSpawnGroupGeneric serializableSpawnGroup)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteInstanceInfo(InstanceInfo instanceInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private InstanceInfo GetInstanceInfo(EffectHandle effectHandle, List<SpawnGroup> groups)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	private InstanceInfo FindAvailableInstanceInfo(SpawnGroup spawnGroup, T effectType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	private ParticleSystemInfo ComputeParticleSystemInfo(InstanceInfo instanceInfo)
	{
		return default(ParticleSystemInfo);
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private SpawnGroup GetSpawnGroup(T effectType, List<SpawnGroup> groups)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract SerializableSpawnGroupGeneric[] GetSerializedGroups();

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public void LoadEffects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void UnLoadEffects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 20)]
	public bool SpawnUntilParticlesDone(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public EffectHandle Spawn(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DeSpawn(EffectHandle effectHandle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void InternalUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateWatchedEmitters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void RemoveWatchedEmitter(EffectHandle effectHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNonLoopingParticleEffect(T effectType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[DeduplicatedMethod]
	private EffectHandle ActivateInstance(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 11)]
	private void ReleaseInstance(EffectHandle effectHandle)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	protected EffectPool()
	{
	}
}
