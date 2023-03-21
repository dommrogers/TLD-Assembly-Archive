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
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetFadeLight()
	{
	}
}
