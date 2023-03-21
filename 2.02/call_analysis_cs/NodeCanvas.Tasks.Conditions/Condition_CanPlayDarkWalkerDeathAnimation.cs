using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_CanPlayDarkWalkerDeathAnimation : ConditionTask
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CallsUnknownMethods(Count = 2)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Condition_CanPlayDarkWalkerDeathAnimation()
	{
	}
}
