using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class SprainedWristEvent : StruggleDamageEvent
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool CanExecute()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	public override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsLocationAvailable()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SprainedWristEvent()
	{
	}
}
