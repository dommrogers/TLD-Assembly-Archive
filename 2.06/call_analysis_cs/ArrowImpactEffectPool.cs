using System;
using Cpp2ILInjected.CallAnalysis;

public class ArrowImpactEffectPool : EffectPool<ArrowImpactEffectType>
{
	[Serializable]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[CallerCount(Count = 0)]
		public SerializableSpawnGroup()
		{
			((EffectPool<>.SerializableSpawnGroupGeneric)(object)this)._002Ector();
		}
	}

	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 61)]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void InternalUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectPool<>), Member = ".ctor")]
	public ArrowImpactEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
