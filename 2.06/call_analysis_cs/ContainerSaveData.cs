using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ContainerSaveData
{
	public Vector3 m_Position;

	public string m_PrefabName;

	public string m_SearializedContainer;

	public string m_Guid;

	public bool m_NotActive;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ContainerSaveData()
	{
	}
}
