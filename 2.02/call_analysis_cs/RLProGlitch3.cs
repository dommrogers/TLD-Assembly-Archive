using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProGlitch3 : PostProcessEffectSettings
{
	public FloatParameter speed;

	public FloatParameter density;

	public FloatParameter maxDisplace;

	public BoolParameter mask;

	public TextureParameter maskTexture;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 40)]
	public RLProGlitch3()
	{
	}
}
