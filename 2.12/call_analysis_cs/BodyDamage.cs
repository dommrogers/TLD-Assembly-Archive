using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyDamage : MonoBehaviour
{
	public List<DamageRegion> m_DamageRegions;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(ArrowItem), Member = "GetDamageParameters")]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDamageScale(BodyPart bodyPart, WeaponSource w)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(ArrowItem), Member = "GetDamageParameters")]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[CallsUnknownMethods(Count = 2)]
	public float GetBleedOutMinutes(BodyPart bodyPart, WeaponSource w)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int GetChanceKill(BodyPart bodyPart, WeaponSource w)
	{
		return 0;
	}

	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private DamageRegion GetDamageById(BodyPart bodyPart)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BodyDamage()
	{
	}
}
