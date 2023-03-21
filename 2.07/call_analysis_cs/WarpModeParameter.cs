using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class WarpModeParameter : ParameterOverride<WarpMode>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public WarpModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
