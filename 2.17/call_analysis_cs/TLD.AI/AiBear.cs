using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.AI;

public class AiBear : BaseAi
{
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsImposter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiBear()
	{
	}
}
