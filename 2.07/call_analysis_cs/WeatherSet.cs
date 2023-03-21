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

	[CalledBy(Type = typeof(WeatherSet), Member = "ForceStep")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Update")]
	[CalledBy(Type = typeof(WeatherSet), Member = "Activate")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Activate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	private void ActivateStage(float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(WeatherSetStage), Member = "Deactivate")]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeatherSetStage), Member = "Update")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetProgressFrac()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceTransitionToStep(int forceIndex)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public void ForceStep(int forceIndex)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(WeatherSetStage), Member = "GetDebugString")]
	[CallsUnknownMethods(Count = 3)]
	public string GetDebugString()
	{
		return null;
	}

	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 0)]
	private void WeatherSetComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[Calls(Type = typeof(Utils), Member = "GetFirstDayLengthInHours")]
	[CallsUnknownMethods(Count = 4)]
	public float ReportHoursOfBlizzardForDay(int reportDay)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void RefreshDuration()
	{
	}

	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherSet), Member = "GetBlendedWeatherPair")]
	[CallerCount(Count = 0)]
	public WeatherStage ReportWeatherForDay(int reportDay)
	{
		return default(WeatherStage);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportWeatherForDay")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public WeatherSet()
	{
	}
}
