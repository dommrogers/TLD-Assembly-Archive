using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheSaveList
{
	public List<RockCacheSaveData> m_SerializedRockCacheList;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RockCacheSaveList()
	{
	}
}
