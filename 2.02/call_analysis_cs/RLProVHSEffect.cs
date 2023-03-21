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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 126)]
	public RLProVHSEffect()
	{
	}
}
