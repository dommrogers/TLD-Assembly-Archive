using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public EyeAdaptationParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
