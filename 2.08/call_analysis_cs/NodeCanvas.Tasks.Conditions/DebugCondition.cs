using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class DebugCondition : ConditionTask
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DebugCondition()
	{
	}
}
