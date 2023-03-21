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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "OnCustomEvent")]
	private bool Test()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 22)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public Condition_PlayerHasItemsWithWeight()
	{
	}
}
