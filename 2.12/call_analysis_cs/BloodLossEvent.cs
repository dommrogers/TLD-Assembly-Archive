using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class BloodLossEvent : MinorBruisingEvent
{
	private RiskOfInfectionEvent m_RiskOfInfection;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BloodLossEvent()
	{
	}
}
