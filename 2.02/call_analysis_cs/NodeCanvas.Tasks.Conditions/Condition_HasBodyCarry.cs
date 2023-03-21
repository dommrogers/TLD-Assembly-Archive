using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_HasBodyCarry : ConditionTask
{
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_HasBodyCarry()
	{
	}
}
