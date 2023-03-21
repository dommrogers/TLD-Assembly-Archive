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

	[CalledBy(Type = typeof(PlayVoiceSimple), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(VoiceTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayAudioSimple), Member = "Start")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public LoopTracker(AK.Wwise.Event eventSpec, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	private void PlayFromEvent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	private void PlayFromEventString()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	protected override void Stop()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	protected void SetupDynamicProxy()
	{
	}
}
