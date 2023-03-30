using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	public TextureParameterDefault defaultState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetLutStrip")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public override void Interp(Texture from, Texture to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextureParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
