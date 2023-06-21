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

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
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
	public HeavyFootstepEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
