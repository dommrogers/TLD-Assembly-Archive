using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BrokenIceSaveDataProxy
{
	public Vector2 m_Position;

	public float m_Radius;

	public float m_PlacementDay;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BrokenIceSaveDataProxy()
	{
	}
}
