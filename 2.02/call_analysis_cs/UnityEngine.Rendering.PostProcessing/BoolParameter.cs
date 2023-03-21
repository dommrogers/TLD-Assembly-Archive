using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CalledBy(Type = typeof(RLProAnalogTVNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProArtefacts), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBottomStretch), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProGlitch1), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProGlitch3), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProJitter), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSScanlines), Member = ".ctor")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor")]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor")]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(Grain), Member = ".ctor")]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor")]
	[CalledBy(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
