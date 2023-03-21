using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class WarpModeParameter : ParameterOverride<WarpMode>
{
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RLProTVEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProWarp), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public WarpModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
