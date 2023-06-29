using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EyeAdaptationParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
