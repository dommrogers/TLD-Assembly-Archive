using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class WeatherStateConfig
{
	public string m_StateJSONName;

	public TODStateConfig m_DawnColors;

	public TODStateConfig m_MorningColors;

	public TODStateConfig m_MiddayColors;

	public TODStateConfig m_AfternoonColors;

	public TODStateConfig m_DuskColors;

	public TODStateConfig m_NightColors;

	public float m_GrassTintScalar;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WeatherStateConfig()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public WeatherStateConfig(WeatherStateConfig other)
	{
	}
}
