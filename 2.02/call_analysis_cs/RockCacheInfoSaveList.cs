using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class RockCacheInfoSaveList
{
	public List<RockCacheInfo> m_SerializedRockCacheInfoList;

	public List<RockCacheDestroyedInfo> m_SerializedDestroyedRockCacheInScene;

	public int m_RockCacheIndex;

	[CalledBy(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public RockCacheInfoSaveList()
	{
	}
}
