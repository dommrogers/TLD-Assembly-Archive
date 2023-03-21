using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BlendModeParameter : ParameterOverride<BlendingMode>
{
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public BlendModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
