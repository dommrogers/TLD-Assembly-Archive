using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Stats;
using UnityEngine;

[Serializable]
public class SummaryStatsView : StatsView
{
	public GameObject m_GameObject;

	public GameObject m_SummaryStatPrefab;

	public UIGrid m_Grid;

	public UILabel m_Label_DaysSurvivedValue;

	public UILabel m_Label_HoursSurvivedValue;

	public UILabel m_Label_MinutesSurvivedValue;

	private List<StatID> m_VisibleStatIDs;

	private List<StatID> m_RandomStatIDs;

	private List<Panel_Stats_SummaryEntry> m_VisibleStatsPrefabs;

	[Calls(Type = typeof(SummaryStatsView), Member = "Populate")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddRandomStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SummaryStatsView), Member = "AddStat")]
	public void Start()
	{
	}

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddStat(StatID statName)
	{
	}

	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	public void AddRandomStat(StatID statName)
	{
	}

	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetStatInfo")]
	[Calls(Type = typeof(StatsView), Member = "GetFormattedValue")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(SummaryStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StatsView), Member = "GetFormattedTitle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Populate()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	public SummaryStatsView()
	{
	}
}
