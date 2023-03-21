using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HuntedPart2Waypoint : MissionWaypoint
{
	public enum WaypointType
	{
		AttackOnDetect,
		FleeOnDetect,
		RunThrough,
		FinalAmbush
	}

	public WaypointType m_WaypointType;

	public bool m_IncrementWeatherStage;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public HuntedPart2Waypoint()
	{
	}
}
