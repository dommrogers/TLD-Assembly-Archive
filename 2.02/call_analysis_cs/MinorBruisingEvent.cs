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
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MinorBruisingEvent()
	{
	}
}
