using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MapElementRemovalData
{
	public string m_RegionName;

	public string m_LocationLocID;

	public Vector3 m_WorldPos;

	public float m_RemovalTime;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MapElementRemovalData()
	{
	}
}
