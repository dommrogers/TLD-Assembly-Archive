using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.Stats;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Log : MonoBehaviour
{
	private PanelReference<Panel_Log> m_Log;

	public string m_GeneralNotes;

	public List<LogDayInfo> m_LogDayInfoList;

	public LogDayInfo m_TodayLogDayInfo;

	private int m_DayToLogEndOfDayInfo;

	private bool m_AddedCurrentRegion;

	private bool m_StartHasBeenCalled;

	private static LogSaveDataProxy m_LogSaveDataProxy;

	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public LogDayInfo GetInfoForDay(int dayNumber)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallsUnknownMethods(Count = 4)]
	public void EnterNotesForDay(string notes, int dayNumber)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void AddAffliction(AfflictionType affType, string causeLocId)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__27), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	public void AddLocation(string locationName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void AddItem(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void WriteLogToFile()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Log), Member = "GetInfoForDay")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	public void LockInTodaysValues()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CalledBy(Type = typeof(Log), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "GetRegionSpriteNameFromSaveSlotInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void AddCurrentRegion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackCondition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeLogEndOfDayInfo()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Log), Member = "MaybeLogEndOfDayInfo")]
	[CalledBy(Type = typeof(Log), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	private void LogEndOfDayInfo(int day)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Log()
	{
	}
}
