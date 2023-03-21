using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnRegionSaveList
{
	public List<SpawnRegionSaveData> m_SerializedSpawnRegions;

	public float m_NoPredatorSpawningInVoyageurHours;

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SpawnRegionSaveList()
	{
	}
}
