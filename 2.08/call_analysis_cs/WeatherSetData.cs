using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class WeatherSetData : ScriptableObject
{
	public delegate void WeatherStageChangedEvent(WeatherSetStage current);

	private static WeatherSetDataInstanceSaveData m_WeatherSetInstanceSaveData;

	private const float MIN_HOURS_FOR_REPORT_RESULT = 16f;

	private const float NIGHT_WEIGHT_REDUCTION = 0.5f;

	private const int DEACTIVATED_INDEX = -2;

	public string m_CustomTypeName;

	public WeatherStage m_CharacterizingType;

	public int m_SameTypeSelectionWeight;

	public WeatherSetStage[] m_WeatherStages;

	public List<WeatherStage> m_UpgradedWeatherTypes;

	public WeatherStage m_DowngradedWeatherType;

	public int m_ClearAsNextSelectionWeight;

	public int m_CloudyAsNextSelectionWeight;

	public int m_LightSnowAsNextSelectionWeight;

	public int m_HeavySnowAsNextSelectionWeight;

	public int m_LightFogAsNextSelectionWeight;

	public int m_DenseFogAsNextSelectionWeight;

	public int m_ToxicFogAsNextSelectionWeight;

	public int m_BlizzardAsNextSelectionWeight;

	public int m_ElectrostaticFogAsNextSelectionWeight;

	public bool m_IsDefaultSet;

	public static WeatherStageChangedEvent OnWeatherStageChanged;

	public int m_CurrentIndex;

	private float m_CurrentSetDuration;

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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_weather")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	public void Prepare()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ActivateWeatherSet")]
	public void Activate(float startAtFrac = 0f, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[CallsUnknownMethods(Count = 2)]
	public void Deactivate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ForceStep")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "UpdateWeatherSet")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Activate")]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Update")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateWeatherSet()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherTransition), Member = "Serialize")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetDebugString")]
	[CallerCount(Count = 2)]
	public float GetProgressFrac()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceNextWeatherStage")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceTransitionToWeatherStage")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "ForceTransitionToWeatherStage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public void ForceStep(int forceIndex)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetProgressFrac")]
	[Calls(Type = typeof(WeatherSetStage), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CalledBy(Type = typeof(WeatherTransition), Member = "GetDebugString")]
	[CallsUnknownMethods(Count = 2)]
	public string GetDebugString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void WeatherSetComplete()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AlmanacGridItem), Member = "SetUpGridItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	public float ReportHoursOfBlizzardForDay(int reportDay)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshDuration()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportWeatherForDay")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportWeatherForDay")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportWeatherForDay")]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WeatherSetData), Member = "GetDowngradedWeatherType")]
	private WeatherStage GetBlendedWeatherPair(WeatherStage ws1, WeatherStage ws2, bool allowSubordination)
	{
		return default(WeatherStage);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "GetBlendedWeatherPair")]
	private WeatherStage GetDowngradedWeatherType(WeatherStage ws)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "ChooseWeatherSetOfType")]
	[CallsUnknownMethods(Count = 2)]
	private WeatherStage GetMoreSeriousWeatherType(WeatherStage ws1, WeatherStage ws2)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public WeatherSetData()
	{
	}
}
