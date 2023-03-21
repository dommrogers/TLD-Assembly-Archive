using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_GearInsideTrigger : ConditionTask<BoxCollider>
{
	public BBParameter<GearItem> gearitem;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
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
