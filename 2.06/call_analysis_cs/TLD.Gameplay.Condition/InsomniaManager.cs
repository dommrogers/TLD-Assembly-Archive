using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay.Condition;

public class InsomniaManager : MonoBehaviour
{
	private struct InsomniaSaveDataProxy
	{
		public List<InsomniaParamsSaveDataProxy> m_ListOfParamData;
	}

	public InsomniaData[] m_InsomniaData;

	public List<InsomniaSafeZoneTrigger> m_SafeZoneCollection;

	private readonly Dictionary<InsomniaCause, InsomniaData> m_InsomniaDataDict;

	private readonly List<Insomnia> m_InsomniaInstances;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Insomnia), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 12)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Insomnia), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Insomnia), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	private void MaybeUpdateInsomnia()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Insomnia), Member = ".ctor")]
	[Calls(Type = typeof(Insomnia), Member = "StartRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyInsomniaRisk(InsomniaCause InsomniaType)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Insomnia), Member = "StartAffliction")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_insomnia")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Insomnia), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ApplyInsomniaAffliction(InsomniaCause InsomniaType)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	public string GetInsomniaCause(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaRisk")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	public bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	public void RemoveInsomniaAll()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "RemoveInsomniaAll")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveInsomnia(Insomnia data)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	private Insomnia GetInsomniaDataByCause(InsomniaCause cause)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasElectrostaticFogAffliction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleepWithInsomnia")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetChanceOfHowBadlySleepIsInterrupted")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ShouldInterruptSleep")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[Calls(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CalledBy(Type = typeof(Rest), Member = "GetChanceOfHowBadlySleepIsIntnerrupted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	private Insomnia GetElectrostaticFogAffliction()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	public InsomniaManager()
	{
	}
}
