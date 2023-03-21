using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_GetWeightOfItems : ActionTask
{
	public BBParameter<List<GearItem>> targetGearItemList;

	public string storeWeightVar;

	private List<GearItem> playerItems;

	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	public Action_GetWeightOfItems()
	{
	}
}
