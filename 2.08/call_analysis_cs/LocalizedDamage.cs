using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LocalizedDamage : MonoBehaviour
{
	public BodyPart m_BodyPart;

	private BodyDamage m_BodyDamage;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	public float GetBleedOutMinutes(BodyDamage.Weapon weapon)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CallsUnknownMethods(Count = 1)]
	public int GetChanceKill(BodyDamage.Weapon weapon)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[CallerCount(Count = 3)]
	public bool RollChanceToKill(BodyDamage.Weapon weapon)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 10)]
	private bool HasBodyDamage()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LocalizedDamage()
	{
	}
}
