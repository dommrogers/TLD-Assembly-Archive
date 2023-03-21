using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class WeatherSet : MonoBehaviour
{
	private class WeatherSetInstanceSaveData
	{
		public int m_CurrentIndex;

		public float m_CurrentStageElapsedTime;

		public float[] m_StageDurations;

		public float[] m_StageTransitionTimes;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public WeatherSetInstanceSaveData()
		{
		}
	}

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
	[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Prepare()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Activate(float startAtFrac = 0f, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 4)]
	public void Deactivate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ForceStep")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Activate")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Activate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetProgressFrac()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 3)]
	public void ForceStep(int forceIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSetStage), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public string GetDebugString()
	{
		return null;
	}

	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 0)]
	private void WeatherSetComplete()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	private WeatherStage GetBlendedWeatherPair(WeatherStage ws1, WeatherStage ws2, bool allowSubordination)
	{
		return default(WeatherStage);
	}

	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 12)]
	public WeatherSet()
	{
	}
}
