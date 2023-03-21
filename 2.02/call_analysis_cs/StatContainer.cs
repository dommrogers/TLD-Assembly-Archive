using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class StatContainer
{
	public Dictionary<int, string> m_StatsDictionary;

	public int m_NumBurntHousesInCoastal;

	public bool m_HasDoneCoastalBurntHouseCheck;

	public bool m_HasDoneCorrectBurntHouseCheck;

	private static int[] m_CachedHashIds;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "Reset")]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	public StatContainer()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public StatContainer(StatContainer rhs)
	{
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[CalledBy(Type = typeof(StatContainer), Member = "IncrementValue")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(StatsManager), Member = "GetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "FixUpCurrentSessionLongestBurningFireStat")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FillLegacySaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(StatContainer), Member = "GetHashId")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "ParseSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetValue(StatID id)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "GetStatInfo")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatInfo), Member = "GetFormattedValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetFormattedValue(StatID id)
	{
		return null;
	}

	[CalledBy(Type = typeof(StatContainer), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "FixUpCurrentSessionLongestBurningFireStat")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StatContainer), Member = "GetHashId")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(StatID id, float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	public float IncrementValue(StatID id, float increment)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatsManager), Member = "Reset")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CalledBy(Type = typeof(StatsManager), Member = ".cctor")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetHashId")]
	[CalledBy(Type = typeof(StatsManager), Member = "Reset")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CalledBy(Type = typeof(StatsManager), Member = ".cctor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StatContainer), Member = "ComputeHashId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CacheHashIds()
	{
	}

	[CalledBy(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int ComputeHashId(StatID id)
	{
		return 0;
	}

	[CalledBy(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(StatContainer), Member = "SetValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int GetHashId(StatID id)
	{
		return 0;
	}
}
