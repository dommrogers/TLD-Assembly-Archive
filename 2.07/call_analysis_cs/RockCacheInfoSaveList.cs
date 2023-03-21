using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheInfoSaveList
{
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	public int m_RockCacheIndex;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RockCacheInfoSaveList()
	{
	}
}
