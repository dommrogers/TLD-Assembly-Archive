using System;
using Cpp2ILInjected.CallAnalysis;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class resModeParameter : ParameterOverride<ResolutionMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public resModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
