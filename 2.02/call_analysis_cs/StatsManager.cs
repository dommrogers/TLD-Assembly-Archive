using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
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
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeCurrentSession()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallerCount(Count = 2)]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAllTimeStats()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	public static void DeserializeAllTimeStats(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 75)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeAllTimeStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	public static float GetValue(StatID id)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private static bool CanTrackStats()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(SetStatDelegate), Member = "Invoke")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	public static void SetValue(StatID id, float value)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(IncrementStatDelegate), Member = "Invoke")]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public static float IncrementValue(StatID id, float increment = 1f)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	private static void MaybeComputeDependentStats(StatID id)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallsUnknownMethods(Count = 10)]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public static void FixUpCurrentSessionLongestBurningFireStat()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StatsManager()
	{
	}
}
