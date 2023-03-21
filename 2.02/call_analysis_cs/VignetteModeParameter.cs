using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class VignetteModeParameter : ParameterOverride<VignetteShape>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public VignetteModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
