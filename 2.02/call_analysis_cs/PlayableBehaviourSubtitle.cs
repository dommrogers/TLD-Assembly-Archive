using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSubtitle : PlayableBehaviour
{
	public string m_LocID;

	public bool m_IsUnknownSpeaker;

	private bool m_IsShowingSubtitles;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PlayableBehaviourSubtitle()
	{
	}
}
