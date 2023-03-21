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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 51)]
	public RLProAnalogTVNoise()
	{
	}
}
