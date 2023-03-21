using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyDamage : MonoBehaviour
{
	public enum Weapon
	{
		Unspecified,
		Arrow,
		FlareGun,
		Revolver,
		Rifle
	}

	public List<DamageRegion> m_DamageRegions;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	public float GetDamageScale(BodyPart bodyPart, Weapon w)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public float GetBleedOutMinutes(BodyPart bodyPart, Weapon w)
	{
		return default(float);
	}

	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	public int GetChanceKill(BodyPart bodyPart, Weapon w)
	{
		return default(int);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private DamageRegion GetDamageById(BodyPart bodyPart)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public BodyDamage()
	{
	}
}
