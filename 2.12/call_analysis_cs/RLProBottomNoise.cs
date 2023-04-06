using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProBottomNoise : PostProcessEffectSettings
{
	public FloatParameter height;

	public FloatParameter intencity;

	public TextureParameter noiseTexture;

	public Vector2Parameter tile;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public RLProBottomNoise()
	{
	}
}
