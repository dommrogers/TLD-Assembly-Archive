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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "AddUnlockable")]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public void UnlockUnlockable(string name)
	{
	}

	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void AddUnlockable(NPC_UnlockablePrefab unlockableToAdd)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NPC_UnlockableTracker()
	{
	}
}
