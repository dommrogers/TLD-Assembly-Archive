using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Scenes;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsEnteringRegion : ConditionTask
{
	public BBParameter<RegionSpecification> regionName;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Condition_IsEnteringRegion()
	{
	}
}
