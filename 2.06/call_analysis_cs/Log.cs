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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallsUnknownMethods(Count = 2)]
	public LogDayInfo GetInfoForDay(int dayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	public void EnterNotesForDay(string notes, int dayNumber)
	{
	}

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsUnknownMethods(Count = 12)]
	public void AddAffliction(AfflictionType affType, string causeLocId)
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__22), Member = "MoveNext")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void WriteLogToFile()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(Log), Member = "GetInfoForDay")]
	public void LockInTodaysValues()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CalledBy(Type = typeof(Log), Member = "Update")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(Utils), Member = "GetRegionSpriteNameFromSaveSlotInfo")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	private void AddCurrentRegion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TrackCondition()
	{
	}

	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeLogEndOfDayInfo()
	{
	}

	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CalledBy(Type = typeof(Log), Member = "Update")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Log), Member = "MaybeLogEndOfDayInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void LogEndOfDayInfo(int day)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Log()
	{
	}
}
