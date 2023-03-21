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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
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

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCustomEvent")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCheck")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Condition_PlayerHasItemsWithWeight()
	{
	}
}
