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
		[CallsUnknownMethods(Count = 27)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "StartsWith")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NCUtils), Member = "IsValidRequirementIndex")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(NCUtils), Member = "BuildRequirementsDictionary")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NCUtils), Member = "TestItemRequirements")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public TLD_CheckContainerContains()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
