using System;
using Cpp2ILInjected.CallAnalysis;

public class BulletImpactEffectPool : EffectPool<BulletImpactEffectType>
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
	[CallerCount(Count = 25)]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void InternalUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BulletImpactEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
