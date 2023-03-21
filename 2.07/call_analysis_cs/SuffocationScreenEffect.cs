using System;
using Cpp2ILInjected.CallAnalysis;
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
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public SuffocationScreenEffect()
	{
	}
}
