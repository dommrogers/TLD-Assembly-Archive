using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourSpeakerName : PlayableBehaviour
{
	public string m_LocID;

	public bool m_IsUnknownSpeaker;

	public PlayableAssetSpeakerName.SourceType m_SourceType;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSpeakerName")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourSpeakerName()
	{
	}
}
