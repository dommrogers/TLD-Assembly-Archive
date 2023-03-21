using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class CabinFever : MonoBehaviour
{
	public float m_NumHoursToExitRisk;

	public float m_NumHoursToEnterRisk;

	public float m_NumHoursRequiredIndoors;

	public float m_NumHoursToCheck;

	public float m_NumHoursToPreventIndoorRest;

	public GameplayTag m_DisableTag;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

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
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void CabinFeverStart(bool displayIcon, bool nofx = false)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	public void ClearCabinFeverRisk()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_cure")]
	[CallsUnknownMethods(Count = 1)]
	public void CabinFeverEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCabinFever()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasCabinFeverRisk()
	{
		return default(bool);
	}

	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public int GetCurrentRisk()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	public float GetTimeAmountRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetTimeIndoorsExcludingLastHour()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeIndoorsLastHour()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void AddTimeIndoorsLastHour(float amountToAdd)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	private void UpdateCabinFever()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CheckForCabinFever()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void UpdateCabinFeverTimeTracker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 1)]
	public bool DisabledForGameMode(GameModeConfig gameMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public CabinFever()
	{
	}
}
