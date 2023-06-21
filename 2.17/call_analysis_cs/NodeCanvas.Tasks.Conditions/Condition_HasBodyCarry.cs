using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_HasBodyCarry : ConditionTask
{
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HasBodyCarry()
	{
	}
}
