using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerHasInventoryItems : ConditionTask
{
	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	public bool mustHaveAll;

	public bool requireInvEvent;

	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	protected override string info
	{
		[CallsUnknownMethods(Count = 61)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "StartsWith")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NCUtils), Member = "IsValidRequirementIndex")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "OnCustomEvent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public Condition_PlayerHasInventoryItems()
	{
	}
}
