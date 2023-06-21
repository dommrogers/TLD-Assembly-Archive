using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Headache : MonoBehaviour
{
	private struct HeadacheSaveDataProxy
	{
		public float m_HeadacheDurationHours;

		public float m_HeadachePulseFrequencyStart;

		public float m_HeadachePulseFrequencyEnd;

		public float m_StartTimeInGameHours;

		public bool m_IsUpdatedProxyVersion;

		public List<HeadacheParamsSaveDataProxy> m_ListOfParamData;
	}

	private HeadacheData m_LegacyHeadacheData;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private readonly List<HeadacheParams> m_HeadacheInstances;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HeadacheParams), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HeadacheParams), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	public bool HasHeadache()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HeadacheParams), Member = "GetActiveHoursRemaining")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetActiveHoursRemaining(int index)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "GetActiveHoursRemaining")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetNormalizedTimeRemaining(int index)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "MaybeUpdateEnergyBoostEffects")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CalledBy(Type = typeof(CausesHeadacheDebuff), Member = "Apply")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyHeadache(HeadacheData headacheData)
	{
	}

	[CalledBy(Type = typeof(CausesHeadacheDebuff), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveHeadache(HeadacheData headacheData)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Headache), Member = "HasHeadache")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetCause(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public HeadacheParams GetAfflictionByIndex(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveHeadache(HeadacheParams data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateHeadaches()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Headache()
	{
	}
}
