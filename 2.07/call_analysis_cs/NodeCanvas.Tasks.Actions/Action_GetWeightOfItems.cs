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

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Action_GetWeightOfItems()
	{
	}
}
