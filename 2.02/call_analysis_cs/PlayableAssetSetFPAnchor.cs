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

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(TimelineAsset), Member = "UpdateOutputTrackCache")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSetFPAnchor()
	{
	}
}
