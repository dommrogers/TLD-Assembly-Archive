using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BaseAiData
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_PrefabName;

	public string m_BaseAiSerialized;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BaseAiData()
	{
	}
}
