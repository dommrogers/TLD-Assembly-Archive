using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorSaveDataProxy
{
	public string m_Guid;

	public Vector3 m_LastSavedPosition;

	public int m_LastFloorIndex;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ElevatorSaveDataProxy()
	{
	}
}
