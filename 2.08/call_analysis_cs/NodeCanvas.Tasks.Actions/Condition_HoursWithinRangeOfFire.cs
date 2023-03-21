using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Condition_HoursWithinRangeOfFire : ConditionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HoursWithinRangeOfFire()
	{
	}
}
