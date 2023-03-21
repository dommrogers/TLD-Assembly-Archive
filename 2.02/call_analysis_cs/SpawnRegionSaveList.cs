using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnRegionSaveList
{
	public List<SpawnRegionSaveData> m_SerializedSpawnRegions;

	public float m_NoPredatorSpawningInVoyageurHours;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public SpawnRegionSaveList()
	{
	}
}
