using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheInfoSaveList
{
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	public int m_RockCacheIndex;

	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RockCacheInfoSaveList()
	{
	}
}
