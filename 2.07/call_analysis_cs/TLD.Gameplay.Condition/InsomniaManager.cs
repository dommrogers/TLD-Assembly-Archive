using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay.Condition;

public class InsomniaManager : MonoBehaviour
{
	public InsomniaData[] m_InsomniaData;

	public List<InsomniaSafeZoneTrigger> m_SafeZoneCollection;

	private readonly Dictionary<InsomniaCause, InsomniaData> m_InsomniaDataDict;

	private readonly List<Insomnia> m_InsomniaInstances;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Insomnia), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Insomnia), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeAddInsomniaRisk()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	private void MaybeUpdateInsomnia()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Insomnia), Member = "StartRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyInsomniaRisk(InsomniaCause InsomniaType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_insomnia")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Insomnia), Member = "StartAffliction")]
	public void ApplyInsomniaAffliction(InsomniaCause InsomniaType)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public string GetInsomniaCause(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public Insomnia GetInsomniaByIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	public bool HasInsomniaAffliction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	public bool HasInsomniaRisk()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaAffliction")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaRisk")]
	[CallsUnknownMethods(Count = 4)]
	public int GetRisksCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetActiveHoursRemaining(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRiskProgress(int index)
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	public bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	public float GetChanceOfHowBadlySleepIsInterrupted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsElectrostaticFogActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInSafePlace()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveInsomniaAll()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	private void RemoveInsomnia(Insomnia data)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallsUnknownMethods(Count = 4)]
	private Insomnia GetInsomniaDataByCause(InsomniaCause cause)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	private bool HasElectrostaticFogAffliction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "GetChanceOfHowBadlySleepIsInterrupted")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleepWithInsomnia")]
	[CalledBy(Type = typeof(Rest), Member = "GetChanceOfHowBadlySleepIsIntnerrupted")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ShouldInterruptSleep")]
	[CallsUnknownMethods(Count = 4)]
	private Insomnia GetElectrostaticFogAffliction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public InsomniaManager()
	{
	}
}
