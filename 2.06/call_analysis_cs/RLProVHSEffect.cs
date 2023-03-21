using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProVHSEffect : PostProcessEffectSettings
{
	public FloatParameter colorOffset;

	public FloatParameter colorOffsetAngle;

	public FloatParameter verticalOffsetFrequency;

	public FloatParameter verticalOffset;

	public FloatParameter offsetDistortion;

	public TextureParameter noiseTexture;

	public BlendModeParameter blendMode;

	public Vector2Parameter tile;

	public FloatParameter _textureIntensity;

	public BoolParameter smoothCut;

	public IntParameter iterations;

	public FloatParameter smoothSize;

	public FloatParameter deviation;

	public FloatParameter _textureCutOff;

	public FloatParameter stripes;

	public BoolParameter unscaledTime;

	[CallsUnknownMethods(Count = 87)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public RLProVHSEffect()
	{
	}
}
