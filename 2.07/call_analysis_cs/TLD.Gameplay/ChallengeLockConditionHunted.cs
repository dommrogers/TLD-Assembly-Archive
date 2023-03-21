using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using UnityEngine;

namespace TLD.Gameplay;

public class ChallengeLockConditionHunted : ChallengeLockCondition
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsLocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ChallengeLockConditionHunted()
	{
	}
}
