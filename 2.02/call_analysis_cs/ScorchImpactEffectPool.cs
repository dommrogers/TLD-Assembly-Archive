using System;
using Cpp2ILInjected.CallAnalysis;

public class ScorchImpactEffectPool : EffectPool<ScorchImpactEffectType>
{
	[Serializable]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void InternalUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ScorchImpactEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
