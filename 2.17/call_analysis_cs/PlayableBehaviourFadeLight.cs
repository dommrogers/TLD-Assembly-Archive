using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourFadeLight : PlayableBehaviour
{
	public List<Light> m_Lights;

	public PlayableAssetFadeLight.FadeType m_FadeType;

	public float m_FadedOutPercent;

	public float m_FadedInPercent;

	public static Dictionary<Light, float> s_OriginalIntensitiesDict;

	public static bool s_DisableLightFade;

	private float m_CurrentValue;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearCachedValuesForLights(Light[] lights)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetCachedValuesForLightsToCurrent(Light[] lights)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetLightFadeDisabled(bool disabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourFadeLight()
	{
	}
}
