using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MissionWaypoint : MonoBehaviour
{
	public float m_Radius;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MissionWaypoint()
	{
	}
}
