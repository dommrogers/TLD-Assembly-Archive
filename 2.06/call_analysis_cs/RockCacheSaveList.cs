using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheSaveList
{
	public List<RockCacheSaveData> m_SerializedRockCacheList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public RockCacheSaveList()
	{
	}
}
