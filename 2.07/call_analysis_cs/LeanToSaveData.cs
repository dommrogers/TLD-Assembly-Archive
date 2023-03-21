using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LeanToSaveData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_Guid;

	public string m_SearializedLeanTo;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LeanToSaveData()
	{
	}
}
