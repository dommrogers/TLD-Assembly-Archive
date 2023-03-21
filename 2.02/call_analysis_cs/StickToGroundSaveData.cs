using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StickToGroundSaveData
{
	public Vector3 m_Position;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StickToGroundSaveData()
	{
	}
}
