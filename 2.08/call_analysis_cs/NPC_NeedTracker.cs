using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustManager), Member = "RegisterNeedTracker")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(TrustManager), Member = "SerializeNeedTrackers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(TrustManager), Member = "DeserializeNeedTrackers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsTrustDecayAllowed()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetHasBeenInteractedWith()
	{
	}

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "Awake")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "AddDefaultNeeds")]
	[CalledBy(Type = typeof(Action_AddNPCNeed), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsNeedMet(NPC_NeedPrefab needToCheck)
	{
		return false;
	}

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GearItemMeetsCurrentNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetTrustIncreaseFromItemList")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TrustManager), Member = "GetTrustValue")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTrustWithinNeedRange(NeedPrefabSaveData needData)
	{
		return false;
	}

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GearItemMeetsCurrentNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetTrustIncreaseFromItemList")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsReadyToBeCompleted(NeedPrefabSaveData needData)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[CallsUnknownMethods(Count = 2)]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	public bool GearItemMeetsCurrentNeed(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 18)]
	public int GetTrustIncreaseFromItemList(List<GearItem> gearList, float numCalories, float numLitersWater, float numHoursFuel)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsTrustWithinNeedRange")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "IsReadyToBeCompleted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "CompleteNeedAtIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 18)]
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

	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GiveItemsToCompleteNeeds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void CompleteNeedAtIndex(int index, int trustIncrease)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NPC_NeedTracker()
	{
	}
}
