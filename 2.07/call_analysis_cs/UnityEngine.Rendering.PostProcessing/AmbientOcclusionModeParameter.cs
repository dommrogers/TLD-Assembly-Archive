using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AmbientOcclusionModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
