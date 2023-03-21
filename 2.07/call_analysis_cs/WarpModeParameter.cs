using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class WarpModeParameter : ParameterOverride<WarpMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public WarpModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
