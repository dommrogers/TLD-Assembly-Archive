using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourSpeakerName : PlayableBehaviour
{
	public string m_LocID;

	public bool m_IsUnknownSpeaker;

	public PlayableAssetSpeakerName.SourceType m_SourceType;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSpeakerNameDuringPhoneCalls")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourSpeakerName()
	{
	}
}
