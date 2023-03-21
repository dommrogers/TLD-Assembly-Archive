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

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public RLProBottomNoise()
	{
	}
}
