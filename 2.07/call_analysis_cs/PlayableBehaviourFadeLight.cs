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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsUnknownMethods(Count = 6)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 4)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 4)]
	public static void SetLightFadeDisabled(bool disabled)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourFadeLight()
	{
	}
}
