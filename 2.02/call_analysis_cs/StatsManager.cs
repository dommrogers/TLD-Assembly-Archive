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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[Calls(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string SerializeCurrentSession()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string SerializeAllTimeStats()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeserializeAllTimeStats(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeAllTimeStats")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[CalledBy(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetValue(StatID id)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanTrackStats()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(SetStatDelegate), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetValue(StatID id, float value)
	{
	}

	[CallerCount(Count = 72)]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(IncrementStatDelegate), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static float IncrementValue(StatID id, float increment = 1f)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeComputeDependentStats(StatID id)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
