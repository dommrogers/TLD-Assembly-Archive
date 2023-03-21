using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
	public int m_StartTimeHour;

	public int m_StartTimeMinutes;

	public bool m_ForceStartWeather;

	public WeatherStage m_StartWeather;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	public void SetStartTimeAndWeather()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 2)]
	private void SetWeather()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerSpawn()
	{
	}
}
