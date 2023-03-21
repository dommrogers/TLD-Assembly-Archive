using System;
using Cpp2ILInjected.CallAnalysis;

public class SplashEffectPool : EffectPool<SplashEffectType>
{
	[Serializable]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void InternalUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public SplashEffectPool()
	{
		((EffectPool<>)(object)this)._002Ector();
	}
}
