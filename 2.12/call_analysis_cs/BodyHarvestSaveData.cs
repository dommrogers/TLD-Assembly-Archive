using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyHarvestSaveData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_PrefabName;

	public string m_SerializedBodyHarvest;

	public string m_Guid;

	public string m_MissionId;

	public bool m_PreventSpawning;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BodyHarvestSaveData()
	{
	}
}
