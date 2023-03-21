using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RiskOfInfectionEvent : StruggleDamageEvent
{
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocationOfLastAdded")]
	[Calls(Type = typeof(InfectionRisk), Member = "InfectionRiskStart")]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocationOfLastAdded")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(CameraStatusEffects), Member = "PainPulse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	public override void OnExecute()
	{
	}

	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 6)]
	public override bool IsLocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public RiskOfInfectionEvent()
	{
	}
}
