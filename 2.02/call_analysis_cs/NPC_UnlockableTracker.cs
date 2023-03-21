using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class NPC_UnlockableTracker : MonoBehaviour
{
	public string m_NPCTrustID;

	public NPC_UnlockablePrefab[] m_DefaultUnlockables;

	public List<UnlockablePrefabSaveData> m_UnlockablePrefabsActive;

	private static UnlockableTrackerSaveData m_UnlockableTrackerSaveData;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "AddUnlockable")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(TrustManager), Member = "RegisterUnlockableTracker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeUnlockableTrackers")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeUnlockableTrackers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Action_UnlockNPCUnlockable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 5)]
	public void UnlockUnlockable(string name)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC_UnlockablePrefab), Member = "GetPrefabInfo")]
	public void AddUnlockable(NPC_UnlockablePrefab unlockableToAdd)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPC_UnlockableTracker()
	{
	}
}
