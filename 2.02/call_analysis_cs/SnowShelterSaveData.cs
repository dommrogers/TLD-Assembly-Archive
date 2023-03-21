using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowShelterSaveData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_Guid;

	public string m_SearializedSnowShelter;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SnowShelterSaveData()
	{
	}
}
