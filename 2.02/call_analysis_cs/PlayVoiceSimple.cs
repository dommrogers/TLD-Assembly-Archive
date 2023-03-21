using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayVoiceSimple : BaseSimpleAudioComponent
{
	public string m_EventName;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool m_TrackPosition;

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "AddVoice")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayVoiceSimple()
	{
	}
}
