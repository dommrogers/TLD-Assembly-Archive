using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterSourceSaveData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_PrefabName;

	public string m_SearializedWaterSource;

	public string m_Guid;

	public bool m_NotActive;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WaterSourceSaveData()
	{
	}
}
