using System.Collections.Generic;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 29)]
	public string PickRandomSpawnPointName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetWeather()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 3)]
	public void SetWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void SetRandomWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetLockedWeather()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetTime()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 2)]
	public void SetTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 31)]
	private void SetRandomTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
