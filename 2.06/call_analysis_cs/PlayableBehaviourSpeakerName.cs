using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourSpeakerName : PlayableBehaviour
{
	public string m_LocID;

	public bool m_IsUnknownSpeaker;

	public PlayableAssetSpeakerName.SourceType m_SourceType;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourSpeakerName()
	{
	}
}
