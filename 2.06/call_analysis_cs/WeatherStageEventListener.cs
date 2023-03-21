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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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
