using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public VignetteModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
