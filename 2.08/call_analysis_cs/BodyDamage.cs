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

	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	public float GetDamageScale(BodyPart bodyPart, Weapon w)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[CallerCount(Count = 4)]
	public float GetBleedOutMinutes(BodyPart bodyPart, Weapon w)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CallsUnknownMethods(Count = 3)]
	public int GetChanceKill(BodyPart bodyPart, Weapon w)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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
