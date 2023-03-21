using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_HintQueueFull : ConditionTask
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsHintQueueFull")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HintQueueFull()
	{
	}
}
