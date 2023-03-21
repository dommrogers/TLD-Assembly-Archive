using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class NPC_UnlockableTracker : MonoBehaviour
{
	public string m_NPCTrustID;

	public NPC_UnlockablePrefab[] m_DefaultUnlockables;

	public List<UnlockablePrefabSaveData> m_UnlockablePrefabsActive;

	private static UnlockableTrackerSaveData m_UnlockableTrackerSaveData;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "AddUnlockable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "RegisterUnlockableTracker")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void UnlockUnlockable(string name)
	{
	}

	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NPC_UnlockablePrefab), Member = "GetPrefabInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddUnlockable(NPC_UnlockablePrefab unlockableToAdd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public NPC_UnlockableTracker()
	{
	}
}
