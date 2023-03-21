using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;

namespace Audio.SimpleAudio;

public class PlayAudioSimple : BaseSimpleAudioComponent
{
	public Event m_Event;

	public string m_EventName;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool m_TrackPosition;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public PlayAudioSimple()
	{
	}
}
