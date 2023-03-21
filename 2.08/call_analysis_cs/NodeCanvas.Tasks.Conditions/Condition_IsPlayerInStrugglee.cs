using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsPlayerInStrugglee : ConditionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_IsPlayerInStrugglee()
	{
	}
}
