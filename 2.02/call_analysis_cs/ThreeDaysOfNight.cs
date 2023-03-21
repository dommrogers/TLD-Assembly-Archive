using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetCurrentDay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Init()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "threedaysofnight_removedayoverride")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_threedaysofnight_setday")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCurrentDay(int dayNumber)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "threedaysofnight_settransitiontoday")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(DateTime), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetTransitionToDay(int dayNumber)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ClearDailyTimerLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool CanManuallyUnlock()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool NoWolfGracePeriodActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Mark4DONCurrentDayComplete")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Is4DONCurrentDayComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(Action_4DONObjective), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetCurrentDayNumber()
	{
		return 0;
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlashlightDurationMultiplier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "DoThreeDaysOfNightBonus")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlashlightEffectivenessMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetColdRateMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetBaselineAirTempIndoors()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNumReduceMaxSpawnWolf()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ThreeDaysOfNight()
	{
	}
}
