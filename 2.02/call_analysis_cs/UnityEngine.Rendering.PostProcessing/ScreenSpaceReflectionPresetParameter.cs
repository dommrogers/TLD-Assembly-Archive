using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public ScreenSpaceReflectionPresetParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
