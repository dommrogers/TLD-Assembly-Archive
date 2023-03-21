using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheInfoSaveList
{
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	public int m_RockCacheIndex;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[CallsUnknownMethods(Count = 14)]
	public RockCacheInfoSaveList()
	{
	}
}
