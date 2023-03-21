using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using UnityEngine;

namespace MissionTypes;

[Serializable]
public class InventoryItemRequirement
{
	public string name;

	public GearItem item;

	public int amount;

	public bool testMeasurableAmount;

	public string optionGroupTag;

	public string requirementCondition;

	private Variable reqLHVar;

	private string reqOp;

	private Variable reqRHVar;

	[CallerCount(Count = 0)]
	public InventoryItemRequirement()
	{
	}

	[CalledBy(Type = typeof(NCUtils), Member = "GetValue5")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue2")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue3")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetValue4")]
	public InventoryItemRequirement(string _name, int _amount, bool _testMeasurable, string _optionGroupTag, string _condition)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NCUtils), Member = "ParseConditional")]
	[Calls(Type = typeof(NCUtils), Member = "TestConditional")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetItemRequirementsMatchCount")]
	[CallsUnknownMethods(Count = 1)]
	public bool TestRequirementCondition(IBlackboard bb)
	{
		return default(bool);
	}
}
