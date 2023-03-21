using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetFadeLight : PlayableAsset
{
	public enum FadeType
	{
		FadeIn,
		FadeOut
	}

	public string m_MissionObjectId;

	public float m_FadedInPercent;

	public float m_FadedOutPercent;

	public FadeType m_FadeType;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 14)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public PlayableAssetFadeLight()
	{
	}
}
