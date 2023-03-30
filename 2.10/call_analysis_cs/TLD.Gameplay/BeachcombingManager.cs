using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using TLD.Logging;
using TLD.Serialization;
using UnityEngine;

namespace TLD.Gameplay;

public class BeachcombingManager : MonoBehaviour
{
	public static LogFilter s_LogFilter;

	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	private static BeachcombingManagerSaveData m_CurrentState;

	private static bool _003CIsFakeBlizzard_003Ek__BackingField;

	private WeatherStage m_CurrentWeatherStage;

	public static int BlizzardID
	{
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DeserializeBigItems")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public static float TimeSinceLastBlizzard
	{
		[CalledBy(Type = typeof(BeachcombingManager), Member = "GetDebugString")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "get_IsActive")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "get_HasBigItemsExpired")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Update")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBeachcombing")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DeserializeBigItems")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public static bool IsFakeBlizzard
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameEvent), Member = "add_Fired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetNormalizedWeatherTransition")]
	[Calls(Type = typeof(BeachcombingManager), Member = "StartNewBlizzard")]
	[CallsUnknownMethods(Count = 2)]
	private void OnWeatherChanged()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(BeachcombingManager), Member = "OnWeatherChanged")]
	[CalledBy(Type = typeof(BeachcombingManager), Member = "DebugForceBlizzard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private static void StartNewBlizzard()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_beachcombing_force_blizzard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BeachcombingManager), Member = "StartNewBlizzard")]
	[CallsUnknownMethods(Count = 4)]
	public static void DebugForceBlizzard(bool active)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "GetDebugWeatherText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetDebugString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BeachcombingManager()
	{
	}
}
