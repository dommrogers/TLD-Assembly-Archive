using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;

namespace TLD.FX;

public class EmissiveGlow : MonoBehaviour
{
	public enum Channel
	{
		Red = 1,
		Green = 2,
		Blue = 4
	}

	private Renderer[] m_AffectedRenderers;

	private bool m_NormalizeToCurve;

	private AnimationCurve m_StrengthCurve;

	private UnityEvent<Color> m_ColorChanged;

	private UnityEvent<float> m_StrengthChanged;

	private UnityEvent<float> m_RedChannelStrengthChanged;

	private UnityEvent<float> m_GreenChannelStrengthChanged;

	private UnityEvent<float> m_BlueChannelStrengthChanged;

	private MaterialPropertyBlock m_PropertyBlock;

	private Vector4 m_EmissiveStrengths;

	private static readonly int s_EmissiveColorID;

	private static readonly int s_EmissiveStrengthID;

	private static readonly int s_EmissiveStrengthByChannelID;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "OnTrackingModeChanged")]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "SetCurrentTrackingMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateEmissiveColor(Color color)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateRenderers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateEmissiveStrength(float strength)
	{
	}

	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "Update")]
	[CalledBy(Type = typeof(FirstPersonHandheldShortwave), Member = "UpdateBlinkingLight")]
	[CalledBy(Type = typeof(HandheldShortwaveItem), Member = "UpdateBlinkingLight")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[Calls(Type = typeof(EmissiveGlow), Member = "UpdateRenderers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateEmissiveStrengthByChannel(float strength, Channel maskChannel)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector4), Member = "set_Item")]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	private void UpdateChannel(float strength, Channel maskChannel, Channel comparison, int colorIndex, UnityEvent<float> callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private float MaybeNormalizeStrengthToCurve(float strength)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveStrength")]
	[CalledBy(Type = typeof(EmissiveGlow), Member = "UpdateEmissiveStrengthByChannel")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRenderers()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public EmissiveGlow()
	{
	}
}
