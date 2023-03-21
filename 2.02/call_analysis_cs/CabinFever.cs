using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CabinFever : MonoBehaviour
{
	public float m_NumHoursToExitRisk;

	public float m_NumHoursToEnterRisk;

	public float m_NumHoursRequiredIndoors;

	public float m_NumHoursToCheck;

	public float m_NumHoursToPreventIndoorRest;

	public int m_NumSafeDaysVoyageur;

	public int m_NumSafeDaysStalker;

	public int m_NumSafeDaysInterloper;

	public List<ExperienceModeType> m_XPModesToDisable;

	private bool m_Active;

	private bool m_RiskActive;

	private float m_ElapsedHours;

	private List<float> m_IndoorTimeTracked;

	private int m_HourLastFrame;

	private float m_HoursIndoorsExcludingLastHourCached;

	private bool m_StartHasBeenCalled;

	private static CabinFeverSaveDataProxy m_CabinFeverSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsExcludingLastHour")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(CabinFever), Member = "DisabledForXPMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public void CabinFeverStart(bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_cure")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	public void ClearCabinFeverRisk()
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "Deserialize")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_cure")]
	[CallsUnknownMethods(Count = 1)]
	public void CabinFeverEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasCabinFever()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCabinFeverRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public int GetCurrentRisk()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetTimeAmountRemaining()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CabinFever), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTimeIndoorsExcludingLastHour()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public float GetTimeIndoorsLastHour()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	public void AddTimeIndoorsLastHour(float amountToAdd)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	private void UpdateCabinFever()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(CabinFever), Member = "DisabledForXPMode")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(CabinFever), Member = "DisabledForXPMode")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	private void CheckForCabinFever()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsExcludingLastHour")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	private void UpdateCabinFeverTimeTracker()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisabledForXPMode(ExperienceModeType xpmode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CabinFever()
	{
	}
}
