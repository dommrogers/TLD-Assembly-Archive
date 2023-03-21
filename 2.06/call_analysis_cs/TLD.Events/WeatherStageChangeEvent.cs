using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Events;

public class WeatherStageChangeEvent : GameEvent
{
	[NonSerialized]
	public WeatherStage m_CurrentWeatherStage;

	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public WeatherStageChangeEvent()
	{
	}
}
