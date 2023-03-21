using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpawnRegionSaveData
{
	public Vector3 m_Position;

	public string m_SearializedSpawnRegion;

	public string m_Guid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SpawnRegionSaveData()
	{
	}
}
