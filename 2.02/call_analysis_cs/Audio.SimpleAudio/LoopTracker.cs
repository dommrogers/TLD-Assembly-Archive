using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class LoopTracker : BaseTracker
{
	public AkGameObj m_AudioObject;

	public bool m_DynamicProxy;

	public uint m_Instance;

	public string m_EventID;

	public EmitterProxy m_Proxy;

	public bool m_TrackPosition;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VoiceTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public override void Cleanup()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool HasProxy()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	protected override void Stop()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	protected void SetupDynamicProxy()
	{
	}
}
