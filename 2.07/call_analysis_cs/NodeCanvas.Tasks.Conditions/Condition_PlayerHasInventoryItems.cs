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
		[CallsUnknownMethods(Count = 53)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "StartsWith")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(NCUtils), Member = "IsValidRequirementIndex")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(Condition_PlayerHasInventoryItems), Member = "Test")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	[Calls(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasInventoryItems), Member = "OnCustomEvent")]
	[CallsUnknownMethods(Count = 3)]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Condition_PlayerHasInventoryItems()
	{
	}
}
