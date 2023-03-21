using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearHuntWaypoint : MissionWaypoint
{
	public float m_ChanceFlee;

	public WeatherStage m_WeatherStage;

	public float m_WeatherTransitionSeconds;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public BearHuntWaypoint()
	{
	}
}
