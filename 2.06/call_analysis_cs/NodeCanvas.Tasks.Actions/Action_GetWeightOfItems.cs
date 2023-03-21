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
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Action_GetWeightOfItems()
	{
	}
}
