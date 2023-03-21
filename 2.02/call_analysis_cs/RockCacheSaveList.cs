using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheSaveList
{
	public List<RockCacheSaveData> m_SerializedRockCacheList;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public RockCacheSaveList()
	{
	}
}
