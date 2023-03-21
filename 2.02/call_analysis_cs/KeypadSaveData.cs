using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KeypadSaveData
{
	public bool m_Locked;

	public Vector3 m_Position;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public KeypadSaveData()
	{
	}
}
