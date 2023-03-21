using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartSettings : MonoBehaviour
{
	public bool m_RandomSpawning;

	public bool m_RandomWeather;

	public bool m_RandomTimeOfDay;

	public bool m_LockWeather;

	public bool m_LockTimeOfDay;

	public WeatherStage m_LockedWeather;

	public string m_LockedTimeOfDay;

	public int m_WeatherClearWeight;

	public int m_WeatherCloudyWeight;

	public int m_WeatherLightSnowWeight;

	public int m_WeatherHeavySnowWeight;

	public int m_WeatherBlizzardWeight;

	public int m_WeatherLightFogWeight;

	public int m_WeatherDenseFogWeight;

	public int m_TimeOfDayDawnWeight;

	public int m_TimeOfDayMorningWeight;

	public int m_TimeOfDayAfternoonWeight;

	public int m_TimeOfDayDuskWeight;

	public int m_TimeOfDayNightWeight;

	private int[] m_WeatherWeights;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallerCount(Count = 0)]
	public string PickRandomSpawnPointName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetWeather()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	public void SetWeather()
	{
	}

	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private void SetRandomWeather()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 2)]
	private void SetLockedWeather()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetTime()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void SetTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 31)]
	private void SetRandomTime()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	private void SetLockedTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StartSettings()
	{
	}
}
