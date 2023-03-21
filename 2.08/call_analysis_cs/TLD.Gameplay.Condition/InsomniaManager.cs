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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	public void Update()
	{
	}

	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeAddInsomniaRisk()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	private void MaybeUpdateInsomnia()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Insomnia), Member = "StartRisk")]
	private void ApplyInsomniaRisk(InsomniaCause InsomniaType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_insomnia")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Insomnia), Member = "StartAffliction")]
	public void ApplyInsomniaAffliction(InsomniaCause InsomniaType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	public string GetInsomniaCause(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[CallerCount(Count = 0)]
	public bool HasInsomniaRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CallsUnknownMethods(Count = 4)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaRisk")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 4)]
	public int GetRisksCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallerCount(Count = 0)]
	public bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void RemoveInsomniaAll()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveInsomnia(Insomnia data)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	private Insomnia GetInsomniaDataByCause(InsomniaCause cause)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasElectrostaticFogAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetChanceOfHowBadlySleepIsInterrupted")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ShouldInterruptSleep")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleepWithInsomnia")]
	[Calls(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Rest), Member = "GetChanceOfHowBadlySleepIsIntnerrupted")]
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
