using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class IntParameter : ParameterOverride<int>
{
	[CallerCount(Count = 0)]
	public override void Interp(int from, int to, float t)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool Equals(int a, int b)
	{
		return false;
	}

	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProColormapPalette), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProLowRes), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(MotionBlur), Member = ".ctor")]
	[CalledBy(Type = typeof(ScreenSpaceReflections), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IntParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
