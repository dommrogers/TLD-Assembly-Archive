using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class IsActive : ConditionTask<Transform>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public IsActive()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
