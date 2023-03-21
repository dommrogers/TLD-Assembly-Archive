using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ColorParameter : ParameterOverride<Color>
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Interp(Color from, Color to, float t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator Vector4(ColorParameter prop)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public override bool Equals(Color a, Color b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Bloom), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProUltimateVignette), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProArtefacts), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(RLProVHSScanlines), Member = ".ctor")]
	public ColorParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
