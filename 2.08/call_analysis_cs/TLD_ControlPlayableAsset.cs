using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_ControlPlayableAsset : ControlPlayableAsset
{
	public string m_MissionObjectId;

	private bool m_IsPlaying;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ControlPlayableAsset), Member = "CreatePlayable")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsUnknownMethods(Count = 1)]
	private GameObject FindGameObject(string missionObjectId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TLD_ControlPlayableAsset()
	{
	}
}
