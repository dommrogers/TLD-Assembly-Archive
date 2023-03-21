using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode>
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public VignetteModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
