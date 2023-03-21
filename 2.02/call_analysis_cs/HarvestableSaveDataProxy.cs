using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HarvestableSaveDataProxy
{
	public Vector3 m_Position;

	public bool m_Harvested;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public HarvestableSaveDataProxy()
	{
	}
}
