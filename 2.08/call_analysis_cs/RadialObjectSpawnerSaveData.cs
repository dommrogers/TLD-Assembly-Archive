using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RadialObjectSpawnerSaveData
{
	public float m_GameHourTimeToRespawn;

	public Vector3 m_Position;

	public string m_Guid;

	public bool m_HasSpawned;

	public Vector3[] m_SpawnedObjectPositions;

	public Quaternion[] m_SpawnedObjectRotations;

	public string[] m_SpawnedPrefabNames;

	public bool[] m_SpawnedObjectUnlockForDetailMapStates;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public RadialObjectSpawnerSaveData()
	{
	}
}
