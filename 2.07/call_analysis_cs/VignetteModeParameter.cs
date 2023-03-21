using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class VignetteModeParameter : ParameterOverride<VignetteShape>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public VignetteModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
