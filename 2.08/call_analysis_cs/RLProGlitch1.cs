using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProGlitch1 : PostProcessEffectSettings
{
	public FloatParameter amount;

	public FloatParameter stretch;

	public FloatParameter speed;

	public FloatParameter fade;

	public FloatParameter rMultiplier;

	public FloatParameter gMultiplier;

	public FloatParameter bMultiplier;

	public FloatParameter x;

	public FloatParameter y;

	public FloatParameter angleY;

	public BoolParameter mask;

	public TextureParameter maskTexture;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public RLProGlitch1()
	{
	}
}
