using Cpp2ILInjected.CallAnalysis;

public class WeatherSetDataInstanceSaveData
{
	public int m_CurrentIndex;

	public float m_CurrentStageElapsedTime;

	public float[] m_StageDurations;

	public float[] m_StageTransitionTimes;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public WeatherSetDataInstanceSaveData()
	{
	}
}
