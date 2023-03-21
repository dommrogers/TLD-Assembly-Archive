using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	public TextureParameterDefault defaultState;

	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetLutStrip")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetLutStrip")]
	public override void Interp(Texture from, Texture to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public TextureParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
