using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProColormapPalette : PostProcessEffectSettings
{
	public resModeParameter resolutionMode;

	public IntParameter pixelSize;

	public Vector2IntParameter resolution;

	public FloatParameter opacity;

	public FloatParameter dither;

	public preLParameter presetsList;

	public IntParameter presetIndex;

	public TextureParameter bluenoise;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 63)]
	public RLProColormapPalette()
	{
	}
}
