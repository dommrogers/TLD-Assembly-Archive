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
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HeadacheParams), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HeadacheParams), Member = "Serialize")]
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
	[Calls(Type = typeof(HeadacheParams), Member = "Deserialize")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	public bool HasHeadache()
	{
		return false;
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public float GetActiveHoursRemaining(int index)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoostExitEffects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(HeadacheParams), Member = ".ctor")]
	[Calls(Type = typeof(HeadacheParams), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void ApplyHeadache(HeadacheCause headacheType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveHeadache(HeadacheCause cause)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveHeadachesAll()
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(Headache), Member = "HasHeadache")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadachesAll")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveHeadache(HeadacheParams data)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateHeadaches()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private HeadacheParams GetHeadacheDataByCause(HeadacheCause cause)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public Headache()
	{
	}
}
