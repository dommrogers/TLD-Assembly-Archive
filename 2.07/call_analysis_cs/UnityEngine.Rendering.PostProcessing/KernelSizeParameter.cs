using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public KernelSizeParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
