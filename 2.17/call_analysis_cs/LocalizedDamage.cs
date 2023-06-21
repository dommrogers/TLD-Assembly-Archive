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

	[DeduplicatedMethod]
	[CallerCount(Count = 57)]
	public void SetBodyDamage(BodyDamage bodyDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CallsUnknownMethods(Count = 1)]
	public float GetDamageScale(WeaponSource weapon)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBleedOutMinutes(WeaponSource weapon)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CallsUnknownMethods(Count = 1)]
	public int GetChanceKill(WeaponSource weapon)
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 1)]
	public bool RollChanceToKill(WeaponSource weapon)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CalledBy(Type = typeof(ArrowItem), Member = "GetDamageParameters")]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeSpawnImpactEffects")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private bool HasBodyDamage()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LocalizedDamage()
	{
	}
}
