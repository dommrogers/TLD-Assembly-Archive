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

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	public StatContainer(StatContainer rhs)
	{
	}

	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FillLegacySaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FillLegacySaveSlotInfo")]
	[CalledBy(Type = typeof(StatsManager), Member = "FixUpCurrentSessionLongestBurningFireStat")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "GetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StatContainer), Member = "IncrementValue")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StatContainer), Member = "GetHashId")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	public float GetValue(StatID id)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatInfo), Member = "GetFormattedValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "GetStatInfo")]
	public string GetFormattedValue(StatID id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StatContainer), Member = "GetHashId")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(StatContainer), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(StatsManager), Member = "SetValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(StatsManager), Member = "FixUpCurrentSessionLongestBurningFireStat")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetValue(StatID id, float value)
	{
	}

	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	public float IncrementValue(StatID id, float increment)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(StatsManager), Member = "Reset")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CalledBy(Type = typeof(StatsManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 8)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(StatsManager), Member = ".cctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StatsManager), Member = "Reset")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[CalledBy(Type = typeof(StatContainer), Member = ".ctor")]
	[Calls(Type = typeof(StatContainer), Member = "ComputeHashId")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetHashId")]
	private void CacheHashIds()
	{
	}

	[CalledBy(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int ComputeHashId(StatID id)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(StatContainer), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatContainer), Member = "CacheHashIds")]
	[CallerCount(Count = 2)]
	private int GetHashId(StatID id)
	{
		return default(int);
	}
}
