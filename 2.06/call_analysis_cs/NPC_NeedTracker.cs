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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "AddDefaultNeeds")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Awake")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPC_NeedPrefab), Member = "GetPrefabInfo")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallerCount(Count = 0)]
	public int GetTrustIncreaseFromItemList(List<GearItem> gearList, float numCalories, float numLitersWater, float numHoursFuel)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void GiveItemsToCompleteNeeds(List<GearItem> gearList, float numCalories, float numLitersWater, float numHoursFuel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[CallsUnknownMethods(Count = 2)]
	private void AddDefaultNeeds()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void CompleteNeedAtIndex(int index, int trustIncrease)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public NPC_NeedTracker()
	{
	}
}
