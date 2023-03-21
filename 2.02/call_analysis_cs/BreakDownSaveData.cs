using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BreakDownSaveData
{
	public Vector3 m_Position;

	public bool m_HasBeenBrokenDown;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BreakDownSaveData()
	{
	}
}
