using System;
using Cpp2ILInjected.CallAnalysis;

public class HeavyFootstepEffectPool : EffectPool<HeavyFootstepEffectType>
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

	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void InternalUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public HeavyFootstepEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
