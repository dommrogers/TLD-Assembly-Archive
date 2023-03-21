using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class NPC_NeedTracker : MonoBehaviour
{
	public string m_NPCTrustID;

	public bool m_NoTrustDecayUntilPlayerInteraction;

	public NPC_NeedPrefab[] m_DefaultNeeds;

	public List<NeedPrefabSaveData> m_NeedPrefabsActive;

	private bool m_HasBeenInteractedWith;

	private static NeedTrackerSaveData m_NeedTrackerSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[CalledBy(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsTrustDecayAllowed()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetHasBeenInteractedWith()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "AddDefaultNeeds")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Awake")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void AddNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool IsNeedMet(NPC_NeedPrefab needToCheck)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GearItemMeetsCurrentNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetTrustIncreaseFromItemList")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTrustWithinNeedRange(NeedPrefabSaveData needData)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GearItemMeetsCurrentNeed")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetTrustIncreaseFromItemList")]
	public bool IsReadyToBeCompleted(NeedPrefabSaveData needData)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool GearItemMeetsCurrentNeed(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public int GetTrustIncreaseFromItemList(List<GearItem> gearList, float numCalories, float numLitersWater, float numHoursFuel)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void GiveItemsToCompleteNeeds(List<GearItem> gearList, float numCalories, float numLitersWater, float numHoursFuel)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void AddDefaultNeeds()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CallsUnknownMethods(Count = 2)]
	private void CompleteNeedAtIndex(int index, int trustIncrease)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NPC_NeedTracker()
	{
	}
}
