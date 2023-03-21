using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionWaypoint : MonoBehaviour
{
	public float m_Radius;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public MissionWaypoint()
	{
	}
}
