using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class StatInfo
{
	public enum Format
	{
		Time_Days,
		Time_Hours,
		Distance_Km,
		Distance_Meter,
		Weight,
		Volume,
		Percentage,
		Float1Dec,
		Int
	}

	public StatID m_ID;

	public string m_LocId;

	public string m_SpriteName;

	public Format m_Format;

	public bool m_Hidden;

	[CalledBy(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[CalledBy(Type = typeof(StatsManager), Member = "GetStatInfo")]
	[CallerCount(Count = 2)]
	public StatInfo(StatID id, string locId, string spriteName, Format format, bool hidden)
	{
	}

	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static string GetFormattedValue(Format format, float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static string GetFormattedTitle(string locId)
	{
		return null;
	}
}
