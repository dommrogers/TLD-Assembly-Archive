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

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[CallsUnknownMethods(Count = 22)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public PlayableAssetSetFPAnchor()
	{
	}
}
