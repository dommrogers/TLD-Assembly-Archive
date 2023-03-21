using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine.Playables;

public class PlayableBehaviourSubtitle : PlayableBehaviour
{
	public string m_LocID;

	public bool m_IsUnknownSpeaker;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private bool m_IsShowingSubtitles;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourSubtitle()
	{
	}
}
