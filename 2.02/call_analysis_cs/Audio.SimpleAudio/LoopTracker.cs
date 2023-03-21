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

	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	[CalledBy(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CalledBy(Type = typeof(VoiceTracker), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseTracker), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LoopTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, 0f, stopWhenDisabled: false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Cleanup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool HasProxy()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public override bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected override void Stop()
	{
	}

	[CalledBy(Type = typeof(LoopTracker), Member = "Start")]
	[CalledBy(Type = typeof(VoiceTracker), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected void SetupDynamicProxy()
	{
	}
}
