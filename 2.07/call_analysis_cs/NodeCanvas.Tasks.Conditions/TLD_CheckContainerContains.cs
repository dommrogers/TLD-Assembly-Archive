using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_CheckContainerContains : ConditionTask<GraphOwner>
{
	public string containerName;

	public BBParameter<List<InventoryItemRequirement>> requiredItemsList;

	public bool mustHaveAll;

	private Dictionary<string, List<InventoryItemRequirement>> requirementsDict;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Substring")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(int), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "StartsWith")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NCUtils), Member = "IsValidRequirementIndex")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	[Calls(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	[CallsUnknownMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TLD_CheckContainerContains()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
