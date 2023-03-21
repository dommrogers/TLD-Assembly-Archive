using Cpp2ILInjected.CallAnalysis;

public class PlayerGameStatsProxy
{
	public float m_CaloriesBurned;

	public float m_CaloriesEaten;

	public float m_BodyTempHigh;

	public float m_BodyTempLow;

	public float m_DistanceTravelledDay;

	public float m_DistanceTravelledNight;

	public float m_ConditionGained;

	public float m_ConditionLost;

	public float m_CaloriesExpendedToday;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayerGameStatsProxy()
	{
	}
}
