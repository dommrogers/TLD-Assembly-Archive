using Cpp2ILInjected.CallAnalysis;

public class WeatherSaveDataProxy
{
	public float m_PrevBodyTempProxy;

	public float m_TempHighProxy;

	public float m_TempLowProxy;

	public WeatherStage m_WeatherStageProxy;

	public float m_UniStormElapsedHoursProxy;

	public float m_UniStormNextWeatherChangeElapsedHoursProxy;

	public bool m_UseMinAirTemperature;

	public int m_MinAirTemperature;

	public TODBlendState m_LastTimeOfDay;

	public int m_BaseTemperatureAccumulatorForTimeOfDay;

	public int m_WindchillAccumulatorForTimeOfDay;

	public int m_TemperatureCountForTimeOfDay;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WeatherSaveDataProxy()
	{
	}
}
