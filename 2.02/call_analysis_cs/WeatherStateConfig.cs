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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public WeatherStateConfig()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public WeatherStateConfig(WeatherStateConfig other)
	{
	}
}
