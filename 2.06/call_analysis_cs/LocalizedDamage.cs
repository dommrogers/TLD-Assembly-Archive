using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LocalizedDamage : MonoBehaviour
{
	public BodyPart m_BodyPart;

	private BodyDamage m_BodyDamage;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	public void SetBodyDamage(BodyDamage bodyDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CallsUnknownMethods(Count = 1)]
	public float GetDamageScale(BodyDamage.Weapon weapon)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageById")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	public float GetBleedOutMinutes(BodyDamage.Weapon weapon)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	public int GetChanceKill(BodyDamage.Weapon weapon)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	public bool RollChanceToKill(BodyDamage.Weapon weapon)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private bool HasBodyDamage()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LocalizedDamage()
	{
	}
}
