using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnRegionSaveList
{
	public List<SpawnRegionSaveData> m_SerializedSpawnRegions;

	public float m_NoPredatorSpawningInVoyageurHours;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SpawnRegionSaveList()
	{
	}
}
