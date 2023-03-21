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
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 78)]
	public RLProAnalogTVNoise()
	{
	}
}
