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

	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 96)]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public RLProGlitch1()
	{
	}
}
