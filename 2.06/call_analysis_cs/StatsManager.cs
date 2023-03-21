using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
using TLD.SaveState;
using TLD.Serialization;
using TLD.Stats;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsManager : MonoBehaviour
{
	public delegate void IncrementStatDelegate(StatID id, float amount);

	public delegate void SetStatDelegate(StatID id, float previous, float current);

	private static readonly Dictionary<int, StatInfo> m_StatInfo;

	public static StatContainer m_CurrentSessionStatsContainer;

	public static List<StatContainer> m_AllTimeStatsContainer;

	public static IncrementStatDelegate OnIncrementStat;

	public static SetStatDelegate OnSetStat;

	private static readonly string[] s_OrderedSandboxNames;

	private static readonly SandboxConfig[] s_OrderedSandboxModes;

	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[CallsUnknownMethods(Count = 11)]
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
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeCurrentSession()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CallerCount(Count = 2)]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	private static void SerializeAllTimeStats(ProfileState profileState)
	{
	}

	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DeserializeAllTimeStats(ProfileState profileState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 75)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void MaybeInitializeSandboxModes()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeAllTimeStats")]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	public static float GetValue(StatID id)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanTrackStats()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	public static void SetValue(StatID id, float value)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallerCount(Count = 63)]
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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallsUnknownMethods(Count = 7)]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public static void FixUpCurrentSessionLongestBurningFireStat()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public StatsManager()
	{
	}
}
