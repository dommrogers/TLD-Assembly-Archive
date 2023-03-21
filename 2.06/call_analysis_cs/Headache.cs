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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeadacheParams), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HeadacheParams), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 12)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 3)]
	public float GetActiveHoursRemaining(int index)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(HeadacheParams), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[CallerCount(Count = 1)]
	public void ApplyHeadache(HeadacheCause headacheType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Headache), Member = "HasHeadache")]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	public string GetCause(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public HeadacheParams GetAfflictionByIndex(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadachesAll")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	private void RemoveHeadache(HeadacheParams data)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	private void MaybeUpdateHeadaches()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private HeadacheParams GetHeadacheDataByCause(HeadacheCause cause)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	public Headache()
	{
	}
}
