using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FireSaveData
{
	public Vector3 m_Position;

	public bool m_InWoodStove;

	public string m_PrefabName;

	public string m_SearializedFire;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public FireSaveData()
	{
	}
}
