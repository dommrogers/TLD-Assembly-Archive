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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatsManager), Member = "SetStatInfo")]
	[CalledBy(Type = typeof(StatsManager), Member = "GetStatInfo")]
	public StatInfo(StatID id, string locId, string spriteName, Format format, bool hidden)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[CalledBy(Type = typeof(StatContainer), Member = "GetFormattedValue")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetFormattedValue(Format format, float value)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Populate")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetFormattedTitle(string locId)
	{
		return null;
	}
}
