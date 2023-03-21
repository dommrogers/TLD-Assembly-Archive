using Cpp2ILInjected.CallAnalysis;

public class WeatherTransitionSaveDataProxy
{
	public bool m_UseUnmanagedWeatherStage;

	public WeatherStage m_UnmanagedWeatherStage;

	public string m_CurrentWeatherSetName;

	public float m_CurrentWeatherSetProgressFrac;

	public string m_CurrentWeatherSetSerialized;

	public int m_CurrentWeatherSetType;

	public int m_PreviousWeatherSetType;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public WeatherTransitionSaveDataProxy()
	{
	}
}
