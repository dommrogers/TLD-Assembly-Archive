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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(EffectHandle other)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static bool operator ==(EffectHandle a, EffectHandle b)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static bool operator !=(EffectHandle a, EffectHandle b)
		{
			return false;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ParticleSystem), Member = "IsAlive")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public bool IsAlive()
		{
			return false;
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
			return default(T);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		public int GetInstancesCount()
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		public GameObject GetPrefabObject()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	protected abstract SerializableSpawnGroupGeneric[] GetSerializedGroups();

	[DeduplicatedMethod]
	[CalledBy(TypeFullName = "EffectPoolManager.<Start>d__16", Member = "MoveNext")]
	[CalledBy(Type = typeof(TestEffectPool), Member = "Awake")]
	[CalledBy(Type = typeof(TestEffectPool), Member = "Update")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(TestEffectPool), Member = "Update")]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayWaterSplashVFX")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public bool SpawnUntilParticlesDone(T effectType, Vector3 position, Quaternion rotation)
	{
		return false;
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveWatchedEmitter(EffectHandle effectHandle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNonLoopingParticleEffect(T effectType)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private EffectHandle ActivateInstance(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void ReleaseInstance(EffectHandle effectHandle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int GetGroupIndexFromEffectHandle(EffectHandle id)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private int GetInstanceIndexFromEffectHandle(EffectHandle effectHandle)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private EffectHandle GetEffectHandleFromGroupAndInstanceIndex(int indexGroup, int indexInstance, int poolHashCode, T effectType)
	{
		return default(EffectHandle);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private InstanceInfo GetInstanceInfo(EffectHandle effectHandle, List<SpawnGroup> groups)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DeleteSpawnGroup(SpawnGroup spawnGroup)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private SpawnGroup GetSpawnGroup(T effectType, List<SpawnGroup> groups)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(ArrowImpactEffectPool), Member = ".ctor")]
	[CalledBy(Type = typeof(BulletImpactEffectPool), Member = ".ctor")]
	[CalledBy(Type = typeof(HeavyFootstepEffectPool), Member = ".ctor")]
	[CalledBy(Type = typeof(ScorchImpactEffectPool), Member = ".ctor")]
	[CalledBy(Type = typeof(SplashEffectPool), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected EffectPool()
	{
	}
}
