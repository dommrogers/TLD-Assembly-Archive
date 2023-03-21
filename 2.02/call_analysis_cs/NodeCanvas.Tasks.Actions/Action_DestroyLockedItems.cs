using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_DestroyLockedItems : ActionTask
{
	public string containerName;

	public BBParameter<GearItemComponentFilter> componentFilter;

	public BBParameter<InventoryItemRequirement> requiredItem;

	public BBParameter<int> itemCount;

	private List<GearItem> items;

	public BBParameter<bool> removeAll;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 9)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 16)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "GetItems")]
	[Calls(Type = typeof(Container), Member = "GetItems")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private bool DoDestroyContainerLockedItems()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 38)]
	public Action_DestroyLockedItems()
	{
	}
}
