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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public LogDayInfo GetInfoForDay(int dayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void EnterNotesForDay(string notes, int dayNumber)
	{
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void AddAffliction(AfflictionType affType, string causeLocId)
	{
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(TypeFullName = "HUDManager.<WaitToShowLocationReveal>d__27", Member = "MoveNext")]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Log), Member = "GetInfoForDay")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CallsUnknownMethods(Count = 3)]
	public void LockInTodaysValues()
	{
	}

	[CalledBy(Type = typeof(Log), Member = "Update")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(Utils), Member = "GetRegionSpriteNameFromSaveSlotInfo")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(Log), Member = "Update")]
	[CalledBy(Type = typeof(Log), Member = "MaybeLogEndOfDayInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void LogEndOfDayInfo(int day)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Log()
	{
	}
}
