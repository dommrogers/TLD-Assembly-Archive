using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerHasItemsWithWeight : ConditionTask
{
	public BBParameter<List<GearItem>> targetGearItemList;

	public CompareMethod checkType;

	public BBParameter<float> targetWeight;

	public float differenceThreshold;

	private List<GearItem> playerItems;

	[Calls(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCheck")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	private bool Test()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 17)]
	public Condition_PlayerHasItemsWithWeight()
	{
	}
}
