using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheSaveData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_Guid;

	public string m_SearializedRockCache;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RockCacheSaveData()
	{
	}
}
