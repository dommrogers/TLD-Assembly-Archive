using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
	public int m_StartTimeHour;

	public int m_StartTimeMinutes;

	public bool m_ForceStartWeather;

	public WeatherStage m_StartWeather;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 2)]
	public void SetStartTimeAndWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 1)]
	private void SetTime()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallerCount(Count = 0)]
	private void SetWeather()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerSpawn()
	{
	}
}
