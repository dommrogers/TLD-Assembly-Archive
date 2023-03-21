using System.Collections.Generic;
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
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsUnknownMethods(Count = 1)]
	private void OnWeatherChanged()
	{
	}

	[CallerCount(Count = 0)]
	public WeatherStageEventListener()
	{
	}
}
