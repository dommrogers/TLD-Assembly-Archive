using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class SuffocationScreenEffect : PostProcessEffectSettings
{
	public FloatParameter m_Intensity;

	public FloatParameter m_RadialBlurAmount;

	public FloatParameter m_RadialBlurCenterOffset;

	public FloatParameter m_RadialBlurPower;

	public FloatParameter m_VignetteStrength;

	public Vector4Parameter m_NoiseScaleAndSpeed;

	public TextureParameter m_NoiseTexture;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4Parameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 55)]
	public SuffocationScreenEffect()
	{
	}
}
