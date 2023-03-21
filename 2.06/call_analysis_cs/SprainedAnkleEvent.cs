using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class SprainedAnkleEvent : StruggleDamageEvent
{
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 0)]
	protected override bool CanExecute()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthBear")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 4)]
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
	public SprainedAnkleEvent()
	{
	}
}
