using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
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

	public int m_WeatherElectrostaticFogWeight;

	public int m_TimeOfDayDawnWeight;

	public int m_TimeOfDayMorningWeight;

	public int m_TimeOfDayAfternoonWeight;

	public int m_TimeOfDayDuskWeight;

	public int m_TimeOfDayNightWeight;

	public GameplayTag m_ForceMorningStartTag;

	private int[] m_WeatherWeights;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 22)]
	public string PickRandomSpawnPointName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetWeather()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetWeather()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 3)]
	private void SetRandomWeather()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallerCount(Count = 0)]
	private void SetLockedWeather()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetTime()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	public void SetTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 11)]
	private void SetRandomTime()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	private void SetLockedTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartSettings()
	{
	}
}
