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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 26)]
	public RLProGlitch3()
	{
	}
}
