using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayAudioSimple : BaseSimpleAudioComponent
{
	public string m_EventName;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool m_TrackPosition;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Add")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayAudioSimple()
	{
	}
}
