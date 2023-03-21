using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Condition_HoursWithinRangeOfFire : ConditionTask
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HoursWithinRangeOfFire()
	{
	}
}
