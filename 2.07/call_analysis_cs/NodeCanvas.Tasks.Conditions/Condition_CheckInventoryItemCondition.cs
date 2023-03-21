using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CheckInventoryItemCondition : ConditionTask
{
	public BBParameter<InventoryItemRequirement> requiredItem;

	public CompareMethod checkType;

	public BBParameter<int> compareValue;

	private List<GearItem> items;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 30)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Condition_CheckInventoryItemCondition()
	{
	}
}
