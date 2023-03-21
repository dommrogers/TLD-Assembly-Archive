using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CanPlayDarkWalkerDeathAnimation : ConditionTask
{
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_CanPlayDarkWalkerDeathAnimation()
	{
	}
}
