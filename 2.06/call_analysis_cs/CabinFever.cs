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

	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_nofx")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	public void CabinFeverStart(bool displayIcon, bool nofx = false)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearCabinFeverRisk()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	public void CabinFeverEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeIndoorsExcludingLastHour()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	public float GetTimeIndoorsLastHour()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	public void AddTimeIndoorsLastHour(float amountToAdd)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateCabinFever()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CheckForCabinFever()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsExcludingLastHour")]
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
	[CallsUnknownMethods(Count = 8)]
	public CabinFever()
	{
	}
}
