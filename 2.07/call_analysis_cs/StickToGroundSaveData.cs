using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StickToGroundSaveData
{
	public Vector3 m_Position;

	public string m_Guid;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public StickToGroundSaveData()
	{
	}
}
