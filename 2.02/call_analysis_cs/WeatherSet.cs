using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WeatherSet : MonoBehaviour
{
	private static WeatherSetInstanceSaveData m_WeatherSetInstanceSaveData;

	private const float MIN_HOURS_FOR_REPORT_RESULT = 16f;

	private const float NIGHT_WEIGHT_REDUCTION = 0.5f;

	public string m_CustomTypeName;

	public WeatherStage m_CharacterizingType;

	public int m_SameTypeSelectionWeight;

	public WeatherSetStage[] m_WeatherStages;

	public int m_ClearAsNextSelectionWeight;

	public int m_CloudyAsNextSelectionWeight;

	public int m_LightSnowAsNextSelectionWeight;

	public int m_HeavySnowAsNextSelectionWeight;

	public int m_LightFogAsNextSelectionWeight;

	public int m_DenseFogAsNextSelectionWeight;

	public int m_ToxicFogAsNextSelectionWeight;

	public int m_BlizzardAsNextSelectionWeight;

	public bool m_IsDefaultSet;

	public int m_CurrentIndex;

	private float m_CurrentSetDuration;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void Initialize(string name, WeatherSetStage[] stages)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	public void Prepare()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CallsUnknownMethods(Count = 11)]
	public void Activate(float startAtFrac = 0f, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ForceStep")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Activate")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 27)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStateAndBlendDirectly")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherTransition), Member = "MaybePlayStinger")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WeatherSet), Member = "GetDebugString")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Serialize")]
	[CallsUnknownMethods(Count = 9)]
	public float GetProgressFrac()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceTransitionToWeatherStage")]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceTransitionToWeatherStage")]
	public void ForceStep(int forceIndex)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "GetDebugString")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[Calls(Type = typeof(WeatherSetStage), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(WeatherSet), Member = "GetProgressFrac")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void WeatherSetComplete()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public float ReportHoursOfBlizzardForDay(int reportDay)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void RefreshDuration()
	{
	}

	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSet), Member = "GetDowngradedWeatherType")]
	[Calls(Type = typeof(WeatherSet), Member = "GetDowngradedWeatherType")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	private WeatherStage GetBlendedWeatherPair(WeatherStage ws1, WeatherStage ws2, bool allowSubordination)
	{
		return default(WeatherStage);
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[CalledBy(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[CallerCount(Count = 2)]
	private WeatherStage GetDowngradedWeatherType(WeatherStage ws)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	private WeatherStage GetMoreSeriousWeatherType(WeatherStage ws1, WeatherStage ws2)
	{
		return default(WeatherStage);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WeatherSet()
	{
	}
}
