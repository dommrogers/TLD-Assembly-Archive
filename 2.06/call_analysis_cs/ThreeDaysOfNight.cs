using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.TimeLib;
using UnityEngine;

public class ThreeDaysOfNight : MonoBehaviour
{
	public const int NUM_DAYS_HALF_BADGE = 2;

	public const int NUM_DAYS_FULL_BADGE = 4;

	public float m_FlashlightDurationMultiplier;

	public float m_FlashlightEffectivenessMultiplier;

	public float m_DayFourColdRateMultiplier;

	public float m_DayFourBaselineAirTempIndoors;

	public float m_HoursNoWolfGracePeriod;

	public int m_NumReduceMaxSpawnWolf;

	public static bool m_ForcedOn;

	public static int m_CurrentDay;

	private static DateTime m_StartEventTime;

	private static DateTime m_DayTwoStartTime;

	private static DateTime m_DayThreeStartTime;

	private static DateTime m_DayFourStartTime;

	private static DateTime m_EndEventTime;

	private static int m_OverrideSetDay;

	private static ThreeDaysOfNight m_Instance;

	private static int s_LastMinutesRemaining;

	private static string s_MinutesRemainingString;

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetCurrentDay")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	public static void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "Init")]
	public static void SetCurrentDay(int dayNumber)
	{
	}

	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	public static void SetTransitionToDay(int dayNumber)
	{
	}

	[CallerCount(Count = 0)]
	public static void ClearDailyTimerLabels()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool CanManuallyUnlock()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool NoWolfGracePeriodActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallerCount(Count = 4)]
	public static int GetCurrentDayNumber()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlashlightDurationMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlashlightEffectivenessMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetColdRateMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetBaselineAirTempIndoors()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int GetNumReduceMaxSpawnWolf()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ThreeDaysOfNight()
	{
	}
}
