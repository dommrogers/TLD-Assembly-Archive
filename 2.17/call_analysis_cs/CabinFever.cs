using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Gear;
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

	private float m_BuffCooldownRemainingHours;

	private readonly List<float> m_IndoorTimeTracked;

	private int m_HourLastFrame;

	private float m_HoursIndoorsExcludingLastHourCached;

	private bool m_StartHasBeenCalled;

	private static CabinFeverSaveDataProxy m_CabinFeverSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[CallsUnknownMethods(Count = 8)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_nofx")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 3)]
	public void CabinFeverStart(bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void ClearCabinFeverRisk()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_cabinfever_cure")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsUnknownMethods(Count = 1)]
	public void CabinFeverEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCabinFever()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCabinFeverRisk()
	{
		return false;
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	public int GetCurrentRisk()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	public float GetTimeAmountRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeIndoorsExcludingLastHour()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[CalledBy(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetTimeIndoorsLastHour()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void AddTimeIndoorsLastHour(float amountToAdd)
	{
	}

	[CalledBy(Type = typeof(CabinFeverReductionBuff), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float ApplyCabinFeverReductionBuff(float reductionInHours, float cooldownInHours)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverEnd")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CabinFever), Member = "ClearCabinFeverRisk")]
	[Calls(Type = typeof(CabinFever), Member = "CheckForCabinFever")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateCabinFever()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFever")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CabinFever), Member = "GetTimeIndoorsLastHour")]
	[Calls(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 4)]
	private void CheckForCabinFever()
	{
	}

	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerManager), Member = "InHibernationPreventionIndoorEnvironment")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateCabinFeverTimeTracker()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CallsUnknownMethods(Count = 1)]
	public bool DisabledForGameMode(GameModeConfig gameMode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public CabinFever()
	{
	}
}
