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
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	private static void SerializeAllTimeStats(ProfileState profileState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallsUnknownMethods(Count = 1)]
	private static void DeserializeAllTimeStats(ProfileState profileState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 78)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeInitializeSandboxModes()
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeAllTimeStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsUnknownMethods(Count = 2)]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybeSlipOrFall")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	public static float GetValue(StatID id)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private static bool CanTrackStats()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SetEpisodeProgress), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_episode_complete")]
	public static void SetValue(StatID id, float value)
	{
	}

	[Calls(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeComputeDependentStats")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallerCount(Count = 66)]
	[Calls(Type = typeof(StatsManager), Member = "CanTrackStats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public static float IncrementValue(StatID id, float increment = 1f)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	private static void MaybeComputeDependentStats(StatID id)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(StatInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public static void FixUpCurrentSessionLongestBurningFireStat()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatsManager()
	{
	}
}
