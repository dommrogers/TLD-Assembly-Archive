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
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 41)]
	public RLProColormapPalette()
	{
	}
}
