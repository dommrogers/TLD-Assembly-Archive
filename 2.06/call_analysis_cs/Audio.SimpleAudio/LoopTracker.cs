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

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public LoopTracker(AK.Wwise.Event eventSpec, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, default(float), stopWhenDisabled: default(bool))
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	protected override void Stop()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetupDynamicProxy()
	{
	}
}
