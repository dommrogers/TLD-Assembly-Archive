using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.Serialization;
using TLD.Stats;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsManager : MonoBehaviour
{
	public delegate void IncrementStatDelegate(StatID id, float amount);

	public delegate void SetStatDelegate(StatID id, float previous, float current);

	private OptionalContentConfig m_ContentConfig;

	private static readonly Dictionary<int, StatInfo> m_StatInfo;

	public static StatContainer m_CurrentSessionStatsContainer;

	public static List<StatContainer> m_AllTimeStatsContainer;

	public static IncrementStatDelegate OnIncrementStat;

	public static SetStatDelegate OnSetStat;

	private static readonly string[] s_OrderedSandboxNames;

	private static readonly SandboxConfig[] s_OrderedSandboxModes;

	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeSandboxModes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeCurrentSession()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	private static void SerializeAllTimeStats(ProfileState profileState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DeserializeAllTimeStats(ProfileState profileState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 78)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	private static void MaybeInitializeSandboxModes()
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeAllTimeStats")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	public static float GetValue(StatID id)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanTrackStats()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	public static void SetValue(StatID id, float value)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallerCount(Count = 66)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public static float IncrementValue(StatID id, float increment = 1f)
	{
		return default(float);
	}

	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	private static void MaybeComputeDependentStats(StatID id)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public static void FixUpCurrentSessionLongestBurningFireStat()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StatsManager()
	{
	}
}
