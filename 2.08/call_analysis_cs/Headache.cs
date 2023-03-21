using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	public HeadacheData[] m_HeadachesData;

	private Dictionary<HeadacheCause, HeadacheData> m_HeadachesDataDict;

	private List<HeadacheParams> m_HeadacheInstances;

	private Weather m_WeatherComponent;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private List<HeadacheParams> m_HeadacheParams;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HeadacheParams), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 7)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(HeadacheParams), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	public bool HasHeadache()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetActiveHoursRemaining(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeadacheParams), Member = "Initialize")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyHeadache(HeadacheCause headacheType)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	public void RemoveHeadache(HeadacheCause cause)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveHeadachesAll()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Headache), Member = "HasHeadache")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 4)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	public string GetCause(int index)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public HeadacheParams GetAfflictionByIndex(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadachesAll")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	private void RemoveHeadache(HeadacheParams data)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void MaybeUpdateHeadaches()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private HeadacheParams GetHeadacheDataByCause(HeadacheCause cause)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Headache()
	{
	}
}
