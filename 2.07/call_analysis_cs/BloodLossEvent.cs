using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class BloodLossEvent : MinorBruisingEvent
{
	private RiskOfInfectionEvent m_RiskOfInfection;

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public override bool IsLocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BloodLossEvent()
	{
	}
}
