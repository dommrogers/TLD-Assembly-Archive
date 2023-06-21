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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetItems")]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[Calls(Type = typeof(Variable<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Action_GetWeightOfItems()
	{
	}
}
