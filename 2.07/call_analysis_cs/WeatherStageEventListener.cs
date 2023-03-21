using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using UnityEngine;
using UnityEngine.Events;

public class WeatherStageEventListener : MonoBehaviour
{
	private WeatherStage m_WeatherStage;

	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	private UnityEvent<bool> m_WeatherStageActive;

	private WeatherStage m_LastWeatherStage;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnWeatherChanged()
	{
	}

	[CallerCount(Count = 0)]
	public WeatherStageEventListener()
	{
	}
}
