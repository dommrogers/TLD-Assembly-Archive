using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LocalizedDamage : MonoBehaviour
{
	public BodyPart m_BodyPart;

	private BodyDamage m_BodyDamage;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public void SetBodyDamage(BodyDamage bodyDamage)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	public float GetDamageScale(BodyDamage.Weapon weapon)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[CallerCount(Count = 0)]
	public float GetBleedOutMinutes(BodyDamage.Weapon weapon)
	{
		return default(float);
	}

	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	public int GetChanceKill(BodyDamage.Weapon weapon)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedDamage), Member = "HasBodyDamage")]
	[CallerCount(Count = 3)]
	public bool RollChanceToKill(BodyDamage.Weapon weapon)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "RollChanceToKill")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetChanceKill")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(LocalizedDamage), Member = "GetBleedOutMinutes")]
	private bool HasBodyDamage()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LocalizedDamage()
	{
	}
}
