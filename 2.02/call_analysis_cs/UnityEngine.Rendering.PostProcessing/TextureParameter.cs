using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	public TextureParameterDefault defaultState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetLutStrip")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	public override void Interp(Texture from, Texture to, float t)
	{
	}

	[CalledBy(Type = typeof(MaskedBlurEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(SuffocationScreenEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProAnalogTVNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBottomNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProColormapPalette), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProCustomTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProGlitch1), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProGlitch3), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor")]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	public TextureParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
