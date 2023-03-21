using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_AddGearItem : ActionTask
{
	public BBParameter<List<InventoryItemRequirement>> addItemsList;

	public bool suppressItemAddedEvent;

	public bool enableNotificationFlag;

	protected override string info
	{
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[Calls(Type = typeof(string), Member = "StartsWith")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Substring")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessageFadeIn")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Action_AddGearItem()
	{
	}
}
