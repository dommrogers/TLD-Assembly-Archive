using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpawnDataProxy
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public AiMode m_AiMode;

	public string m_Guid;

	public string m_BaseAiSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SpawnDataProxy()
	{
	}
}
