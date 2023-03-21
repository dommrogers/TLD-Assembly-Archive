using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class GradingModeParameter : ParameterOverride<GradingMode>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GradingModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
