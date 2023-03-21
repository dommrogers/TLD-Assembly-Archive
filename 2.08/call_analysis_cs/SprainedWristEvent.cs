using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class SprainedWristEvent : StruggleDamageEvent
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	protected override bool CanExecute()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	public override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
