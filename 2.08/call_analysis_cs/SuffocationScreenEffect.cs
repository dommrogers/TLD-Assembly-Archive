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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public SuffocationScreenEffect()
	{
	}
}
