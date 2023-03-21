using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheInfoSaveList
{
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	public int m_RockCacheIndex;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public RockCacheInfoSaveList()
	{
	}
}
