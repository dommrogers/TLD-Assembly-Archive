using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.AI;

public class PackSettings : ScriptableObject
{
	public float m_PackFormRange;

	public float m_PackReformDelayTimeMinutes;

	public float m_TaggedGroupPackReformDelayTimeMinutes;

	public float m_DisbandGroupOnForgetTargetAfterTimeHours;

	public float m_DisbandTaggedGroupOnForgetTargetAfterTimeHours;

	public float m_DespawnLonersAfterInteriorTimeHours;

	public float m_AttackCooldownSeconds;

	public float m_HoldGroundBlueFlareDistance;

	public float m_AttackCombatRestrictedCooldownSeconds;

	public float m_HoldGroundCombatRestrictedTimeSeconds;

	public float m_HoldGroundTimeSeconds;

	public float m_FleeMoraleThreshold;

	public float m_MinMoraleFleeChance;

	public float m_MaxMoraleFleeChance;

	public float m_FleeFromBearRange;

	public float m_MoraleModifierHitByBlueFlarePercent;

	public float m_MoraleModifierHitByRedFlarePercent;

	public float m_MoraleModifierHitByTorchPercent;

	public float m_MoraleModifierHitByStonePercent;

	public float m_MoraleModifierThrownRedFlarePercent;

	public float m_MoraleModifierThrownBlueFlarePercent;

	public float m_MoraleModifierThrownTorchPercent;

	public float m_MoraleModifierThrownStonePercent;

	public float m_MoraleModifierThrownNoiseMakerPercent;

	public float m_MoraleModifierOnFlareGunRoundPercent;

	public float m_MoraleModifierOnFlareGunRoundStuckInAnimalPercent;

	public float m_ReactToGunShotDistance;

	public float m_MoraleModifierNearMissGunshotPercent;

	public float m_MoraleModifierGunshotPercent;

	public float m_MoraleModifierDamagePercent;

	public float m_MoraleModifierDamageLeaderPercent;

	public float m_MoraleModifierMultiplierAuroraActive;

	public float m_PackFormationRange;

	public float m_MinBleedOutTimeMinutes;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PackSettings()
	{
	}
}
