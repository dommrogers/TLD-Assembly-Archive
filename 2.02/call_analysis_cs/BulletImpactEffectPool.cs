using System;
using Cpp2ILInjected.CallAnalysis;

public class BulletImpactEffectPool : EffectPool<BulletImpactEffectType>
{
	[Serializable]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public SerializableSpawnGroup()
		{
			((EffectPool<>.SerializableSpawnGroupGeneric)(object)this)._002Ector();
		}
	}

	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void InternalUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectPool<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public BulletImpactEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
