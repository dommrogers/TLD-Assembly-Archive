using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class ChallengeLockConditionHunted : ChallengeLockCondition
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsLocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ChallengeLockConditionHunted()
	{
	}
}
