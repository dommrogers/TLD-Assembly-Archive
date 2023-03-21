using Cpp2ILInjected.CallAnalysis;

namespace Audio.SimpleAudio;

public class PlayVoiceSimple : BaseSimpleAudioComponent
{
	public string m_EventName;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool m_TrackPosition;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public PlayVoiceSimple()
	{
	}
}
