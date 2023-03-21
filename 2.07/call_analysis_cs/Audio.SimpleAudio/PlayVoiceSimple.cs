using Cpp2ILInjected.CallAnalysis;

namespace Audio.SimpleAudio;

public class PlayVoiceSimple : BaseSimpleAudioComponent
{
	public string m_EventName;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool m_TrackPosition;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public PlayVoiceSimple()
	{
	}
}
