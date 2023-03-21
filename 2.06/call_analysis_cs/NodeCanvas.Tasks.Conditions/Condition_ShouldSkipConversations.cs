using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ShouldSkipConversations : ConditionTask
{
	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_ShouldSkipConversations()
	{
	}
}
