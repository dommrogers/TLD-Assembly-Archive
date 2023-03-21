using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BlendModeParameter : ParameterOverride<BlendingMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BlendModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
