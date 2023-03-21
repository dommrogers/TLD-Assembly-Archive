using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProAnalogTVNoise : PostProcessEffectSettings
{
	public BoolParameter staticNoise;

	public BoolParameter Horizontal;

	public FloatParameter Fade;

	public FloatParameter barHeight;

	public Vector2Parameter tile;

	public FloatParameter textureAngle;

	public FloatParameter edgeCutOff;

	public FloatParameter CutOff;

	public FloatParameter barSpeed;

	public TextureParameter texture;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	public RLProAnalogTVNoise()
	{
	}
}
