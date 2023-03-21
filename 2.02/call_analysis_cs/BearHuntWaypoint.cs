using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearHuntWaypoint : MissionWaypoint
{
	public float m_ChanceFlee;

	public WeatherStage m_WeatherStage;

	public float m_WeatherTransitionSeconds;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BearHuntWaypoint()
	{
	}
}
