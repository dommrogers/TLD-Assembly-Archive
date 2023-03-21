using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Events;

public class WeatherStageChangeEvent : GameEvent
{
	[NonSerialized]
	public WeatherStage m_CurrentWeatherStage;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = ".ctor")]
	public WeatherStageChangeEvent()
	{
	}
}
