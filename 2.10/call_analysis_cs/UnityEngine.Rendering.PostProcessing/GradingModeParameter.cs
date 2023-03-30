using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class GradingModeParameter : ParameterOverride<GradingMode>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GradingModeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
