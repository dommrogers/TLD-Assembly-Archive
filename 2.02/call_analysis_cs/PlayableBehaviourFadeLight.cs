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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetDuration")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsUnknownMethods(Count = 5)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 4)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void ClearCachedValuesForLights(Light[] lights)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[CallsUnknownMethods(Count = 5)]
	public static void SetCachedValuesForLightsToCurrent(Light[] lights)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	public static void SetLightFadeDisabled(bool disabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourFadeLight()
	{
	}
}
