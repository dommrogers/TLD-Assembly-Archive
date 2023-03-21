using Cpp2ILInjected.CallAnalysis;

public class HuntedPart2WaypointControllerSaveData
{
	public int m_CurrentWaypoint;

	public int m_CurrentWeatherStage;

	public HuntedPart2WaypointControllerState m_State;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HuntedPart2WaypointControllerSaveData()
	{
	}
}
