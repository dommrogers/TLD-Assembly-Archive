using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality>
{
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AmbientOcclusionQualityParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
