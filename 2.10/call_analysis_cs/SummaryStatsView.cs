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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildStatsView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ViewSandbox")]
	[CallerCount(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AddStat(StatID statName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AddRandomStat(StatID statName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(StatsManager), Member = "GetStatInfo")]
	[Calls(Type = typeof(StatsView), Member = "GetFormattedValue")]
	[Calls(Type = typeof(StatsView), Member = "GetFormattedTitle")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	public void Populate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public SummaryStatsView()
	{
	}
}
