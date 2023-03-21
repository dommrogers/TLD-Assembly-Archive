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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Insomnia), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Insomnia), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
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
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Insomnia), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[Calls(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateInsomnia()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Insomnia), Member = ".ctor")]
	[Calls(Type = typeof(Insomnia), Member = "StartRisk")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyInsomniaRisk(InsomniaCause InsomniaType)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_insomnia")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaDataByCause")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Insomnia), Member = ".ctor")]
	[Calls(Type = typeof(Insomnia), Member = "StartAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void ApplyInsomniaAffliction(InsomniaCause InsomniaType)
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetInsomniaCause(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public Insomnia GetInsomniaByIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	public bool HasInsomniaAffliction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	public bool HasInsomniaRisk()
	{
		return false;
	}

	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(global::Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "HasInsomniaRisk")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public int GetRisksCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetActiveHoursRemaining(int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRiskProgress(int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldInterruptSleep()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	public float GetChanceOfHowBadlySleepIsInterrupted()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsElectrostaticFogActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsInSafePlace()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsomniaManager), Member = "RemoveInsomnia")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveInsomniaAll()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "RemoveInsomniaAll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveInsomnia(Insomnia data)
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeAddInsomniaRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private Insomnia GetInsomniaDataByCause(InsomniaCause cause)
	{
		return null;
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "GetElectrostaticFogAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private bool HasElectrostaticFogAffliction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptSleepWithInsomnia")]
	[CalledBy(Type = typeof(Rest), Member = "GetChanceOfHowBadlySleepIsIntnerrupted")]
	[CalledBy(Type = typeof(Rest), Member = "RollForRestInterruption")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ShouldInterruptSleep")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "GetChanceOfHowBadlySleepIsInterrupted")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InsomniaManager), Member = "HasElectrostaticFogAffliction")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private Insomnia GetElectrostaticFogAffliction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public InsomniaManager()
	{
	}
}
