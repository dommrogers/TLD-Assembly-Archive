using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Condition_IsDarkwalkerInBanishmentArea : ConditionTask
{
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsDarkwalkerInBanishmentArea()
	{
	}
}
