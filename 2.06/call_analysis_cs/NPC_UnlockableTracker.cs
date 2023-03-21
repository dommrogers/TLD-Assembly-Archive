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

	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void UnlockUnlockable(string name)
	{
	}

	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(NPC_UnlockablePrefab), Member = "GetPrefabInfo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
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
