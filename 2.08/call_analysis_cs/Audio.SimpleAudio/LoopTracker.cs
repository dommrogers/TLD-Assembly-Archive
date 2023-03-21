using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class LoopTracker : BaseTracker
{
	public AkGameObj m_AudioObject;

	public bool m_DynamicProxy;

	public uint m_Instance;

	public AK.Wwise.Event m_Event;

	public string m_EventID;

	public EmitterProxy m_Proxy;

	public bool m_TrackPosition;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(VoiceTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayVoiceSimple), Member = "Start")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	public LoopTracker(AK.Wwise.Event eventSpec, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	public override void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	private void PlayFromEvent()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlayFromEventString()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	protected override void Stop()
	{
	}

	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetupDynamicProxy()
	{
	}
}
