using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PlayableAssetSetFPAnchor : PlayableAsset
{
	public string m_ObjectName;

	public bool m_AttemptToFindObjectInChildren;

	public string m_SyncNodeInfoId;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayableAssetSetFPAnchor()
	{
	}
}
