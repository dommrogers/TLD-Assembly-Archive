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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public Condition_IsEnteringRegion()
	{
	}
}
