using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Log : MonoBehaviour
{
	public string m_GeneralNotes;

	public List<LogDayInfo> m_LogDayInfoList;

	public LogDayInfo m_TodayLogDayInfo;

	private int m_DayToLogEndOfDayInfo;

	private bool m_AddedCurrentRegion;

	private bool m_StartHasBeenCalled;

	private static LogSaveDataProxy m_LogSaveDataProxy;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Log), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Log), Member = "Start")]
	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateDailyStatsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildDailyList")]
	[CallsUnknownMethods(Count = 5)]
	public LogDayInfo GetInfoForDay(int dayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void EnterNotesForDay(string notes, int dayNumber)
	{
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CallsUnknownMethods(Count = 20)]
	public void AddAffliction(AfflictionType affType, string causeLocId)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(HUDManager), Member = "TrackIndoorLocation")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	public void AddLocation(string locationName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void AddItem(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void WriteLogToFile()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[CalledBy(Type = typeof(Log), Member = "GetInfoForDay")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public void LockInTodaysValues()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Log), Member = "Update")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetRegionSpriteNameFromSaveSlotInfo")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[CalledBy(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CallerCount(Count = 2)]
	private void AddCurrentRegion()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TrackCondition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "LogEndOfDayInfo")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeLogEndOfDayInfo()
	{
	}

	[CalledBy(Type = typeof(Log), Member = "Update")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Log), Member = "MaybeLogEndOfDayInfo")]
	[Calls(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private void LogEndOfDayInfo(int day)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Log()
	{
	}
}
