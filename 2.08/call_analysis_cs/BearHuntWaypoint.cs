using Cpp2ILInjected.CallAnalysis;

public class BearHuntWaypoint : MissionWaypoint
{
	public float m_ChanceFlee;

	public WeatherStage m_WeatherStage;

	public float m_WeatherTransitionSeconds;

	[CallerCount(Count = 0)]
	public BearHuntWaypoint()
	{
	}
}
