using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MinorBruisingEvent : StruggleDamageEvent
{
	public float m_DamageMin;

	public float m_DamageMax;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	public override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsLocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public MinorBruisingEvent()
	{
	}
}
