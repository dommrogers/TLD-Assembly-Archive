using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_GearInsideTrigger : ConditionTask<BoxCollider>
{
	public BBParameter<GearItem> gearitem;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Equals")]
	[CallsUnknownMethods(Count = 10)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public TLD_GearInsideTrigger()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
