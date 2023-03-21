using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 35)]
	public string PickRandomSpawnPointName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool ShouldSetWeather()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 4)]
	public void SetWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ChooseNextWeatherSet")]
	[CallsUnknownMethods(Count = 3)]
	private void SetRandomWeather()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
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
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void SetRandomTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "TryParseTOD")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 3)]
	private void SetLockedTime()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public StartSettings()
	{
	}
}
