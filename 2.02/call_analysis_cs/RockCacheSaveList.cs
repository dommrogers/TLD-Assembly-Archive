using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheSaveList
{
	public List<RockCacheSaveData> m_SerializedRockCacheList;

	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public RockCacheSaveList()
	{
	}
}
