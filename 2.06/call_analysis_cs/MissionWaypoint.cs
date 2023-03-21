using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionWaypoint : MonoBehaviour
{
	public float m_Radius;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MissionWaypoint()
	{
	}
}
